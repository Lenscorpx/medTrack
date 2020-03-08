using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Province
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
