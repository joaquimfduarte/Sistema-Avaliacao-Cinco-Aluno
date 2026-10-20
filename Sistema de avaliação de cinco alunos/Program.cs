using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

double[]notas = new double[5];
double soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write("Introduza a nota do aluno: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
    while (notas[i] < 0 || notas[i] > 20)
    {
        Console.Write("Valor inválido! A nota deve estar entre 0 e 20.\n Introduza a nota do aluno: ");
        notas[i] = Convert.ToDouble(Console.ReadLine());
    }
    soma = soma + notas[i];
}

double media = soma / notas.Length;
int aprovados = 0;
int reprovados = 0;

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    if (notas[i] >= 10)        
    {
        aprovados++;
        Console.WriteLine(notas[i] + " - Aprovado\n");
    }
    else
    {
        reprovados++;
        Console.WriteLine(notas[i] + " - Reprovado\n");
    }
}

Console.WriteLine("Numero de Reprovados: " + reprovados);
Console.WriteLine("Numero de Aprovados: " + aprovados);
Console.WriteLine("\nMédia dos Alunos: " + media);