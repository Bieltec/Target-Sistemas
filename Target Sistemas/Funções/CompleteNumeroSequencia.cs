using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Sistemas.Interfaces;

namespace Target_Sistemas;

internal class CompleteNumeroSequencia
{
    public List<int> ValorA { get; private set; } = new List<int>();
    public List<int> ValorB { get; private set; } = new List<int>();
    public List<int> ValorC { get; private set; } = new List<int>();
    public List<int> ValorD { get; private set; } = new List<int>();
    public List<int> ValorE { get; private set; } = new List<int>();
    public List<int> ValorF { get; private set; } = new List<int>();

    List<string> Sequencia = new List<string>()
    {
      "A)1,3,5,7,___",
      "B)2,4,8,16,32,64,___",
      "C)0,1,4,9,16,25,36,___",
      "D)4,16,36,64,___",
      "E)1,1,2,3,5,8,___",
      "F)2,10,12,16,17,18,19,___"
    };

    public void LetraA()
    {
        int valueA;
        int valueB = 1;
        int valueC = 2;
        for (int i = 1; i < 6; i++)
        {
            ValorA.Add(valueB);
            valueA = valueB + valueC;
            valueB = valueA;
        }
    }
    public void LetraB()
    {
        int valueA;
        int valueB = 2;
        int valueC = 2;
        for (int i = 1; i < 8; i++)
        {
            ValorB.Add(valueB);
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
            ValorC.Add(valueB);
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
            ValorD.Add(valueB);
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
            ValorF.Add(atual);
            proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }
    }
    public void LetraF()
    {
        int[] numero = new int[] { 2, 10, 12, 16, 17, 18, 19, 200 };
        ValorF.AddRange(numero);
    }
    public void LeituraListaSequencia()
    {
        foreach (var item in Sequencia)
        {
            Console.WriteLine(item);
        }
    }
    public void LeituraLetras()
    {
       // lista.ForEach(i => Console.Write("{0}\t", i));
    }





}
