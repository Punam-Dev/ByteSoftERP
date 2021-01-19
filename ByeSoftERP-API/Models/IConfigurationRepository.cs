using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public interface IConfigurationRepository
    {
        public IEnumerable<ProductTypes> GetProductTypes();
        public IEnumerable<UOM> GetUOMs();
    }
}
