namespace Figury
{
    internal class Program
    {
        static void Main()
        {
            bool flaga = true;
            while (flaga)
            {
                Console.WriteLine("Wybierz figurę, dla której chcesz obliczyć pole:");
                Console.WriteLine("1: Kwadrat");
                Console.WriteLine("2: Prostokąt");
                Console.WriteLine("3: Trójkąt");
                Console.WriteLine("4: Romb");
                Console.WriteLine("5: Deltoid");
                Console.WriteLine("6: Trapez");
                Console.WriteLine("7: Równoległobok");
                Console.WriteLine("0: Wyjście");
                string wybor = Console.ReadLine();
                if (wybor != null)
                {
                    switch (wybor)
                    {
                        case "1":
                            Console.WriteLine("Podaj długość boku kwadratu:");
                            double a = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole kwadratu = a^2 = {a}^2 = {a * a}");
                            break;
                        case "2":
                            Console.WriteLine("Podaj długość i szerokość prostokąta:");
                            double p = double.Parse(Console.ReadLine());
                            double q = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole prostokąta = p * q = {p} * {q} = {p * q}");
                            break;
                        case "3":
                            Console.WriteLine("Podaj podstawę i wysokość trójkąta:");
                            double b = double.Parse(Console.ReadLine());
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole trójkąta = 0.5 * b * h = 0.5 * {b} * {h} = {0.5 * b * h}");
                            break;
                        case "4":
                            Console.WriteLine("Podaj długość boku i wysokość rombu:");
                            double r = double.Parse(Console.ReadLine());
                            double s = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole rombu = r * s = {r} * {s} = {r * s}");
                            break;
                        case "5":
                            Console.WriteLine("Podaj długości przekątnych deltoidu:");
                            double d1 = double.Parse(Console.ReadLine());
                            double d2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole deltoidu = 0.5 * d1 * d2 = 0.5 * {d1} * {d2} = {0.5 * d1 * d2}");
                            break;
                        case "6":
                            Console.WriteLine("Podaj długości podstaw i wysokość trapezu:");
                            double c = double.Parse(Console.ReadLine());
                            double d = double.Parse(Console.ReadLine());
                            double ht = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole trapezu = 0.5 * (c + d) * ht = 0.5 * ({c} + {d}) * {ht} = {0.5 * (c + d) * ht}");
                            break;
                        case "7":
                            Console.WriteLine("Podaj długość podstawy i wysokość równoległoboku:");
                            double e = double.Parse(Console.ReadLine());
                            double hf = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Pole równoległoboku = e * hf = {e} * {hf} = {e * hf}");
                            break;
                        case "0":
                            flaga = false;
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór.");
                            break;
                    }
                    Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuuować");
                    Console.ReadKey();
                }
                else
                { Console.WriteLine("Zły wybor"); }
            }
        }
    }
}