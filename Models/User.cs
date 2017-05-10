using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finanzas.Models
{
    public class User
    {
        public int ID { get; set; }
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string Hash { get; set; }
        [Display(Name = "Efectivo")]
        public float Cash { get; set; }
    }
}
