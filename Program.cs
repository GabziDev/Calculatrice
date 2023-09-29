namespace Calculatrice
{
    class Program
    {
        static void Main(String[] args)
        {
            Calculatrice();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[!] Appuie sur une touche pour quitter la console !");
            Console.ReadKey();
        }

        static void Calculatrice()
        {
            Console.WriteLine("1 -> Addition\n2 -> Soustraction\n3 -> Multiplication\n4 -> Division\n\nChoix de l'opérateur : ");
            int operateur;
            operateur = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Premier Chiffre/Nombre : ");
            double calculeUn;
            calculeUn = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deuxième Chiffre/Nombre : ");
            double calculeDeux;
            calculeDeux = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            switch (operateur)
            {
                case 1:
                    Console.Write($"{calculeUn} + {calculeDeux} = ");
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.Write(calculeUn + calculeDeux);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.Write($"{calculeUn} - {calculeDeux} = ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(calculeUn - calculeDeux);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.Write($"{calculeUn} * {calculeDeux} = ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(calculeUn * calculeDeux);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.Write($"{calculeUn} / {calculeDeux} = ");
                    Console.ForegroundColor = ConsoleColor.Cyan; 
                    Console.WriteLine(calculeUn / calculeDeux);
                    Console.ResetColor(); 
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[!] Opérateur inconnu");
                    break;
            }
        }
    }
}