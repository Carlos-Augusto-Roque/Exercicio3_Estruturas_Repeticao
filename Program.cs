using System;

namespace Exercicio3_Estruturas_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 validação do nome            
            Console.WriteLine("Digite o nome: ");//exibição da mensagem
            string nome = Console.ReadLine();//entrada e armazenamento do nome  
            while(nome == ""){//enquanto o nome for igual a vazio: ,
                Console.WriteLine("O campo nome não pode estar vazio !");//exibição da mensagem
                Console.Write("Digite o nome: ");//exibição da mensagem
                nome = Console.ReadLine();//entrada e armazenamento do nome 
            }
            Console.WriteLine("Nome validado !");////exibição da mensagem

            // 2 validação da idade
            Console.WriteLine("Digite a idade entre 0 e 150: ");//exibição da mensagem
            int idade = int.Parse(Console.ReadLine());//entrada e armazenamento da idade 
            while(idade <0 || idade>150){//enquanto a idade for menor que 0 e maior que 150: ,
                Console.WriteLine("A idade deve ser entre 0 e 150 !");//exibir a mensagem
                Console.Write("Digite a idade: ");//exibir a mensagem
                idade = int.Parse(Console.ReadLine());//entrada e armazenamento da idade
            }
            Console.WriteLine("Idade validada !");//exibição da mensagem

            // 3 validação do salário
            Console.WriteLine("Digite o valor do salário: ");//exibição da mensagem
            float salario = float.Parse(Console.ReadLine());
            while(salario <= 0){//enquanto salario for menor ou igual a zero: ,
                Console.WriteLine("O salário deve ser maior que 0 !");//exibição da mensagem
                Console.Write("Digite o valor do salário: ");//exibição da mensagem
                salario = float.Parse(Console.ReadLine());//entrada e armazenamento do salario
            }
            Console.WriteLine("Salário validado !");//exibição da mensagem


            // 4 validação do estado civil
            Console.WriteLine("Digite o estado civil : s para (solteiro), c para (casado), v para (viúvo) e d para (divorciado): ");//exibição da mensagem
            string estadoCivil = Console.ReadLine();//entrada e armazenamento do estado civil
            while(estadoCivil != "s" && estadoCivil != "c" && estadoCivil !="v" && estadoCivil !="d"){//enquanto estado civil for diferente das opções: ,
                Console.WriteLine("Estado civil inválido");//exibição da mensagem
                Console.WriteLine("Digite o estado civil : s para (solteiro), c para (casado), v para (viúvo) e d para (divorciado): ");//exibição da mensagem
                estadoCivil = Console.ReadLine();//entrada e armazenamento do estado civil
            }
            Console.WriteLine("Estado civil validado !");//exibição da mensagem 

            //mensagem de fechamento  
            Console.WriteLine("-----------------------");
            Console.WriteLine("Validação Concluída !");

        }
    }
}

//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;
// 2. Idade: entre 0 e 150;
// 3. Salário: maior que zero;
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));
