﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._03_Entidades
{
    public class Nota
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public double Valor { get; set; }
    }
}
