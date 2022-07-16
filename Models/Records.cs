using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class Records
    {
        public int Id { get; set; }
        public string Date { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone")]
        [Phone]
        public string Phone { get; set; }
        public string NameBS { get; set; }
    }
}
