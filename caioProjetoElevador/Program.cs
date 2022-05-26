using System;


namespace caioProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // coletar hora e dizer bom dia/tarde/noite

            DateTime tempo = DateTime.Now;
            
            if (tempo.Hour > 6 && tempo.Hour < 12)
                Console.WriteLine("Olá! Bom dia!");
            else if (tempo.Hour >= 12 && tempo.Hour < 18)
                Console.WriteLine("Olá! Boa tarde!");
            else
                Console.WriteLine("Olá! Boa noite!");


            // cria elevador e coleta suas definições para executar o programa

            Elevador elevadorA = new Elevador();

            Console.WriteLine("Digite o nome do condomínio:");
            Console.WriteLine($"O nome atual é {elevadorA.nomeCondo}");
            elevadorA.nomeCondo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de andares:");
            Console.WriteLine($"A quantidade atual é {elevadorA.andaresTotal}");
            elevadorA.andaresTotal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade de pessoas deste elevador:");
            Console.WriteLine($"A capacidade atual é {elevadorA.capacTotal}");
            elevadorA.capacTotal = int.Parse(Console.ReadLine());

            Console.Clear();

            // mensagem inicial para iniciar a interação com o elevador

            Console.WriteLine("Olá Ascensorista! O elevador está vazio e localizado no andar 0 (térreo)");
            Console.WriteLine("Escolha [i]niciar ou [s]air:\n");
            elevadorA.op = Console.ReadLine();
            
            if (elevadorA.op == "i")
            {
                while (true)
                {
                    Console.Clear();

                    // coleta de novas informações para o elevador funcionar

                    Console.WriteLine("Quantas pessoas vão entrar no elevador?");
                    elevadorA.varE = int.Parse(Console.ReadLine());
                    /*
                    if ((elevadorA.varE + elevadorA.ocupNova) > 0 && (elevadorA.varE + elevadorA.ocupNova) <= elevadorA.capacTotal)
                    {
                        elevadorA.ocupNova += elevadorA.varE;
                    }
                    else
                    {
                        Console.WriteLine($"Ops! Número menor que a capacidade do elevador (Capacidade: {elevadorA.capacTotal})");
                        elevadorA.varE = int.Parse(Console.ReadLine());
                        elevadorA.ocupNova += elevadorA.varE;
                    }
                    */

                    while ((elevadorA.varE + elevadorA.ocupNova) < 0 ^ (elevadorA.varE + elevadorA.ocupNova) > elevadorA.capacTotal)
                    {
                        Console.WriteLine($"Ops! Número menor que a capacidade do elevador (Capacidade: {elevadorA.capacTotal})");
                        elevadorA.varE = int.Parse(Console.ReadLine());
                    }
                    elevadorA.ocupNova += elevadorA.varE;


                    Console.WriteLine("Digite para qual andar deseja ir:");
                    elevadorA.andarAtual = int.Parse(Console.ReadLine());
                    /*           
                    if (elevadorA.andarAtual < 0 ^ elevadorA.andarAtual > elevadorA.andaresTotal)
                    {
                        Console.WriteLine($"Ops! Número inválido. (Térreo: 0, Último andar: {elevadorA.andaresTotal})");
                        elevadorA.andarAtual = int.Parse(Console.ReadLine());
                    }
                    */

                    while (elevadorA.andarAtual < 0 ^ elevadorA.andarAtual > elevadorA.andaresTotal)
                    {
                        Console.WriteLine($"Ops! Número inválido. (Térreo: 0, Último andar: {elevadorA.andaresTotal})");
                        elevadorA.andarAtual = int.Parse(Console.ReadLine());
                    }


                    Console.WriteLine("Quantas pessoas vão sair do elevador?");
                    elevadorA.varS = int.Parse(Console.ReadLine());
                    /*
                    if (elevadorA.varS > elevadorA.ocupNova)
                    {
                        Console.WriteLine($"Ops! O elevador possui {elevadorA.ocupNova} pessoas dentro dele");
                        elevadorA.varS = int.Parse(Console.ReadLine());
                    }
                    */

                    while (elevadorA.varS > elevadorA.ocupNova)
                    {
                        Console.WriteLine($"Ops! O elevador possui {elevadorA.ocupNova} pessoas dentro dele");
                        elevadorA.varS = int.Parse(Console.ReadLine());
                    }


                    elevadorA.ocupNova -= elevadorA.varS;

                    Console.WriteLine(elevadorA.ocupNova);


                    // informa status do elevador conforme ocupação

                    Console.Clear();

                    Console.WriteLine("--------------");

                    Console.WriteLine($"Condomínio {elevadorA.nomeCondo} informa:");
                    Console.WriteLine($"O elevador está no {elevadorA.andarAtual} andar");

                    if (elevadorA.ocupNova == 1)
                    {
                        Console.WriteLine($"{elevadorA.ocupNova} passageiro está no elevador");
                    }
                    else if (elevadorA.ocupNova > 1)
                    {
                        Console.WriteLine($"{elevadorA.ocupNova} passageiros estão no elevador");
                    }
                    else
                    {
                        Console.WriteLine("O elevador está vazio.");
                    }

                    Console.WriteLine("Escolha [c]ontinuar ou [s]air:\n");
                    elevadorA.op = Console.ReadLine();

                    // teste para sair do programa ou permanecer após o primeiro ciclo de perguntas
                    if (elevadorA.op == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("Tchau tchau!");
                        break;
                    }

                    else
                    {
                        continue;
                    }

                }
            }

            Console.Clear();
            Console.WriteLine("Tchau tchau!");



        }
    }

}
