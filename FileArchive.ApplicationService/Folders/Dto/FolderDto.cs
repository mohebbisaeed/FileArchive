using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.ApplicationService.Folders.Dto
{
    public class FolderDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }

    }

    public class GetAllFolderDtoResult : Result
    {
        public ICollection<FolderDto> Folders { get; set; }
    }

    public class CreateFolderDtoResult : Result
    {
        public Guid Id { get; set; }
    }

}
