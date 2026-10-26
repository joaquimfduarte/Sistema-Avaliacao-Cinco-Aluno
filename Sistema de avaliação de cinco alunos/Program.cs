using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;

double[]notas = new double[5]; // array de notas a guardar
double soma = 0; // o sumatório das notas

int aprovados = 0; // # aprovados
int reprovados = 0; // # reprovados
double media = 0.0; //média

// variáveis auxiliares
string auxAluno = "";
string auxAprovacao = "";
double auxNota = 0.0; 
string auxInput = "";

// input de dados
for (int i = 0; i < 5; i++)
{
    Console.Write($"Introduza a nota do aluno {i+1}: ");
    auxInput = Console.ReadLine() ?? "";
    // aceita vírgula ou ponto como separador decimal; rejeita texto e valores fora de 0–20
    while (!double.TryParse(auxInput.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out auxNota)
           || auxNota < 0 || auxNota > 20)
    {
        Console.Write("Valor inválido! A nota deve ser um número entre 0 e 20.\nIntroduza a nota do aluno: ");
        auxInput = Console.ReadLine() ?? "";
    }
    notas[i] = auxNota;
    soma = soma + notas[i];
}

Console.WriteLine();

//verificação de aprovados/reprovados
for (int i = 0; i < 5; i++)
{
    auxAluno = $"{i+1} aluno ";
    auxNota = notas[i];
    if (auxNota >= 10)        
    {
        aprovados++;
        auxAprovacao = " - Aprovado";
    }
    else
    {
        reprovados++;
        auxAprovacao = " - Reprovado";
    }
    Console.WriteLine(auxAluno + ": " + auxNota + auxAprovacao );
}

Console.WriteLine("-----------------------------");

Console.WriteLine("Numero de Reprovados: " + reprovados);
Console.WriteLine("Numero de Aprovados: " + aprovados);

// calculo da média
media = soma / notas.Length;

Console.WriteLine("-----------------------------");
Console.WriteLine("\nMédia dos Alunos: " + media);