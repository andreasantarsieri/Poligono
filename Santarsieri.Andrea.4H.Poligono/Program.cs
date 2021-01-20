using System;

namespace Santarsieri.Andrea._4H.Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero dei lati");
            string strNlato = Console.ReadLine();
            Console.WriteLine("Inserisci il valore del lato");
            string strVlato = Console.ReadLine();
            double Nlato = Convert.ToDouble(strNlato);
            double Vlato = Convert.ToDouble(strVlato);
            Poligono p1 = new Poligono(Nlato, Vlato);
            Poligono Quad = new Poligono();
            Poligono p2 = new Poligono(4, 3);
            
            string strS = p1.Stampa(p1);
            
            p1.NFisso(p1);
            p1.Apotema(p1);
            p1.Perimetro(p1);
            p1.Area(p1);

            Console.WriteLine($"Il costruttore di base numeri lati {Quad.Numerolato} e di valore {Quad.Valorelato} ");

            Console.WriteLine($"L'apotema del poligono di {p1.Nlato} e di valore {p1.Vlato} vale {p1.apotema:n2}");

            Console.WriteLine($"Il valore del perimetro è {p1.perimetro:n2}");

            Console.WriteLine($"Il valore dell'area del poligono regolar e' {p1.area:n2}");

            Console.WriteLine($"Il nome del poligono di {p1.Nlato} lati e' un {strS}");

            string confronto = p1.Confronta(p1, p2);
            Console.WriteLine(confronto);






      

        }
    }

    class Poligono
    {
        public double Nlato;
        public double Vlato;
        public double Numerolato;
        public double Valorelato;
        public double Nfisso;
        public double apotema;
        public double perimetro;
        public double area;
        


        public Poligono(double x, double y)
        {
            Nlato = x;
            Vlato = y;
        }
        public Poligono()
        {
            Numerolato = 4;
            Valorelato = 1;
        }
        public void NFisso(Poligono p1)
        {
            Nfisso = 1 /  (2 * Math.Tan(Math.PI / Nlato));
        }
        public void Apotema(Poligono p1)
        {
            apotema = Vlato * Nfisso;
        }
        public void Perimetro(Poligono p1)
        {
            perimetro = Vlato * Nlato;
        }
        public void Area(Poligono p1)
        {
            area = (perimetro * apotema) / 2;
        }
        public string Stampa(Poligono p1)
        {
            string strS ="";
            switch(p1.Nlato)

            {
                case 3:
                    strS = "triangolo";
                    break;
                case 4:
                    strS = "quadrato";
                    break;
                case 5:
                    strS = "pentagono";
                    break;
                case 6:
                    strS = "esagono";
                    break;
                case 7:
                    strS = "ettagono";
                    break;
                case 8:
                    strS = "ottagono";
                    break;
                case 9:
                    strS = "ennagono";
                    break;
                case 10:
                    strS = "decagono";
                    break;

                    
                


            }
            return  strS;
        }
        public string Confronta(Poligono p1 , Poligono p2)
        {
             string strConfronta = "";

            if (p1.Nlato == p2.Nlato )
            {
                if (p1.Vlato > p2.Vlato )
                {
                    strConfronta = "Il poligono passato e' più grande";
                }
                if(p1.Vlato < p2.Vlato)
                {
                    strConfronta = "Il poligno passato e' più piccolo";
                }
                if(p1.Vlato == p2.Vlato)
                {
                    strConfronta = "Il poligono passato e' uguale";
                }
            
            }
            else
            {
                strConfronta = "il poligono non è confrontabile";
            }
            return strConfronta;
        }
    }
    
}
