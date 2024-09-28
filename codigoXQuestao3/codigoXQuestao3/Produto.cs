using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoXQuestao3
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public TipoEnum Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
