using System;

namespace Atividade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone moto = new Phone();
            moto.model = "Motorola";
            moto.color = "Gold";
            moto.size = 14f;
            moto.mode = false;
            moto.call = "Would you made a call ?";
            moto.message = "Would you like text a message ?";
            moto.callmessage = "Type the number that you want call: ";
            moto.text = "Type the number and the message that want send :";
            
            Console.WriteLine("Model: "+ moto.PhoneModel());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Color: "+ moto.PhoneColor());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Size: "+ moto.Phonesize());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(moto.PhoneMode());
            Console.WriteLine("-------------------------------------");
            moto.metodos = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(moto.Metodos());
            Console.WriteLine("-------------------------------------");
            moto.text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("-------------------------------------");
            moto.calling = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(moto.Call());
            Console.WriteLine("-------------------------------------");
           moto.call = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            





           

            
            



        }
    }
}
