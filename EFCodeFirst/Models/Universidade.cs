﻿using System;
using System.Collections.Generic;

namespace EFCodeFirst.Models
{
    public class Universidade
    {
        public Universidade()
        {
        }

        public int UniversidadeID { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
