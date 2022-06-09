using System;
using System.ComponentModel.DataAnnotations;

namespace crud_mvc_xml.Models
{
    public class Inventario
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string ProveedorArticulo { get; set; }
        [Required]
        public Int16 CantidadDisponible { get; set; }
        [Required]
        public decimal PrecioCosto { get; set; }
        [Required]
        public decimal PrecioVenta { get; set; }
        [Required]
        public decimal PuntoReorden { get; set; }
        public bool IsEdit { get; set; }
    }
}
