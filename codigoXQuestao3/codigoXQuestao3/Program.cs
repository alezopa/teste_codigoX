using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace codigoXQuestao3
{

    public class Program
    {
        public static void Main(string[] args)
        {

            

            var teste = CriarLista();

            Console.WriteLine("-----------Produtos segudo trimeste----------");
            var trimestre = teste.Where(x => (x.DataCriacao.Month >= 4 && x.DataCriacao.Month <= 6) && x.DataCriacao.Year == 2024);
            foreach (var item2 in trimestre)
                Console.WriteLine(item2.ValorCompra + " -- " + item2.ValorVenda + " -- " + item2.DataCriacao + " -- " + item2.Tipo);
            Console.WriteLine("-----------Produtos segudo trimeste----------");
            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("----------Ordenar por Tipo-----------");
            var ordenacao = teste.OrderBy(c => c.Tipo);
            foreach (var item3 in ordenacao)
                Console.WriteLine(item3.ValorCompra + " -- " + item3.ValorVenda + " -- " + item3.DataCriacao + " -- " + item3.Tipo);
            Console.WriteLine("----------Ordenar por Tipo-----------");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("----------Margem de Lucro-----------");
            var lst = teste.GroupBy(v => v.Tipo)
                                    .Select(g => new
                                    {
                                        Tipo = g.Key,
                                        Total = g.Sum(venda =>
                                                    venda.ValorVenda - venda.ValorCompra)
                                    }).OrderByDescending(s => s.Total).Take(3);



           
            foreach (var item4 in lst)
                Console.WriteLine(item4.Tipo + " -----   " + item4.Total);
            Console.WriteLine("----------Margem de Lucro-----------");



        }


        public static List<Produto> CriarLista()
        {

            DateTime dec31 = new DateTime(2024, 01, 01);

            var lista = new List<Produto>();

            for (int i = 0; i < 5; i++)
            {
                var item = new Produto();

                item.Descricao = "item" + i.ToString();
                item.ValorVenda = 100 * i;
                item.ValorCompra = 10 * i;
                item.DataCriacao = dec31.AddMonths(i);
                item.Tipo = TipoEnum.MateriaPrima;

                lista.Add(item);

            }

            for (int i = 0; i < 5; i++)
            {
                var item = new Produto();

                item.Descricao = "item" + i.ToString();
                item.ValorVenda = 200 * i;
                item.ValorCompra = 20 * i;
                item.DataCriacao = dec31.AddMonths(i + 2);
                item.Tipo = TipoEnum.Consumo;

                lista.Add(item);

            }

            for (int i = 0; i < 5; i++)
            {
                var item = new Produto();

                item.Descricao = "item" + i.ToString();
                item.ValorVenda = 300 * i;
                item.ValorCompra = 30 * i;
                item.DataCriacao = dec31.AddMonths(i + 3);
                item.Tipo = TipoEnum.Intermediario;

                lista.Add(item);

            }

            for (int i = 0; i < 5; i++)
            {
                var item = new Produto();

                item.Descricao = "item" + i.ToString();
                item.ValorVenda = 400 * i;
                item.ValorCompra = 40 * i;
                item.DataCriacao = dec31.AddMonths(i + 4);
                item.Tipo = TipoEnum.Final;

                lista.Add(item);

            }

            return lista;

        }



    }

}



    

