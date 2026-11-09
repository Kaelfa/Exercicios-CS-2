using exercicios;

// EXERCICIO 1

Pessoa p1 = new Pessoa();

p1.Nome = "Samuel";
p1.Idade = 67;
p1.Cidade = "Sao Bernado";
p1.exibir();

// EXERCICIO 2

Calculadora Calc = new Calculadora();

Console.WriteLine(Calc.Somar(1,1));
Console.WriteLine(Calc.Subtrair(2,1));
Console.WriteLine(Calc.Multiplicar(3,2.1m));
Console.WriteLine(Calculadora.Divisao(1,0));

// EXERCICIO 3

Veiculo gol = new Veiculo(50f);
Veiculo celta = new Veiculo(155f);
Veiculo santana = new Veiculo(201f);
Veiculo uno = new Veiculo(-15f);

Console.WriteLine(gol.Velocidade);
Console.WriteLine(celta.Velocidade);
Console.WriteLine(santana.Velocidade);
Console.WriteLine(uno.Velocidade);

// EXERCICIO 4

Funcionario pedro = new Funcionario("Pedro","Maquinista", 5000m);
Funcionario marcelo = new Funcionario("Marcelo", "Aj. Maquinario", 2500m);

Console.WriteLine(pedro.ConsultarSalario());
Console.WriteLine(marcelo.ConsultarSalario());

pedro.AumentarSalario(1.4m);
Console.WriteLine(pedro.ConsultarSalario());

// EXERCICIO 5

Livro livro1 = new Livro();

Livro livro2 = new Livro("Triste Fim de Policarpo Quaresma");

Livro livro3 = new Livro("O Guarani", "José de Alencar");

Livro livro4 = new Livro("Memórias Póstumas de Brás Cubas", "Machado de Assis", 368);

livro1.exibir();
Console.WriteLine("----------");
livro2.exibir();
Console.WriteLine("----------");
livro3.exibir();
Console.WriteLine("----------");
livro4.exibir();

