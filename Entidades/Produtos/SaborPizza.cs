using Entidades.Enumeradores;
using System;

namespace Entidades.Produtos
{
    public class SaborPizza : Entidade
    {
        public string Observacao { get; set; }
        public decimal ValorAdicional { get; set; }
        public Status Status { get; set; }
        public DateTime DtAlteracao { get; set; }
        public int CodigoUsrAlteracao { get; set; }
    }
}
