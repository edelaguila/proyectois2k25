using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal_Web.Models
{
    public class Nominas
    {
        public decimal SalarioBase { get; set; }
        public decimal Percepciones { get; set; } 
        public decimal Deducciones { get; set; }

        public decimal Total => SalarioBase + Percepciones - Deducciones;
    }
}