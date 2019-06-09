using System;

namespace FileArchive.Core
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
