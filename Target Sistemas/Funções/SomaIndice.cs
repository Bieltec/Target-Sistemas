using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas.Funções;

public class SomaIndice
{
    public int Indice { get; private set; } = 13;
    public int Soma { get; private set; } = 0;
    public int K { get; private set; } = 0;

    public string somaIndice()
    {
        while (K < Indice)
        {
            K = K + 1;
            Soma = Soma + K;
        }
        return $"Resultado da Soma é {Soma}";
    }
}

