﻿using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Repository.Repositories
{
    public class FolderRepository : GenericRepository<Folder,int>, IFolderRepository
    {
        public FolderRepository(FileArchiveContext ctx):base(ctx)
        {
        }
    }
}
