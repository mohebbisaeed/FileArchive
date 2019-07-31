using FileArchive.ApplicationService.FileDetails.Dto;
using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.ApplicationService.Files.Dto
{
    public class FileDto
    {
        public Guid Id { get; set; }
        public string FileExtention { get; set; }
        public byte[] Body { get; set; }
        public ICollection<FileDetailDto> FileDetails { get; set; }
    }

    public class GetAllFileDtoResult : Result
    {
        public ICollection<FileDto> Files { get; set; }
    }

    public class CreateFileDtoResult : Result
    {
        public Guid Id { get; set; }
    }

}
