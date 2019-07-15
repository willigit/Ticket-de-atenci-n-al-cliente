using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ticket_De_Atencion.Models.ViewModels
{
    public class TablaViewModels
    {
        public int cli_id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Codigo de cliente CI")]
        public string cli_codigo { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de Cliente")]
        public string cli_nombre { get; set; }

    }
}