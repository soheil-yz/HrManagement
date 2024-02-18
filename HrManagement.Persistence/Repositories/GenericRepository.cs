using Hr_Management.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly LeaveManagementDbContext _context;

        public GenericRepository(LeaveManagementDbContext context)
        {
            _context = context;
        }
        Task<T> IGenericRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<T>.Exist(int id)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<T>> IGenericRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
