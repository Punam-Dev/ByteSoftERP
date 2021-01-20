using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public interface IConfigurationRepository
    {
        public Task<IEnumerable<ProductTypes>> GetProductTypes();
        public Task<IEnumerable<UOM>> GetUOMs();
    }
}
