using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public class ProductTypes
    {
        [Key]
        public string ProdTypeID { get; set; }
        public string ProdTypeName { get; set; }
        public string ProdTypeDesc { get; set; }
        public int ProdTypeIndex { get; set; }
    }
}
