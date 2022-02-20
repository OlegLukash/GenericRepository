﻿using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly List<TEntity> _entities;

        public GenericRepository()
        {
            _entities = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        { 
            var dbEntity = GetById(entity.Id);

            if (dbEntity == null)
            {
                throw new InvalidOperationException($"Entity with {entity.Id} does not exist in the database");
            }

            _entities.Remove(dbEntity);
        }

        public void Remove(int id)
        {
            var dbEntity = GetById(id);
            if (dbEntity == null)
            {
                throw new InvalidOperationException($"Entity with {id} does not exist in the database");
            }

            _entities.Remove(dbEntity);
        }

        public TEntity GetById(int id)
        {
            return _entities.FirstOrDefault(entity => entity.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities;
        }
    }
}
