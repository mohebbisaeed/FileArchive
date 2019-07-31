using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.ApplicationService.FileDetails.Dto
{
    public class FileDetailDto
    {
        public int Id { get; set; }
        public Guid FileId { get; set; }
        public Guid UserId { get; set; }
        public int FolderId { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string OrginalFileName { get; set; }
        public string ExtentionFile { get; set; }
        public int FileTypeId { get; set; }
        public Int64 FileSize { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsPreviewFolder { get; set; }
        public int RatingCount { get; set; }
        public int Rating { get; set; }
        public string CustomProperty1 { get; set; }
        public string CustomProperty2 { get; set; }
        public string CustomProperty3 { get; set; }
        public string CustomProperty4 { get; set; }
        public string CustomProperty5 { get; set; }
        public string CustomProperty6 { get; set; }
        public string CustomProperty7 { get; set; }
        public string CustomProperty8 { get; set; }
        public string CustomProperty9 { get; set; }
        public string CustomProperty10 { get; set; }
        public int FileCustomPropertyStatusId1 { get; set; }
        public int FileCustomPropertyStatusId2 { get; set; }
        public int FileCustomPropertyStatusId3 { get; set; }
        public int FileCustomPropertyStatusId4 { get; set; }
        public int FileCustomPropertyStatusId5 { get; set; }
    }

    public class GetAllFileDetailDtoResult : Result
    {
        public Guid Id { get; set; }
        public ICollection<FileDetailDto> FileDetails { get; set; }
    }

    public class CreateFileDetailDtoResult : Result
    {
        public Guid Id { get; set; }
    }

}
