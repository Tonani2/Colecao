Console.WriteLine("Quantos produtos deseja cadastrar?");
var quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
int[] itens = new int[quantidadeProdutos];

for (var contador = 0; contador < quantidadeProdutos; contador++)
{
    Console.Write($"Digite a quantidade em estoque do Produto {contador + 1}:");
    itens[contador] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.WriteLine("--- Alerta: Produtos com Estoque Crítico ---");

for (var contador = 0; contador < quantidadeProdutos; contador++)
{
    if (itens[contador] < 5)
    {
        Console.WriteLine($"Produto {contador + 1} está com estoque baixo: apenas {itens[contador]} unidades");
    }
    
}
