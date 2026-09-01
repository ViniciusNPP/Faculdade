using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifo
{
    public class Pilha(String[] items)
    {
        private String[] pilha = [..items.Reverse()];

        //Remove o última item que entrou
        public String[] RemoveItem()
        {
            String[] nova_pilha = new String[pilha.Length - 1]; //Cria uma pilha com uma posição a menos

            for (int i = 0; i < pilha.Length - 1; i++) //Vai percorrer toda a pilha até a penúltima posição
            {
                nova_pilha[i] = pilha[i + 1]; //Move todos os items para frente, removendo o último item que entrou
            }
            
            return pilha = nova_pilha; //Atribui o valor de nova_pilha para pilha e a retorna
        }

        //Adiciona um item à pilha
        public String[] AddItem(String item)
        {
            String[] nova_pilha = new String[pilha.Length + 1]; //Cria uma pilha com uma posição a mais
            for (int i = 0; i < nova_pilha.Length; i++) //Vai percorrer toda a pilha
            {
                if (i == 0) //Adiciona o item na primeira posição do array para que ele seja removido primeiro
                {
                    nova_pilha[i] = item;
                    continue;
                }

                nova_pilha[i] = pilha[i - 1];
            }

            return pilha = nova_pilha; //Atribui o valor de nova_pilha para pilha e a retorna
        }

        //Mostra todos os itens de pilha
        public void ShowItems()
        {
            Console.WriteLine("========PILHA========\n");

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
