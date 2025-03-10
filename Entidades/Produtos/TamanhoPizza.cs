﻿using Entidades.Enumeradores;
using System;

namespace Entidades.Produtos
{
    public class TamanhoPizza : Entidade
    {
        public string Observacao { get; set; }
        public decimal Valor { get; set; }
        public int QtdSabores { get; set; }
        public Status Status { get; set; }
        public DateTime DtAlteracao { get; set; }
        public int CodigoUsrAlteracao { get; set; }
    }
}
