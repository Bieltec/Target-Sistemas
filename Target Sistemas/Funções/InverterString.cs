using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas.Funções
{
    internal class InverterString
    {
        public void Inverter(string texto)
        {
            Console.WriteLine($"Texto Normal : {texto}");
            string textoInvertido = new string(texto.Reverse().ToArray());
            Console.WriteLine($"Texto Convertido : {textoInvertido}");
        }

    }
}
