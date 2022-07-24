using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas.Funções
{
    internal class InverterString
    {

        public void ReverseFor(string texto)
        {
            
            StringBuilder sb = new StringBuilder();           //Instancia um objeto da classe StringBuilder.
            Console.WriteLine($"Texto Normal : {texto}");                                                 
            for (var i = texto.Length - 1; i >= 0; i--) //Itere último ao primeiro índice da string s em i... 
            {
                sb.Append(texto[i]);                              //...acrescente o caractere s[i] ao final do objeto StringBuilder.
            }
            Console.WriteLine("Texto Convertido: " + sb.ToString());
            
        }

        public void Inverter(string texto)
        {
            Console.WriteLine($"Texto Normal : {texto}");
            string textoInvertido = new string(texto.Reverse().ToArray());
            Console.WriteLine($"Texto Convertido : {textoInvertido}");
        }

    }
}
