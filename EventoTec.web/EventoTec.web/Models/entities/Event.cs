using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventoTec.web.Models.entities
{
    public class Event
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Fecha del Evento")]
        public DateTime? EventDate { get; set; }
        [Display(Name = "Descripcion")]

        public string Descripcion { get; set; }
        [Display(Name = "Foto")]

        public byte[] Picture { get; set; }
        [Display(Name = "Asistentes")]

        public int People { get; set; }
        [Display(Name = "Duracion")]

        public int Duretion { get; set; }
        [Required]
        public int CityId { get; set; }
        [ForeignKey("CityId")]

        public City City { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]

        public Client Client { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }



    }
}
