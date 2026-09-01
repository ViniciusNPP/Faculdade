using fifo;

public class Program
{
    public static void Main(String[] args)
    {
        Fila fila = new(["Maria", "Joao"]);
        fila.RemoveItem();
        fila.AddItem("Marcelo");
        fila.AddItem("Vinicius");
        fila.AddItem("Roberto");
        fila.AddItem("Herison");
        fila.AddItem("Matheus");
        fila.RemoveItem();
        fila.RemoveItem();
        fila.RemoveItem();

        fila.ShowItems();
    }
}