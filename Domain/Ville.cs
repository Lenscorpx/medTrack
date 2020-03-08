using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Ville
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }

    }
}
