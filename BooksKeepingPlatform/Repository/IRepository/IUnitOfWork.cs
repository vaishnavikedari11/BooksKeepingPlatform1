﻿namespace BooksKeepingPlatform1.Repository.IRepository
{
    public interface IUnitOfWork
    {

        ICategoryRepository Category { get; }

        IProductRepository Product { get; }

        void Save();
    }
}
