using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class File : IEntity<Guid>
    {
        public Guid Id { get; set; } 
        public string FileExtention { get; set; }
        public byte[] Body { get; set; }
        public virtual ICollection<FileDetail> FileDetails { get; set; }
    }
}
