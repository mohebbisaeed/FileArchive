using FileArchive.ApplicationService.Files.Dto;
using FileArchive.ApplicationService.Folders.Dto;
using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.ApplicationService.Folders
{
    public interface IFolderService : IService
    {
        Task<GetAllFolderDtoResult> GetAllAsync();
        CreateFolderDtoResult Create(FolderDto folderDto);
        Result Update(FolderDto folderDto);
        Result Delete(FolderDto folderDto);
    }
}
