﻿// Screen Sound 
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> ListaDasBandas = new List<string>();
    
    void ExibirLogo()
{  
    Console.WriteLine("Ｓｃｒｅｅｎ Ｓｏｕｎｄ");  
    Console.WriteLine(mensagemDeBoasVindas);
}
  

//Menu
    void ExibirOpcoesMenu(){

    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para Avaliar uma banda");
    Console.WriteLine("Digite 4 para Exibir Média da banda");
    Console.WriteLine("Digite -1 para Sair");

    Console.Write("\nDigite a Sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();   
        break;
        case 2:MostrarBandasRegistradas();
        break;
        case 3:Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumerica);
        break;
        case 4:Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
        break;
        case -1:Console.WriteLine("Tchau Tchau :) ");
        break;
        default:Console.WriteLine("Opção Inválida");
        break;
    }
    void RegistrarBanda(){
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Registro de Bandas");
        Console.WriteLine("*****************\n");
        Console.Write("Digite o Nome da Banda que deseja registrar:");
        string nomeDaBanda = Console.ReadLine()!;
        ListaDasBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();

    }

    void MostrarBandasRegistradas(){
        Console.WriteLine("***********************************\n");
        Console.WriteLine("Exibindo todas as Bandas Registradas.");
        Console.WriteLine("***********************************\n");
        //for (int i = 0; i < ListaDasBandas.Count; i++){

          //  Console.WriteLine($"Banda: {ListaDasBandas[i]}");
       // }

       foreach (string banda in ListaDasBandas){
        Console.WriteLine($"Banda: {banda}");
       }
        Console.WriteLine("\nDigite uma Tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    }
}
    ExibirLogo();
    ExibirOpcoesMenu();