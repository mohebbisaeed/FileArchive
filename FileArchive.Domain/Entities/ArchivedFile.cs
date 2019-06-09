using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class ArchivedFile : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FileExtention { get; set; }
        public byte[] MyProperty { get; set; }
    }
}
