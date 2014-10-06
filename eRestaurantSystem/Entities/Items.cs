using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurantSystem.Entities
{
    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(35, ErrorMessage = "Description has a max size of 35 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Current Price is required.")]
        public decimal CurrentPrice { get; set; }
        [Required(ErrorMessage = "Current Cost is required.")]
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }
        public int Calories { get; set; }
        [StringLength(50, ErrorMessage = "Comment has a max size of 50 characters")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "MenuCategoryID is required.")]
        public int MenuCategoryID { get; set; }
    }
}
