using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventoTec.web.Models.entities
{
    public class City
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Ciudad")]

        public string Name { get; set; }
        [Required]
        [Display(Name = "Descripcion")]

        public String Descripcion { get; set; }
        [Display (Name ="Pais")]

        public string Slung { get; set; }
    }
}
