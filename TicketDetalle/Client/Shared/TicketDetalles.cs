using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TicketDetalles
{
    [Key]

    public int TicketDetalleId { get; set; }

    [Required(ErrorMessage = "Debe llenar este campo")]

    public string? emisor { get; set; }
    [Required(ErrorMessage = "Debe llenar este campo")]

    public string? mensaje { get; set; }
}

