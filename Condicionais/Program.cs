float precoProduto = 200;
float minhaCarteira = 350;

//criar um programa que responda se eu consigo comprar o produto? SIM OU NAO

if (minhaCarteira >= precoProduto)
{
    console.WriteLine ($"Sim, voce pode comprar o produto");
}
else
{
    Console.WriteLine(@"Infelizmente voce NAO pode comprar");
}