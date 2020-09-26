using System;
using System.ComponentModel.DataAnnotations;

namespace Registro_prestamo.Entidades{
  public class Prestamo{

       public int PrestamoId { get; set; }
      public DateTime Fecha { get; set; }
       
       public int PersonaId { get; set; }

       public string Concepto { get; set; }
       public decimal Monto { get; set; }
       public decimal Balance { get; set; }

  }

}