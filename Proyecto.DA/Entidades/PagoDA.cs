using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DA.Entidades
{
    [Table("pago")]
    public class PagoDA
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
       
        public string pan { get; set; }

        [Required]
        [MaxLength(10)]
        public string fechaVencimiento { get; set; }

        [Required]
       
        public string cvv { get; set; }

        public int commercio { get; set; }
        public int terminal { get; set; }

        [Required]
       
        public decimal Total { get; set; }
    }
}
