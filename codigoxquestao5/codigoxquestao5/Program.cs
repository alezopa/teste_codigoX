using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace codigoxQuestao5
{

    class Program
    {
        private static async Task Main(string[] args)
        {

            List<Task<string>> lista = new List<Task<string>>();

            lista.Add(ConcatenaAsync());
            lista.Add(ConcatenaAsync2());
            lista.Add(ConcatenaAsync3());


            foreach (var task in lista)
            {
                Random random = new Random();
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Thread.Sleep(random.Next(1000, 5000));
              
                Console.WriteLine($"Tempo decorrido após a tarefa   {task.Result}    terminar : {stopwatch.Elapsed}");
            

            }
            await Task.WhenAll(lista);
            Console.Read();

        }


        private static async Task<string> ConcatenaAsync()
        {
             await Task.Delay(1);
           
            return  "Tarefa 01";
        }

        private static async Task<string> ConcatenaAsync2()
        {
            await Task.Delay(1);

            return "Tarefa 02";
        }

        private static async Task<string> ConcatenaAsync3()
        {
           await Task.Delay(1);
           
            return "Tarefa 03";
        }



    }

}