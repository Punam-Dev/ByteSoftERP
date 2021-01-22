using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ByeSoftERP_API.Models
{
    public class SQLConfigurationRepository : IConfigurationRepository
    {
        private readonly AppDbContext appDbContext;
        public SQLConfigurationRepository(AppDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }

        public async Task<IEnumerable<ProductTypes>> GetProductTypes()
        {
            return await appDbContext.ProductTypes.FromSqlRaw<ProductTypes>("sp_GetProductTypes").ToListAsync();
        }

        public async Task<IEnumerable<UOMs>> GetUOMs()
        {
            return await appDbContext.UOMs.FromSqlRaw<UOMs>("sp_GetUOMs").ToListAsync();

        }
    }
}
