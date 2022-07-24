using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas.Funções
{
    internal class Veiculos
    {
        //int carro = 110 km / direcao frança
        //int caminhao = - 80km / direcao ribeirao preto
        //Qual estara mais proximo da cidade de ribeirao preto
        //Considerar a distancia de 100km de uma cidade para outra
        //Comnsiderar 2 pedagios como obstaculo e o caminhao levou 5 minutos a mais para passar em cada um deles

        double SCarro;// caminho todo percorrido
        double SoCarro;// De onde ele partiu
        double TCarro;// tempo gasto
        double velocidadeMediaCarro = 110;
        double MovimentoRetilinio;
        // s = so + v.t equacao

        // velocidade do carro é constante por isso sua velocidade média é 110km
        // por isso devemos calcular somente a do caminhao

        //------
        //Caminhao teria duas formulas do movimento Retilinio uniforme e de Velocidade Media
        // 1,25h+0,17h=1,42h deltaT
        double DeltaS = 100;
        double DeltaT = 1.42;
        //VelocidadeMediaCaminhao = DeltaS / Delta;
        double VelocidadeMediaCaminhao = 70.6;
        double STrajedoInicial = 100; // caminho total a percorrer
        double TCarroCaminho;

        public void EquacaoHorariaMovimentoRetilinio()
        {
            TCarroCaminho = (velocidadeMediaCarro * STrajedoInicial) / (velocidadeMediaCarro + VelocidadeMediaCaminhao);
            Console.WriteLine(TCarroCaminho.ToString("N1"));
        }

        public void Resolucao()
        {
            Console.WriteLine("Se localização na mesma distância de Ribeirão Preto, eles se encontra no km 60,9KM.");
            Console.WriteLine("Observação: Pode estar verificando a lógica e explicacao pela classe Veiculos.");
        }



    }
}
