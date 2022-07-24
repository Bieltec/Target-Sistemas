
using Target_Sistemas.Funções;
using Target_Sistemas.Interfaces;

namespace Target_Sistemas;

public class Target : ILeitura, IContadorList
{
    //private List<int> ValorRecebidoOperacao = new List<int>();
    public int Posicao { get; set; }  
    public int Valor { get; set; }
    public string? ValorString { get; set; }

    List<string> atividades = new List<string>()
{
    "1 - Soma Indice",
    "2 - Sequência Fibonacci",
    "3 - Complemente sequência de número.",
    "4 - Veículos",
    "5 - Inverter Texto"
};

    public void LeituraList()
    {
        foreach (var r in atividades)
        {
            Console.WriteLine(r);
        }
    }
    public int  ContadorList()
    {
        int contador= 0 ;
        foreach (var r in atividades)
        {
            contador++;
        }
        return contador;
    }
    public void EscolhaAtividade()
    {
        try
        {
            Console.WriteLine("Digite o número da função que deseja:");
            Posicao = Int32.Parse(Console.ReadLine());

            while (Posicao > ContadorList())
            {
                Console.WriteLine("Função inexistente por favor digite novamente:");
                Posicao = Int32.Parse(Console.ReadLine());
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("O valor da função inserida é null ou inválido.");
            throw;
        }
    }
    public void ValoresRecebidosAtividades()
    {
        try
        {
            if (Posicao == 2)
            {
                Console.WriteLine("Qual valor inteiro até 10946 deseja verificar se existe na Sequencia Fiboncci:");
                Valor = Int32.Parse(Console.ReadLine());
            }
            if (Posicao == 5)
            {
                Console.WriteLine("Digite o texto que deseja inverter: ");
                ValorString = Console.ReadLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("O valor da função inserida é null ou inválido.");
            throw;
        }


    }
    public void Resolucao()
    {
        switch (Posicao)
        {
            case 1:
                {
                    var soma = new SomaIndice();
                    soma.ResultadoSomaIndice();             
                    break;
                }
            case 2:
                {
                    var fibonacci = new SequenciaFibonacci();
                    fibonacci.LogicaSequenciaFibonacci();
                    fibonacci.ValidacaoNumeroExistenteFibonacci(Valor);
                    fibonacci.ValidacaoVisualizarLeituraList();
                    
                   
                    break;
                }
            case 3:
                {;
                    var completeSequencia = new CompleteNumeroSequencia();
                    completeSequencia.Resolução();
                    break;
                }
            case 4:
                {
                    var carroCaminhao = new Veiculos();
                    carroCaminhao.Resolucao();

                    break;
                }
            case 5:
                {
                    var inverterString = new InverterString();
                    inverterString.ReverseFor(ValorString);
                    
                    break;
                }
        }

    }


}
