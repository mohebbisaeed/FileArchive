using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FileArchive.ApplicationService.Files.Dto;
using FileArchive.ApplicationService.Folders.Dto;
using FileArchive.Core;
using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;

namespace FileArchive.ApplicationService.Folders
{
    public class FileDetailService : IFolderService
    {
        public IFolderRepository FolderRepository { get; }
        private readonly IMapper Mapper;
        public FileDetailService(IFolderRepository folderRepository, IMapper mapper)
        {
            Mapper = mapper;
            FolderRepository = folderRepository;
        }

        public async Task<GetAllFolderDtoResult> GetAllAsync()
        {
            var result = new GetAllFolderDtoResult
            {
                Folders = Mapper.Map<List<FolderDto>>(await FolderRepository.GetAllAsync())
            };
            return result;
        }

        public CreateFolderDtoResult Create(FolderDto Folder)
        {
            var result = new CreateFolderDtoResult();
            var item = Mapper.Map<Folder>(Folder);
            FolderRepository.AddAsync(item);
            return result;
        }

        public Result Update(FolderDto Folder)
        {
            var result = new Result();
            var item = Mapper.Map<Folder>(Folder);
            FolderRepository.UpdateAsync(item, Folder.Id);
            return result;
        }

        public Result Delete(FolderDto Folder)
        {
            var result = new Result();
            var item = FolderRepository.Find(x => x.Id == Folder.Id);
            FolderRepository.Delete(item);
            return result;
        }
    }
}
