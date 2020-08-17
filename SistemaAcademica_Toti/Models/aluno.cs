using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaAcademica_Toti.Models
{
    public class aluno
    {
        [Key]
        public int Codigo { get; set; }
       
        public string NomeCompleto { get; set; }
 
        public string Nascionalidade { get; set; }
       
        public string Curso { get; set; }
      
        public DateTime data { get; set; }
      
    }
}