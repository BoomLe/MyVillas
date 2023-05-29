using Microsoft.EntityFrameworkCore;
using My_VillaAPI.Data;
using My_VillaAPI.IRespo;
using My_VillaAPI.IResposi.Reposi;
using My_VillaAPI.Models;
using System.Linq;
using System.Linq.Expressions;

namespace My_VillaAPI.IReposi.Reposi
{
    public class RepositoryVillaNumber : Repository<VillaNumber>, IRepositoryVillaNumber
    {
        private readonly MyDbContext _db;
        public RepositoryVillaNumber(MyDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
