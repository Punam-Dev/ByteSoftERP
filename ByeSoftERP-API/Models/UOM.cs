using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public class UOM
    {
        [Key]
        public string UOMID { get; set; }
        public string UOMName { get; set; }
        public string UOMDesc { get; set; }
        public string UOMIndex { get; set; }
    }
}
