using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class FileType : FileArchive.Core.Entity
    {
        public string Title { get; set; }
    }
}
