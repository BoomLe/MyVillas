using My_VillaAPI.Models;
using System.Linq.Expressions;

namespace My_VillaAPI.IRespo
{
    public interface IRepositoryVilla : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entity);
   
    }
}
