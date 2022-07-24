using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Target_Sistemas.Interfaces;

namespace Target_Sistemas.Funções;

internal class SequenciaFibonacci : ILeitura
{

    public int Proximo { get; set; } = 0;
    public int Anterior { get; private set; } = 0;
    public int Atual { get; private set; } = 1;
    public List<int> Fibonacci { get; private set; } = new List<int>();

    public void LogicaSequenciaFibonacci()
    {
        Fibonacci.Add(0);
        for (int i = 0; i < 20; i++)
        {
            Proximo = Atual + Anterior;
            Anterior = Atual;
            Atual = Proximo;
            Fibonacci.Add(Proximo);
        }
    }
    public void ValidacaoNumeroExistenteFibonacci(int valor)
    {
        if (Fibonacci.Contains(valor))
        {
            Console.WriteLine("Seu número está presente na Sequencia LetraE =)");
           
        }
        else
        {
            Console.WriteLine("Infelizmente o número digitado não está presente na Sequencia Fibonacci =(");
       
        }
      
    }
    public void ValidacaoVisualizarLeituraList()
    {
        int outWhile = 0;
        do
        {
            Console.WriteLine("Gostaria de visualizar a Sequencia LetraE, SIM(1) NÃO(2):");
            outWhile = int.Parse(Console.ReadLine());

            if (outWhile == 1)
            {
                LeituraList();
            }
            if (outWhile == 2)
            {
                Console.WriteLine("Obrigado =)");
            }

        } while (outWhile == 0);


    }
    public void LeituraList()
    {
        foreach (var r in Fibonacci)
        {
            Console.WriteLine(r);
        }
    }
    
}
