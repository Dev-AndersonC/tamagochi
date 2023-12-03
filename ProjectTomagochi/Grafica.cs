using System.Security.Cryptography.X509Certificates;

namespace ProjectTomagochi;

public class Grafica
{
    public void MenuPrincipal(){
         string[] menuT = File.ReadAllLines("Menu/MenuTamagochi.txt");
            foreach (string menuTamagochi in menuT)
            {
                Console.WriteLine(menuTamagochi);
            }}
    
        public void Bixinho(){
         string[] bixinho = File.ReadAllLines("Menu/Bixinho.txt");
            foreach (string virtualAnimal in bixinho)
            {
                Console.WriteLine(virtualAnimal);
            }}
        
       public void StatusFrase(){
         string[] sttsAnimal = File.ReadAllLines("Menu/Status.txt");
            foreach (string stts in sttsAnimal)
            {
                Console.WriteLine(stts);
            }}
        
        public void GameOver(){
         string[] final = File.ReadAllLines("Menu/GameOver.txt");
            foreach (string gameover in final)
            {
                Console.WriteLine(gameover);
            }}
        public void Helper(){
         string[] ajuda = File.ReadAllLines("Menu/readme.txt");
            foreach (string help in ajuda)
            {
                Console.WriteLine(help);
            }}

 
    // public void PularLinha(){
    //     Console.WriteLine("");
    // }
    
}
