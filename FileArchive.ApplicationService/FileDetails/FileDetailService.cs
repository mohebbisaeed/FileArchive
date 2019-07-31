using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FileArchive.ApplicationService.FileDetails.Dto;
using FileArchive.Core;
using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;

namespace FileArchive.ApplicationService.FileDetails
{
    public class FileDetailService : IFileDetailService
    {
        public IFileDetailRepository FileDetailRepository { get; }
        private readonly IMapper Mapper;
        public FileDetailService(IFileDetailRepository fileDetailRepository, IMapper mapper)
        {
            Mapper = mapper;
            FileDetailRepository = fileDetailRepository;
        }

        public async Task<GetAllFileDetailDtoResult> GetAllAsync()
        {
            var result = new GetAllFileDetailDtoResult
            {
                FileDetails = Mapper.Map<List<FileDetailDto>>(await FileDetailRepository.GetAllAsync())
            };
            return result;
        }

        public CreateFileDetailDtoResult Create(FileDetailDto fileDetail)
        {
            var result = new CreateFileDetailDtoResult();
            var item = Mapper.Map<FileDetail>(fileDetail);
            FileDetailRepository.AddAsync(item);
            return result;
        }

        public Result Update(FileDetailDto fileDetail)
        {
            var result = new Result();
            var item = Mapper.Map<FileDetail>(fileDetail);
            FileDetailRepository.UpdateAsync(item, fileDetail.Id);
            return result;
        }

        public Result Delete(FileDetailDto fileDetail)
        {
            var result = new Result();
            var item = FileDetailRepository.Find(x => x.Id == fileDetail.Id);
            FileDetailRepository.Delete(item);
            return result;
        }
    }
}
