using Roteiro.Roteiro2;

Carro c = new Carro("Ferrari");
c.Acelerar(50);
Console.WriteLine(c.VelocidadeAtual); // Deve exibir 50
c.Frear(30);
Console.WriteLine(c.VelocidadeAtual); // Deve exibir 20
c.Frear(50); // Não pode ficar negativo, deve exibir 0