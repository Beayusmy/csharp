string[] carros = new string[3];

for (int i = 0; i < 3; i++)

{
    Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
    carros [i] = Console.ReadLine()!;
}

Console.WriteLine ($"0 carro cadastrado e {carros [0]}, {carros [1]}, {carros [2]} ");           