using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace hostal.Models
{
    //CARRITO
    [Table("t_proforma")]
    public class Proforma
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public String UserID {get; set;}
        public Product Producto {get; set;}
        public int Quantity{get; set;}
        public Decimal Precio { get; set; }
        public String Status { get; set; } = "PENDIENTE";
    }
}