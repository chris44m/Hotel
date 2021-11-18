using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace hostal.Models
{
    [Table("t_servicios")]
    public class Servicios
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Nombre")]
        public string Nombre {get; set;}

        [Column("Descripcion")]
        public string Descripcion {get; set;}

        [Column("Precio")]
        public Decimal Precio {get; set;}

        [Column("Imagen")]
        public String Imagen { get; set; }
        
        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Estado")]
        public String Estado{ get; set; }
        
    }
}