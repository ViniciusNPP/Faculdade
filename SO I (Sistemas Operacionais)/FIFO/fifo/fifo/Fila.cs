using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifo
{
    public class Fila(String[] items)
    {
        private String[] fila = items;
        public String[] GetFila { get { return fila; } }
        public String GetFirst {  get { return fila[0]; } } //Pega o primeiro item da fila

        //Adiciona um item para a lista na primeira posição
        public String[] AddItem(String item)
        {
            String[] nova_fila = new String[fila.Length + 1]; //Cria uma lista com uma posição a mais

            for (int i = 0; i < nova_fila.Length; i++)
            {
                if (i == nova_fila.Length -1) //Coloca o item como primeiro da lista
                {
                    nova_fila[i] = item;
                    continue;
                }
                nova_fila[i] = fila[i]; //Monta a lista novamente
            }
            fila = nova_fila;

            return fila; //Atribui o valor de nova_fila para fila e a retorna
        }

        //Remove o primeiro item da lista
        public String[] RemoveItem()
        {
            String[] nova_fila = new String[fila.Length - 1]; //Cria uma lista com uma posição a menos

            for (int i = 0; i < fila.Length; i++)
            {
                if (i == 0) continue; //Ignora o primeiro item para excluí-lo da lista

                nova_fila[i - 1] = fila[i]; //Monta a lista novamente
            }

            fila = nova_fila;
            return fila; //Atribui o valor de nova_fila para fila e a retorna
        }

        //Mostra todos os itens de fila
        public void ShowItems()
        {
            Console.WriteLine("========FILA========\n");

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}
