// Nama     : CALLISTA ALODIA MARELLA
// NIM      : 222410103092
// Kelas    : C
// Tugas    : 1 (Praktikum)

using LAPTOP;
using ProcessorComponents;
using System.ComponentModel.DataAnnotations;
using VGA;

namespace ProcessorComponents
{
    class Processor
    {
        public string merk;
        public string tipe;
        public Processor(string modelMerk, string modelTipe)
        {
            merk = modelMerk;
            tipe = modelTipe;
        }
    }
    class Intel : Processor
    {
        public Intel(string modelTipe) : base("intel", modelTipe) { }
    }

    class CoreI5 : Intel
    {
        public CoreI5() : base("Core i5") { }
    }

    class CoreI7 : Intel
    {
        public CoreI7() : base("Core i7") { }
    }

    class CoreI9 : Intel
    {
        public CoreI9() : base("Core i9") { }
    }

    class AMD : Processor
    {
        public AMD(string modelTipe) : base("AMD", modelTipe) { }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN") { }
    }
}

namespace VGA
{
    class VGA
    {
        public string merk;
        public VGA(string modelMerk)
        {
            merk = modelMerk;
        }
    }

    class AMD : VGA
    {
        public AMD() : base("AMD") { }
    }
    class Nvidia : VGA
    {
        public Nvidia() : base("Nvidia") { }
    }
}

namespace LAPTOP
{
    using ProcessorComponents;
    using VGA;

    class LaPtoP
    {
        public string merk;
        public string tipe;
        public VGA Vga;
        public Processor processor;

        public LaPtoP(string modelMerk, string modelTipe, VGA modelVga, Processor modelProcessor)
        {
            merk = modelMerk;
            tipe = modelTipe;
            Vga = modelVga;
            processor = modelProcessor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class ASUS : LaPtoP
    {
        public ASUS(string tipe, VGA Vga, Processor processor) : base("ASUS", tipe, Vga, processor) { }
    }

    class Vivobook : ASUS
    {
        public Vivobook(VGA Vga, Processor processor) : base("Vivobook", Vga, processor) { }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ROG : ASUS
    {
        public ROG(VGA Vga, Processor processor) : base("ROG", Vga, processor) { }
        public void MenontonFilm()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang streaming secara online");
        }
    }

    class ACER : LaPtoP
    {
        public ACER(string tipe, VGA Vga, Processor processor) : base("ACER", tipe, Vga, processor) { }
    }

    class Predator : ACER
    {
        public Predator(VGA Vga, Processor processor) : base("Predator", Vga, processor) { }
        
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Lenovo : LaPtoP
    {
        public Lenovo(string tipe, VGA Vga, Processor processor) : base("Lenovo", tipe , Vga, processor) { }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(VGA Vga, Processor processor) : base("IdeaPad", Vga, processor) { }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        LaPtoP Laptop1, Laptop2, Laptop3;
        Predator predator;

        Laptop1 = new Vivobook(new VGA.Nvidia(), new ProcessorComponents.CoreI5());
        Laptop2 = new IdeaPad(new VGA.AMD(), new ProcessorComponents.Ryzen());
        Laptop3 = new ROG(new VGA.AMD(), new ProcessorComponents.CoreI9());
        predator = new Predator(new VGA.AMD(), new ProcessorComponents.CoreI7());
    }
}