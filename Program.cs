using System;
using System.Collections.Generic;

namespace Quiz_1892564
{
    class Program
    {
        static void Main(string[] args)
    {
        InputRose();
        Roseinfo();

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        InputSunflower();
        Sunflowerinfo();

        Console.WriteLine(" ");
        Console.WriteLine(" ");

            roseoutput();
            sunfloweroutput();




    }
    static void InputRose()
    {

        Console.Write("Input Total Rose: ");
        int totalrose = int.Parse(Console.ReadLine());

    }
    static void InputSunflower()
    {
        Console.Write("Input Total Sunflower:");
        int totalsunflower = int.Parse(Console.ReadLine());


    }
    static void Roseinfo()
    {

        
        Console.WriteLine("Iput Rose");
        Console.Write("ID : ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Plant name : ");
        string name = Console.ReadLine();
        Console.Write("Plant description : ");
        string descrip = Console.ReadLine();
        Console.Write("Amount : ");
        int amount = int.Parse(Console.ReadLine()); ;
        Console.Write("Height : ");
        string height = Console.ReadLine();
        Console.Write("Circumference : ");
        string circum = Console.ReadLine();
    }
    static void Sunflowerinfo()
    {
        Sunflower sunflower = new Sunflower(1, "ดอกทานตะวันเล็ก", "สวยงาม", 1, "2.0", "2.0");
        Console.WriteLine("Iput Sunflower");
        Console.Write("ID : ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Plant name : ");
        string name = Console.ReadLine();
        Console.Write("Plant description : ");
        string descrip = Console.ReadLine();
        Console.Write("Amount : ");
        int amount = int.Parse(Console.ReadLine()); ;
        Console.Write("Height : ");
        string height = Console.ReadLine();
        Console.Write("Circumference : ");
        string circum = Console.ReadLine();
    }
    static void roseoutput()
    {
        
        Rose roseoutput = new Rose(1, "ดอกกุหลาบสีขาว", "สวยงามมาก", 2, "10.5", "6");
            Console.WriteLine("Rose Information ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(roseoutput.flowername);
            Console.WriteLine(roseoutput.id);
            Console.WriteLine(roseoutput.description);
            Console.WriteLine(roseoutput.amount);
            Console.WriteLine(roseoutput.circumference);

            List<Rose> roseinfo = new List<Rose>();
            foreach (Rose rose in roseinfo)
            {
                Console.WriteLine(rose.id);
            }


        }
        static void sunfloweroutput()
        {
        
            Sunflower sunfloweroutput = new Sunflower(1, "ดอกทานตะวันเล็ก", "สวยงาม", 1, "2.0", "2.0");
            Console.WriteLine("Sunflower Information ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(sunfloweroutput.flowername);
            Console.WriteLine(sunfloweroutput.id);
            Console.WriteLine(sunfloweroutput.description);
            Console.WriteLine(sunfloweroutput.amount);
            Console.WriteLine(sunfloweroutput.circumference);

            List<Sunflower> sunflowerinfo = new List<Sunflower>();
            foreach (Sunflower sunflower in sunflowerinfo)
            {
                Console.WriteLine(sunflower.id);
            }
        }

}
class Sunflower : Flowerinfo
{
    private List<Sunflower> sunflowerinfo;
    public Sunflower(int idvalue, string namevalue, string descriptionvalue, int amountvalue, string heightvalue, string circumferencevalue) : base(idvalue, namevalue, descriptionvalue, amountvalue, heightvalue, circumferencevalue)
    {
        this.id = idvalue;
        this.flowername = namevalue;
        this.description = descriptionvalue;
        this.amount = amountvalue;
        this.height = heightvalue;
        this.circumference = circumferencevalue;
        sunflowerinfo = new List<Sunflower>();
    }
    public void addList(Sunflower sunflower)
    {
        sunflowerinfo.Add(sunflower);
    }
    public void getinfo()
    {
        sunflowerinfo.ForEach(value => Console.WriteLine(value.id));
    }
}



class Rose : Flowerinfo
{
    private List<Rose> roseinfo;
    public Rose(int idvalue, string namevalue, string descriptionvalue, int amountvalue, string heightvalue, string circumferencevalue) : base(idvalue, namevalue, descriptionvalue, amountvalue, heightvalue, circumferencevalue)
    {
        this.id = idvalue;
        this.flowername = namevalue;
        this.description = descriptionvalue;
        this.amount = amountvalue;
        this.height = heightvalue;
        this.circumference = circumferencevalue;
        roseinfo = new List<Rose>();
    }
    public void addList(Rose rose)
    {
        roseinfo.Add(rose);
    }
    public void getinfo()
    {
        roseinfo.ForEach(value => Console.WriteLine(value.id));
    }
}

class Flowerinfo
{
    public int id;
    public string flowername;
    public string description;
    public int amount;
    public string height;
    public string circumference;

    public Flowerinfo(int idvalue, string namevalue, string descriptionvalue, int amountvalue, string heightvalue, string circumferencevalue)
    {
        id = idvalue;
        flowername = namevalue;
        description = descriptionvalue;
        amount = amountvalue;
        height = heightvalue;
        circumference = circumferencevalue;
    }
}
}
