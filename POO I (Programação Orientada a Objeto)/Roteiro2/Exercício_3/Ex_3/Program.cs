using Roteiro.Roteiro2;

Elevador e = new Elevador(10); // 10 andares
e.Subir();
e.Subir();
Console.WriteLine(e.AndarAtual); // Deve exibir 2
e.Descer();
Console.WriteLine(e.AndarAtual); // Deve exibir 1
e.Descer();
e.Descer(); // Deve continuar em 0