using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Zone
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string ZoneCode { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Addresse { get; set; }
        [MaxLength(25)]
        public string Telephone { get; set; } 

        [ForeignKey("VilleId")]
        public Ville Ville { get; set; }
    }
}
