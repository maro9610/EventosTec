using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventoTec.web.Models.entities
{
    public class User : IdentityUser
    {
        [Display (Name="Nombre Completo")]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Display(Name = "Decripcion")]
        [MaxLength(300)]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public string ImgUrl { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }
      
            
    }
}
