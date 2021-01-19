using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public class SQLConfigurationRepository : IConfigurationRepository
    {
        private readonly AppDbContext appDbContext;
        public SQLConfigurationRepository(AppDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }

        public IEnumerable<ProductTypes> GetProductTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UOM> GetUOMs()
        {
            throw new NotImplementedException();
        }
    }
}
