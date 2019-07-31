using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FileArchive.ApplicationService.Files.Dto;
using FileArchive.Core;
using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;

namespace FileArchive.ApplicationService.Files
{
    public class FileService : IFileService
    {
        public IFileRepository FileRepository { get; }
        private readonly IMapper Mapper;
        public FileService(IFileRepository fileRepository, IMapper mapper)
        {
            Mapper = mapper;
            FileRepository = fileRepository;
        }

        public async Task<GetAllFileDtoResult> GetAllAsync()
        {
            var result = new GetAllFileDtoResult
            {
                Files = Mapper.Map<List<FileDto>>(await FileRepository.GetAllAsync())
            };
            return result;
        }

        public CreateFileDtoResult Create(FileDto file)
        {
            var result = new CreateFileDtoResult();
            var item = Mapper.Map<File>(file);
            FileRepository.AddAsync(item);
            return result;
        }

        public Result Update(FileDto file)
        {
            var result = new Result();
            var item = Mapper.Map<File>(file);
            FileRepository.UpdateAsync(item,file.Id);
            return result;
        }

        public Result Delete(FileDto file)
        {
            var result = new Result();
            var item = FileRepository.Find(x=>x.Id == file.Id);
            FileRepository.Delete(item);
            return result;
        }
    }
}
