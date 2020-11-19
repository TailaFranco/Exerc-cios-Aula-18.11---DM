using System;

namespace Exercícios_18._11
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Para descomentar utilize ctrl + k + u
            // Para comentar utilize ctrl + k + c

            //Programa que peça uma nota, entre zero e dez. 
            //Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
            
            //Primeira tentativa funcional
            // int nota;
            // int i;
            // Console.WriteLine("Digite uma nota entre zero e dez");
            //          nota = int.Parse(Console.ReadLine());
            //          if (nota >= 0 && nota<=10)
            //          {
            //              i =1;
            //          }
            //          else
            //          {
            //              i =0;
            //          }

            //     while (i == 0)
            //     {
            //         Console.WriteLine("Nota inválida");
            //         Console.WriteLine("Digite uma nota entre zero e dez");
            //          nota = int.Parse(Console.ReadLine());
            //          if (nota >= 0 && nota<=10)
            //          {
            //              i =1;
            //          }
            //          else
            //          {
            //              i =0;
            //          }
            //     }
            // Console.WriteLine("Nota:"+nota+"");
            // fim

           // Programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário;
           // Mostrando uma mensagem de erro e voltando a pedir as informações.

        //    string usuário;
        //    string senha;

        //    Console.WriteLine("Digite o seu nome de usuário");
        //    usuário = Console.ReadLine();
        //    Console.WriteLine("Digite a sua senha \n Não pode ser o seu nome");
        //    senha = Console.ReadLine();
        //    do
        //    {
        //    if (senha != usuário)
        //    {
        //        Console.WriteLine("Processando...");
        //    }
        //    else {
        //        Console.WriteLine("ERRO - Sua senha não pode ser igual ao seu nome");
        //        Console.WriteLine("Digite a sua senha \n Não pode ser o seu nome");
        //    senha = Console.ReadLine();
        //    }
        //     } while (senha == usuário);
        //     Console.WriteLine("Dados salvos com sucesso");

        // Programa que leia e valide as seguintes informações:

        // 1. Nome: diferente de vazio;
        // 2. Idade: entre 0 e 150;
        // 3. Salário: maior que zero;
        // 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

        string nome;
        int idade;
        float salário;
        string estado;
        int i;

        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();
        do
        {
            if(nome != "")
            {
               // Console.WriteLine("Nome salvo");
            }
            else{
                Console.WriteLine("Você não inseriu um valor válido");
                 Console.WriteLine("Digite seu nome:");
                 nome = Console.ReadLine();
            }
        } while (nome == "");
        Console.WriteLine("Nome salvo");

        Console.WriteLine("Digite a sua idade");
        idade = int.Parse(Console.ReadLine());
        do
        {
            if( idade >= 0 && idade <= 150 )
            {
               i=1;
            }
            else{
                i=0;
                Console.WriteLine("Você não inseriu um valor válido");
                 Console.WriteLine("Digite a sua idade");
                idade = int.Parse(Console.ReadLine());
                
            }
        } while (i == 0);
        Console.WriteLine("Idade Salva");

        Console.WriteLine("Digite o seu salário");
        salário = int.Parse(Console.ReadLine());
        do
        {
            if( salário > 0 )
            {
               i=1;
            }
            else
            {
                i=0;
                Console.WriteLine("Você não inseriu um valor válido");
                Console.WriteLine("Digite o seu salário");
                salário = int.Parse(Console.ReadLine());
            }
        } while (i == 0);
        Console.WriteLine("Salário Salvo");

        Console.WriteLine("Digite seu estado civil: \n Responda apenas com iniciais: \n solteiro(a) - (s) \n casado(a) - (c) \n viuvo(a) - (v) \n divorciado(a) - (d)");
        estado = Console.ReadLine();
        do
        {
            if(estado == "d" || estado == "c" || estado == "v" || estado == "s" )
            {
               i=1;
            }
            else{
                i=0;
                Console.WriteLine("Você não inseriu um valor válido");
                Console.WriteLine("Digite seu estado civil: \n Responda apenas com iniciais: \n solteiro(a) - (s) \n casado(a) - (c) \n viuvo(a) - (v) \n divorciado(a) - (d)");
                estado = Console.ReadLine();
            }
        } while (i == 0);
        Console.WriteLine("Estado civil salvo");

        }
    }
}
