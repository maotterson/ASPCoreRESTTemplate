using ASPCoreREST.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreREST.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
