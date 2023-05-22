using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace CalculadoraCientifica.Models
{
    public class Calculadora
    {
        [Key]
        public int CalcId { get; set; }
        public double Operador { get; set; }
        public double Resultado { get; set; }
        public string? Operacion { get; set; }

    }
}
