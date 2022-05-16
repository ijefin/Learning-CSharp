using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;

        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilidrada(int cilindrada)
        {
            {
                //Forçar um valor positivo para a variável com Math.Abs()
                //Cilindrada = Math.Abs(cilindrada);
            }
        }
    }
    public class Getset
    {
        public static void Executar()
        {
            Console.WriteLine("Inicio");
            var moto = new Moto("Kawasaki Ninja", "Kawasaki", 600);
            Console.WriteLine(moto.GetMarca());
            Console.WriteLine(moto.GetModelo());
            Console.WriteLine(moto.GetCilindrada());

            var moto1 = new Moto("CB 650F", "Honda", 650);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Yamaha");
            moto2.SetModelo("Fazer");
            moto2.SetCilidrada(-300);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }

}
