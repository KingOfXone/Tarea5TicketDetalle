using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea5TicketDetalle.Shared
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es necesario para completar el campo SolicitadoPor")]
        public string? SolicitadoPor { get; set; } // Persona que va a solicitar

        [Required(ErrorMessage = "Es necesario para completar el campo Asunto")]
        public string? Asunto { get; set; } // Asunto

        [Required(ErrorMessage = "Es necesario para completar el campo Descripcion")]
        public string? Descripcion { get; set; } // Descripción

        [ForeignKey("TicketId")] //llave foranea
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
