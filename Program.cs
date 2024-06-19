
// Screen Sound 

//List<string> listaDasBandas =new List<string> {"U2", "Beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 
bandasRegistradas.Add("U2", new List<int> {10, 8, 6});
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirLogo(){
    Console.WriteLine(@"
    
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    string boasVindas = "Boas vindas ao Screen Sound";
    Console.WriteLine(boasVindas);
}

void ExibirMenu(){
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda\n");
    Console.WriteLine("Digite 2 para mostar todas as bandas\n");
    Console.WriteLine("Digite 3 para avaliar uma banda\n");
    Console.WriteLine("Digite 4 para exibir a média de uma banda\n");
    Console.WriteLine("Digite -1 para sair\n");

    Console.Write("Digite a sua opção: ");
    string Escolha = Console.ReadLine()!;
    int OpcaoEscolhaNumerica = int.Parse(Escolha);
    switch (OpcaoEscolhaNumerica){
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibeMediaBanda();
            break;
        case -1: Console.WriteLine("Até a próxima !");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBandas(){
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrado com sucesso !");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas(){
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo bandas cadastradas");
    //for (int i = 0; i < listaDasBandas.Count; i++){
    //   Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTituloDaOpcao(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos+"\n");
}

void AvaliarBanda(){
    //digite a banda que deseja avaliar
    //se a banda existir >> atribuir uma nota
    //senão volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota}, foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada !");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void ExibeMediaBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome da banda que deseja saber a média das notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)){
        List<int> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é {notas.Average():F2}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada !");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

//ExibirLogo();
ExibirMenu();



//void IndicaCursoEInstrutor(){
//string curso = "C# ";
//string nome = "Pedro ";
//string sobrenome = "Silva";
//Console.WriteLine("O curso é de "+curso+"e o instrutor é o "+nome+" "+sobrenome);
//}

//IndicaCursoEInstrutor();