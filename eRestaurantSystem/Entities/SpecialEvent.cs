using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace eRestaurantSystem.Entities
{
    public class SpecialEvent
    {
        [Key]
        public char EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
