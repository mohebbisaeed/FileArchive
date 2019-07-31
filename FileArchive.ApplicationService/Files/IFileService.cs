using FileArchive.ApplicationService.Files.Dto;
using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.ApplicationService.Files
{
    public interface IFileService : IService
    {
        Task<GetAllFileDtoResult> GetAllAsync();
        CreateFileDtoResult Create(FileDto fileDto);
        Result Update(FileDto fileDto);
        Result Delete(FileDto fileDto);
    }
}
