using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    // Repositorio genérico para manejar operaciones CRUD básicas
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            // Agrega una nueva entidad al DbSet
            // Insert into the database will occur when SaveChanges is called on the context
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            // Busca la entidad por su ID y, si existe, la elimina del DbSet
            var entidad = _dbSet.Find(id);

            // Si la entidad existe, se elimina del DbSet.
            // La eliminación real en la base de datos ocurrirá cuando se llame a SaveChanges en el contexto.
            if (entidad != null)
            {
                // Delte from [Table] where Id = @id se ejecutará cuando SaveChanges se llame en el contexto.
                _dbSet.Remove(entidad);
            }
        }

        public T Get(int id)
        {
            // Busca y devuelve la entidad por su ID. Si no se encuentra, se lanza una excepción.
            // SELECT * FROM [Table] WHERE Id = @id se ejecutará cuando
            return _dbSet.Find(id)!;
        }

        public IEnumerable<T> GetAll()
        {
            // Devuelve todas las entidades del DbSet como una lista.
            // SELECT * FROM [Table] se ejecutará cuando se itere sobre la colección o se convierta a una lista.
            return _dbSet.ToList();
        }

        public void Update(T entity)
        {
            // Marca la entidad como modificada en el DbSet.
            // UPDATE [Table] SET ... WHERE Id = @id se ejecutará cuando SaveChanges se llame en el contexto.
            _dbSet.Update(entity);
        }
    }
}
