using Stadium.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stadium.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha de uso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime DateUse { get; set; }

        public bool Used { get; set; }

        [Display(Name = "Porteria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public ReceptionType ReceptionType { get; set; }
    }
}
