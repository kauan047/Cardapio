// See https://aka.ms/new-console-template for more information


string res;
string opcao;

Console.WriteLine("Ola seja bem vindo, tudo bem ?");

Console.WriteLine("Voce teria interesse em saber do cardapio ? Sim/Nao");

opcao = Console.ReadLine(); 

string uppercase = opcao.ToUpper(); 
string lowercase = opcao.ToLower();

Console.WriteLine("Essa eh nossa opcao:");


inicio:

Console.WriteLine("Bebidas:");

Console.WriteLine(" 1 - Suco de maracuja\n 2- Suco de abacaxi com hortela\n 3- Chopp de vinho\n ");

int nb = int.Parse(Console.ReadLine());

Console.WriteLine("Porcoes:");

Console.WriteLine(" 1 - Batata frita com chedder\n 2- Camarao com atum\n 3- Arroz grelhado\n");

int np = int.Parse(Console.ReadLine());



switch (nb)
{
    case 1:




        break; 
    
    
    case 2:

        break;

        
    case 3:




        break;

    default:



        break; 


}

Console.WriteLine("Deseja voltar ao cardapio ?");

res = Console.ReadLine();

if (res == "sim" || res == "SIM")
{
    goto inicio;

}

