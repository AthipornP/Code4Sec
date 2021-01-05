using System;
using System.ComponentModel.DataAnnotations;

namespace TryValidateModelSample.Models
{
    public class PersonalModel
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [StringLength(20)]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required.")]
        [StringLength(20)]
        public string Lastname { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
    }
}
