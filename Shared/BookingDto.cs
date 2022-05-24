using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDrivee.Shared
{
    public class BookingDto
    {
        [Required]
        public int CarId { get; set; }
        [Required]
        public DateTime Start { get; set; } = DateTime.Now;
        [Required]
        public DateTime End { get; set; } = DateTime.Now;
        public string Username  { get; set; }   
    }
}
