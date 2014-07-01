﻿using LeagueService.Domain.Data.Repository.Abstract;

namespace LeagueService.Domain.Abstract
{
    public abstract class BaseService
    {
        protected IRepository Repo { get; set; }

        protected BaseService(IRepository repo) { Repo = repo; }

        public virtual T Create<T>(T item)
        {
            Repo.Add(item);
            Repo.SaveChanges();

            return item;
        }

        public void Delete<T>(T item)
        {
            Repo.Delete(item);
            Repo.SaveChanges();
        }

        public void Update<T>(T item)
        {
            Repo.SaveChanges();
        }
    }
}