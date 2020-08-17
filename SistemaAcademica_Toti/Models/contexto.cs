using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SistemaAcademica_Toti.Models
{
    public class contexto: DbContext
    {
        public DbSet<aluno> alunos { get; set; }
    }
}