
using Target_Sistemas;
using Target_Sistemas.Funções;

Console.WriteLine("Bem vindo ao Sistema de Seleção Target");
Console.WriteLine("Segue as atividades propostas");
var target = new Target();

target.LeituraList();
target.EscolhaAtividade();
target.ValoresRecebidosAtividades();
target.Resolucao();


