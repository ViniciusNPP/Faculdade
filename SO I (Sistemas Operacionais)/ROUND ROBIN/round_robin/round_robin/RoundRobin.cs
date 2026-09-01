using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using fifo;

namespace round_robin
{
    public class RoundRobin(String[] items)
    {
        private readonly int quamtum = 10; //Tempo de processamento para cada item
        private readonly Fila fila = new(items); //Items em formato de fila (FIFO)

        //Diminui o texto baseado no quamtum
        //Essa é a forma simular a contagem de tempo que cada item leva para ser processado
        //Se o quamtum for 10, 10 caracteres serão retirados do texto e simbolizará 1 ciclo (1 ciclo = 10 quamtum)
        //Se um elemento demorar 10 ciclos será 100 quamtum de tempo (ou nesse caso 0,1 segundos)
        private String ModificarProcesso(String processo)
        {
            if (processo.Length <= quamtum) return "";

            //No C# os '..' é um operador de intervalo
            //Temos a string "Banana" armazenado na variável 'palavra', por exemplo
            //palavra[..] (Pega toda a string, ficando 'Banana')
            //palavra[1..] (Exclui o caracter anterior ao index inserido, ficando 'anana')
            //palavra[..5] (Pega até o penúltimo caracter, ficando 'Banan', pois não inclui o index colocado)
            //palavra[1..5] (Pega o intervalo entre o index 1 e o 5 [não inclui o 5], ficando 'anan')
            return processo[quamtum..];
        }
        
        public void IniciarProcessos()
        {
            //Contagem de ciclos que cada processo levou
            double ciclos = 0;
            List<double> lista_ciclos = [];
            
            while (fila.GetFila.Length > 0)
            {
                string processo = fila.GetFirst;
                Console.WriteLine($"Processando {processo}\n...");

                processo = ModificarProcesso(processo); //Faz a modificação no processo

                Thread.Sleep(quamtum); //Simulação do delay do processador baseado no quamtum
                fila.RemoveItem(); //Remove o item processado da fila

                //Cálculo de tempo que o processo levou para finalizar o ciclo
                double custo;
                if (processo.Length <= quamtum)
                {
                    custo = (double)processo.Length / quamtum;
                }
                else custo = 1;

                ciclos += custo;

                if (processo != "")
                {
                    fila.AddItem(processo); //Se o processo não finalizou volta para o final da fila
                }
                else if (processo == "")
                {
                    //Adiciona o tempo que levou para o processo finalizar na lista_ciclos para mostrar no final
                    lista_ciclos.Add(ciclos);
                    Console.WriteLine($"finalizado no ciclo: {ciclos}\n");
                }
            }

            //Mostra o tempo que cada processo levou para finalizar
            Console.WriteLine("========RESULTADOS========\n");
            for (int i = 0; i < lista_ciclos.Count; i++)
            {
                Console.WriteLine($"{i+1}º - {lista_ciclos[i]:F1}"); //:F1 é a quantidade de casas decimais que será mostrado.
            }
        }

    }
}
