using My_VillaAPI.Models;
using System.Linq.Expressions;

namespace My_VillaAPI.IRespo
{
    public interface IRepositoryVillaNumber : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
