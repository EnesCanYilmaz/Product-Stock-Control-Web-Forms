using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtaDuzeyProgramlamaOdevi.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }
}
