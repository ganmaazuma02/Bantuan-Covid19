using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorangBantuanCovid19.Models.EntityModels
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        public string NationalId { get; set; }
        public string Name { get; set; }
    }
}
