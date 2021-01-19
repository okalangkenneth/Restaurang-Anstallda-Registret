using System;

namespace Restaurang_Anställda_Registret
{
       public class anställda
    {
        public string namn;
        public string lön;

        public void Registret()
        {
            Console.WriteLine("Registret:" + namn + " " + lön);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var kenneth = new anställda();
            kenneth.namn = "Kenneth ";
            kenneth.lön = "25,000";
            kenneth.Registret();

        }
    }
}
