using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class Setting : File
    {
        public string Title { get; set; }
        public string SettingKey { get; set; }
        public string Value { get; set; }
    }
}
