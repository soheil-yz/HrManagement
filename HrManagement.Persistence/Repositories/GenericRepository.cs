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
        public async Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
