// Screen Sound 
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    
    void ExibirMensagemDeBoasVindas()
{  
    Console.WriteLine("Ｓｃｒｅｅｎ Ｓｏｕｎｄ");  
    Console.WriteLine(mensagemDeBoasVindas);
}
  ExibirMensagemDeBoasVindas();

//Menu
    void ExibirOpcoesMenu(){

    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para Avaliar uma banda");
    Console.WriteLine("Digite 4 para Exibir Média da banda");
    Console.WriteLine("Digite -1 para Sair");

    Console.Write("\nDigite a Sua opção:");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1:Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumerica);
        break;
        case 2:Console.WriteLine("Você escolheu a opção: "+ opcaoEscolhidaNumerica);
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
}
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();