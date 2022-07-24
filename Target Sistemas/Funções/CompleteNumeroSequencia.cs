using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Sistemas.Interfaces;

namespace Target_Sistemas;

internal class CompleteNumeroSequencia
{

    List<string> Sequencia = new List<string>()
    {
      "Resolução:",
      "A)1,3,5,7,9",
      "B)2,4,8,16,32,64,128",
      "C)0,1,4,9,16,25,36,49",
      "D)4,16,36,64,100",
      "E)1,1,2,3,5,8,13",
      "F)2,10,12,16,17,18,19,200"
    };

    public void LetraA()
    {
        int valueA;
        int valueB = 1;
        int valueC = 2;
        for (int i = 1; i < 6; i++)
        {
            Console.Write(" " + valueB);
            valueA = valueB + valueC;
            valueB = valueA;
        }

        //ValorA.ForEach(i => Console.Write("A)", i));

    }
    public void LetraB()
    {
        int valueA;
        int valueB = 2;
        int valueC = 2;
        for (int i = 1; i < 8; i++)
        {
            Console.Write(" " + valueB);
            valueA = valueB * valueC;
            valueB = valueA;
        }
    }
    public void LetraC()
    {

        int valueA;
        int valueB = 0;
        int valueC = 1;
        for (int i = 1; i < 10; i++)
        {
            Console.Write(" " + valueB);
            valueA = valueB + valueC;
            valueC = valueC + 2;
            valueB = valueA;
        }
    }
    public void LetraD()
    {
        int valueA;
        int valueB = 4;
        int valueC = 12;
        for (int i = 1; i < 6; i++)
        {
            Console.Write(" " + valueB);
            valueA = valueB + valueC;
            valueC = valueC + 8;
            valueB = valueA;
        }
    }
    public void LetraE()
    {
        int proximo = 0;
        int anterior = 0;
        int atual = 1;
        for (int i = 1; i < 8; i++)
        {
            Console.Write(" " + atual);
            proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }
    }
    public void LetraF()
    {
        int[] numero = new int[] { 2, 10, 12, 16, 17, 18, 19, 200 };
        Console.Write(" " + numero);
    }
    public void Resolução()
    {
        Sequencia.ForEach(i => Console.WriteLine(i));    
    }

}
