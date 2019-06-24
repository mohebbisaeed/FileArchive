using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class MediaFile : Entity
    {
        public Guid FileId { get; set; }
        public virtual File File { get; set; }
        public string Title { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
    }
}
