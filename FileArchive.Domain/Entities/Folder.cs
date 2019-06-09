using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class Folder : Entity
    {
        public string Title { get; set; }
        public int ParentId { get; set; }
    }
}
