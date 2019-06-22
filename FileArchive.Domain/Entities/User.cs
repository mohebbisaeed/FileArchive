using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class User : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
