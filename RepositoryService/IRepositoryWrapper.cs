﻿namespace NttProject1.RepositoryService
{
    public interface IRepositoryWrapper
    {
        IBomRepository Bom { get; }
        void save();
    }
}
