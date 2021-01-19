using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public class Products
    {
        [Key]
        public string ProdID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Product No.")]
        public string ProdNum { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Product Name")]
        public string ProdName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Product Descriptions")]
        public string ProdDesc { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify HSN Code")]
        public string ProdHSNCode { get; set; }
        public int ProdIsActive { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Units Of Measurement")]
        public string UOMID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please specify Product Type")]
        public string ProdTypeID { get; set; }
        public string Comments { get; set; }
        public string ProdCreatedByUserID { get; set; }
        public string ProdCreatedDate { get; set; }
        public string ProdUpdatedByUserID { get; set; }
        public string ProdUpdatedDate { get; set; }
    }
}
