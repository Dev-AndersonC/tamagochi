namespace ProjectTomagochi.Models
{
    public class Tamagochi
    {
        private string _nome;
        private int _limpeza = 50;
        private int _vida = 50;
        private int _comida = 50;
        private int _sono = 50;
        private int _felicidade = 50;
        private int _diversão = 50;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _nome = "Guilo";
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public int Vida
        {
            get { return _vida; }
            set { _vida = value; }
        }

        public int Comida {
            get { return _comida;}
            set {_comida = value;}
        }
        public int Dormi {
            get { return _sono;}
            set {_sono = value;}
        }

        public int Brincar
        {
            get { return _diversão; }
            set { _diversão = value; }
        }

        public int Carinho {
            get {return _felicidade;}
            set {_felicidade = value;}
        }
        public int Banho {
            get {return _limpeza;}
            set {_limpeza = value;}
        }

        public bool VidaTamagochi()
        {
            bool TamagochiMorreu = false;
            if (Vida <= 0)
            {
                TamagochiMorreu = true;
            }
            return TamagochiMorreu;
        }

        public Tamagochi()
        {
            Nome = _nome;
            // Consider whether you want to initialize properties here or leave them with default values.
        }

        public void BoasVindas()
        {
            Console.WriteLine($"Bem vindo - Esse é seu bixinho virtual");
        }

        public void StatusTamagochi()
        {
            Console.WriteLine($"Nome:{Nome}\nVida:{Vida}\nDiversão:{Brincar}\nFelicidade:{Carinho}\nCansaço:{Dormi}\nFome:{Comida}");
        }

        public void Brincando()
        {
          Brincar += 20;
          Vida -= 25;
        }
        public void Dormir()
        {
          int vidaFalta = Math.Abs(Vida - 70);
          Dormi = 100;
          Vida += vidaFalta;
          Brincar -=25;
          Carinho -=25;
          Comida -=15;
          Banho -=35;
        }public void Comer()
        {
          
          if(Comida == 100){
            Console.WriteLine($"{Nome} esta cheio!");
          } else {
            Comida+= 25;
            Banho-=5;
            Carinho+=1;
            Brincar-=10;
            Vida +=3;

          }
        }public void Cafune()
        {
          Carinho+=15;
          Banho-=20;
          Brincar-=10;
          Vida -=5;
        
        }
        public void Banhozinho()
        {
            Banho+=15;
            Vida-=20;
            Carinho-=15;
            Brincar-=20;
            Dormi-=50;
        }
    
    }
}
