using System;
using System.ComponentModel.DataAnnotations;

namespace Port.Model
{
    public class Medicine
    {
        public long Id { get; set; }
        [Required]
        public bool Done { get; set; }
        [Required]
        public string Name { get; set; }
        public int Glucose { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public string Pressure { get; set; }
        [Required]
        public string Description { get; set; }
        
    }
}
