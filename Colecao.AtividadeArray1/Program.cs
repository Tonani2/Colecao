var notas = new double[4]; // double informa que é um novo array de double.

for (int alunos = 0; alunos <= 3 ; alunos++)
{
    Console.WriteLine($"Digite a sua nota {alunos + 1}"); 
    notas[alunos] = Convert.ToDouble(Console.ReadLine());
}

var notasTotais = notas.Sum();
var media = notasTotais / 4;

Console.WriteLine($"A média final do aluno é: {media}");