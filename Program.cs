double totalPedido = 0;
bool pedidoAberto = true;

while(pedidoAberto)
{
    Console.WriteLine("Bem vindo ao melhor sistema de gerenciamento de pedidos da ADS!");
    Console.WriteLine("1 - Adicionar item ao pedido: ");
    Console.WriteLine("2 - Exibir total do pedido: ");
    Console.WriteLine("3 - Finalixar o pedido e sair: ");
    Console.WriteLine("Escolha uma opção acima!");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
        Console.WriteLine("Escolha um item abaixo: ");
        Console.WriteLine("1 - Pizza        R$30,00");
        Console.WriteLine("2 - Hambúrguer   R$15,00");
        Console.WriteLine("2 - Refrigerante R$5,00");
        string escolha = Console.ReadLine();
        if (escolha == "1")
        {
            totalPedido = totalPedido + 30.00;
            Console.WriteLine("Pizza adicionado ao carrinho!");
        }
        else if(escolha == "2")
        {
            totalPedido += 15.00;
            Console.WriteLine("Hambúrguer adicionado ao carrinho!");
        }
        else if(escolha == "3")
        {
            totalPedido += 5.00;
            Console.WriteLine("Refrigerante adicionado ao carrinho!");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        break;
        case "2":
        {
            Console.WriteLine($"O total do seu pedido é: {totalPedido}");
        }
        break;
        case "3":
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Opção inválida!");
        break;
    }
}