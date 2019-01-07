﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst.Models
{
    public class Aluno
    {
        public Aluno()
        {
        }

        public int AlunoID { get; set; }

        public string Nome { get; set; }

        public int CursoID { get; set; }

        [ForeignKey("CursoID")]
        public virtual Curso Curso { get; set; }
    }
}
