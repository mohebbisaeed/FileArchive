using FileArchive.Core;
using FileArchive.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class FileCustomProperty : Entity
    {
        public string Title { get; set; }
        public FileCustomPropertyStatus FileCustomPropertyStatus { get; set; }
        public int Sorted { get; set; }
    }
}
