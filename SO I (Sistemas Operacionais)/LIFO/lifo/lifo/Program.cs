using lifo;

public class Program
{
    public static void Main(string[] args)
    {
        Pilha pilha = new(["Maria", "Joao"]);
        pilha.RemoveItem();
        pilha.AddItem("Marcelo");
        pilha.AddItem("Vinicius");
        pilha.AddItem("Herison");
        pilha.AddItem("Matheus");
        pilha.RemoveItem();

        pilha.ShowItems();
    }
}