﻿using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    /// <summary>
    /// This entity has three fixed records 1-Image, 2-Media , 3-Other(docs,zip,pdf ,...)
    /// </summary>
    public class FileType : Entity
    {
        public string Title { get; set; }
    }
}
