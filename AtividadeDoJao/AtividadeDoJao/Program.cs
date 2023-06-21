using System;



namespace ExemploInterface
{
    public interface Ianimal
    {
        void EmiteSom();
    }
    public class Cachorro : Ianimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Chachorro late. ");
        }
    }



    public class Gato : Ianimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Gato mia. ");
        }
    }
    class program
    {
        static void Main(string[] args)
        {



            Ianimal cachorro1 = new Cachorro();
            Ianimal gato1 = new Gato();



            cachorro1.EmiteSom();
            gato1.EmiteSom();

            Console.ReadLine();
        }
    }
}
