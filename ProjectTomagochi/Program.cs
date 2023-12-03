using System;
using ProjectTomagochi;
using ProjectTomagochi.Models;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tamagochi tama = new Tamagochi();
            Grafica menus = new Grafica();
            bool sairPrograma = true;
            bool teclou = true;
           
            menus.MenuPrincipal();
            Console.Write("      Digite o nome do seu Tamagochi:");
            tama.Nome = Console.ReadLine();
            Console.Clear();
            while(sairPrograma) {
                menus.MenuPrincipal();
                menus.Bixinho();
                tama.BoasVindas();
                tama.StatusTamagochi();
                Console.WriteLine("Digite um opções abaixo.\n[1] - Brincar\n[2] - Fazer Carinho\n[3] - Dar comida\n[4] - Dar Banho\n[5] - Dormir\n[6] - Help\n[7] - Encerrar ");
                string opcao = Console.ReadLine();
                if (tama.VidaTamagochi() == true){
                    sairPrograma = false;
                    menus.GameOver();
                    Console.WriteLine("Tamagochi Morreu!");
                    break;
                }
                switch(opcao){
                    case "1":
                        tama.Brincando();
                        Console.WriteLine("Esta brincando");
                        break;
                    case "2":
                        tama.Cafune();
                        Console.WriteLine("Fazendo Carinho");
                        break;
                    case "3":
                        tama.Comer();
                        Console.WriteLine("Comendo..");
                        break;
                    case "4":
                        tama.Banhozinho();
                        Console.WriteLine("Tomando Banhozinho");
                        break;
                    case "5":
                        tama.Dormir();
                        Console.WriteLine($"{tama.Nome} foi tirar uma sonequinha...");
                        break;
                    case "6":
                        Console.Clear();
                        // menus.MenuPrincipal(); Logo principal
                        // menus.Bixinho(); Logo tamagochi
                        // menus.StatusFrase(); Um logo feita para a antiga aba de mostrar status;
                        menus.Helper();
                        break;
                    case "7":
                        Console.WriteLine("Encerrando Tamagochi");
                        sairPrograma = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine(); 
                }

        
            }


            // switch (value)
            // {
            //     case value1:
            //         break;
            //     default:
            //         break;
            // }
            
            
            
        }
    }
