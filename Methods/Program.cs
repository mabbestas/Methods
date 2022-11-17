using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(2, 3);
            Console.WriteLine(sonuc);

            static int Topla(int deger1, int deger2)
            {
                return (deger1 + deger2);
            }


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(a + 6));
            ornek.EkranaYazdir(Convert.ToString(a + 6)); 
        }

        class Metotlar
        {
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }


            public int ArttırVeTopla(ref int deger1, ref int deger2)
            {
                deger1 += 1;
                deger2 += 1;
                return deger1 + deger2;
            }
        }
    }
}
