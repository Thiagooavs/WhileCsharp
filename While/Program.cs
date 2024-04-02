using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* matricula
             
           
            int cont = 2;

            Console.Write("Digite o valor da matrícula: ");
            double mat = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do material: ");
            double mate = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da anuidade: ");
            double an = double.Parse(Console.ReadLine());

            Console.WriteLine("O total é: R$" + (mat + mate + an));
            Console.WriteLine("Quantas parcelas: ");
            int limit = int.Parse(Console.ReadLine());
            double result = an / (limit);
            double prim = mat + mate + result;
            Console.WriteLine("Parcela 1: " + prim.ToString("C"));
            

            while (cont <= limit) 
            { 
                
                Console.WriteLine("Parcela " + cont + ": " + result.ToString("C"));
                cont++;            
            }

            Console.ReadKey();
            */

            int Cont =0;
            double total = 0;
            double media = 0;
            string resp = "S";
            double sal = 0;

            while (resp == "S")
            {
                Cont++;
                Console.Write("Digite qual o tipo do seu salário: ");
                Console.WriteLine("1- Assalariado");
                Console.WriteLine("2- Comissionado");
                Console.WriteLine("3- Horista");
                Console.Write("Escolha: ");
                int esc = int.Parse(Console.ReadLine());

                switch (esc) {
                    case 1:
                        Console.Write("Digite o seu salário: R$");
                        double bru = double.Parse(Console.ReadLine());

                        Console.Write("Digite o valor do desconto: ");
                        double des = double.Parse(Console.ReadLine());

                        sal = bru - des;
                        break;

                    case 2:
                        Console.Write("Digite o seu porcentual de vendas: ");
                        double por = double.Parse(Console.ReadLine());

                        Console.Write("Digite o valor das vendas:R$ ");
                        bru = double.Parse(Console.ReadLine());

                        sal = bru * ( por / 100);
                        break;

                    case 3:
                        Console.Write("Digite o seu horário de trabalho: ");
                        por = double.Parse(Console.ReadLine());

                        Console.Write("Digite o valor por hora: R$");
                        bru = double.Parse(Console.ReadLine());

                        sal = bru * por;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        Console.ReadKey();
                        break;
                        
                }
                Console.WriteLine("Seu salário é " + sal.ToString("C"));
                total += sal;
                Console.Write("Próximo empregado(S/N)? ");
                resp = Console.ReadLine().ToUpper();
                Console.Clear();
            }

            media = total / Cont;
            
            Console.WriteLine("A empresa tem " + Cont + " Funcionários");
            Console.WriteLine("A sua folha de pagamento será: " + total.ToString("C"));       
            Console.WriteLine("Tendo uma média salárial de " + media.ToString("C"));

            Console.ReadKey();



        }
    }
}
