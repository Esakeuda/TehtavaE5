using System;

namespace PisinSana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä lause: ");
            string lause = Console.ReadLine();

            string[] sanat = lause.Split();  // Jakaa lauseen sanoiksi erotettuna välilyönneillä

            string pisinSana = "";  // Alustetaan pisimmän sanan muuttuja tyhjällä merkkijonolla

            // Käydään läpi jokainen sana lauseesta
            foreach (string sana in sanat)
            {
                if (sana.Length > pisinSana.Length)
                {
                    pisinSana = sana;  // Päivitetään pisimmän sanan muuttuja tarvittaessa
                }
            }

            Console.WriteLine("Pisimmän sanan: " + pisinSana);
        }
    }
}

