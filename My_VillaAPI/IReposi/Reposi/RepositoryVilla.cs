using Microsoft.EntityFrameworkCore;
using My_VillaAPI.Data;
using My_VillaAPI.IRespo;
using My_VillaAPI.IResposi.Reposi;
using My_VillaAPI.Models;
using System.Linq;
using System.Linq.Expressions;

namespace My_VillaAPI.IReposi.Reposi
{
    public class RepositoryVilla : Repository<Villa>, IRepositoryVilla
    {
        private readonly MyDbContext _db;

        public RepositoryVilla(MyDbContext db) : base (db)
        {
            _db = db;
        }
       

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
