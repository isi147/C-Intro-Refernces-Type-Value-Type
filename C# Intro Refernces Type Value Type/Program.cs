//Top level Statements - secimi ne ucundur
//Bu secimi proyekt yaradan zaman etmesek acilan seyfe void main olmadan acilir seyfede ne yazsaq butun kodlar icra olunur. Amma bu secimi etsek acilan seyfe void main ile acilir ve butun kodlar main icinde yazilir.
//C# da her sey class dir her sey objectdir
//


class Program
{


    class Test
    {
        public int a { get; set; }
        public string Name { get; set; }

        public Test(int a,string Name)
        {
            this.a = a;
            this.Name = Name;
        }
    }
    static void Main(string[] args)
    {
        //Console.BackgroundColor = ConsoleColor.Magenta;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WindowHeight = 30;
        //Console.WindowWidth = 30;
        //Console.WriteLine("Hello World");
        //Console.WriteLine("Hello World"); - yazilan stringi consolda gosterir ve sonda \n verir
        //Console.Write("Hello World"); - yazilan stringi consolda gosterir ve sonda \n vermir
        //Console.Write("Name:");  // cout<<"Name:";
        //Console.WriteLine("Name:");  // cout<<"Name:"<<endl;
        //string name = Console.ReadLine();
        //int a = 5;
        //Console.WriteLine("Name:" + name); //2  string conconation edir
        //Console.WriteLine($"Name:{name}-{a}"); //bu ise string interpolation edira

        //Console.ReadLine(); // bu ise consolda enter basmaq ucun istifade olunur ve string formatinda return edir
        //Console.Write("a:");
        //int a = Convert.ToInt32(Console.ReadLine()); // bu ise consolda enter basmaq ucun istifade olunur ve int formatinda return edir
        //Console.Write("b:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Sum:{ a + b}");

        //        Console.WriteLine(@"Silib gozlerini
        //bilekleri ile
        //olen ucan durnalara
        //seir yazdilar
        //olen durnalarin lelekleri ile");

        //Console.WriteLine(DateTime.Now);
        //Console.WriteLine(DateTime.Now.AddDays(1));
        //Console.WriteLine(DateTime.Now.AddHours(-1));
        //Console.WriteLine(DateTime.Now.AddYears(-12));

        //DateTime date = new DateTime(2023, 1, 1);
        //Console.WriteLine(date.ToLongDateString());


        //Console.WriteLine(DayOfWeek.Friday);
        //Unsafe blok yazilan kodlardan .net mehsuliyyet dasimir
        //unsafe - pointerlerle islemek ucun lazim olan blok 
        //{

        //    int a = 5;
        //    int* ptr = &a;

        //}
        //Dfeault olaraq unchecked olur ; Buna gore overflow olan zaman exception atmir ve overflow olan deyerin qalan hissesini return edir
        //2147483647
        //int a = int.MaxValue;
        //Console.WriteLine(a+2);

        //checked - overflow olan zaman exception atir
        //checked
        //{
        //    int a = int.MaxValue;
        //    Console.WriteLine(a + 2);
        //}


        //Deyisen 2 yere bolunur
        //1. Value Type - Stack de saxlanilir ve deyisenin ozunu saxlayir
        //values types - int,float,double,bool,char,struct,enum,Guid    
        //int  -  INT32 - 0  4 bayt
        //short - INT16 - 0  2 bayt
        //long - INT64  - 0  8 bayt
        //float - Single - 0 4 bayt
        //double - Double -0 8 bayt
        //bool - Boolean -false 1 bayt
        //char - Char - 0 1 bayt


        //2. Reference Type - Heap de saxlanilir ve deyisenin ozunu deyil, deyisenin adresini saxlayir
        //Reference types - string, class, interface, delegate, object, dynamic, array
        //reference types default olaraq null olur

        //Type of deyisenin tipini deyisir
        //3 yol var  
        //Convert.ChangeType - runtime da tip deyisir ToInt32,ToString,ToDouble
        //Parse - runtime da tip deyisir 
        //TryParse - runtime da tip deyisir ve exception atmir
        //Parse typecust zamani bir basa exception atir, TryParse ise exception atmir ve false return edir

        //int a = int.Parse("55");
        //Console.WriteLine(a);

        //int a = int.Parse("b");
        //Console.WriteLine(a);




        //string input = "b";

        //if (int.TryParse(input, out int x))
        //{
        //    Console.WriteLine(x);
        //}
        //else
        //{
        //    Console.WriteLine("Input is not a valid integer.");
        //}

        //int a = 5;
        //int b = 5;

        //Console.WriteLine(a.Equals(b));

        //Console.WriteLine(a == b);

        //Test test1 = new Test(5);
        //Test test2 = new Test(5);

        //Console.WriteLine(test1 == test2);
        //Console.WriteLine(test1.Equals(test2));


        //value typelar muqayise zamani deyre gore referans typelar ise referans gore muqayise olunur.


        //string str1 = "Hello";
        //string str2 = "Hello";

        //Console.WriteLine(str1.GetHashCode());
        //Console.WriteLine(str2.GetHashCode());


        //Console.WriteLine(str1==str2);

        //String ozunu value type kimi aparmasi
        //.net optimizasiya ucun yeni eyni deyer ramm da yeniden yaranmamasi ucunn eger 1 nece string eyni deyreden istifade edirse .net de Intern Pool adlana bir yaddas var hemen eyni deyeri gelir bura yazir ve o deyerden kim istifade edirsen hemen istifa eden deyisenler eyni referansi saxlayir
        //taki her hansi deyiskelnlik bas verse artiq hemen elemtn ucun ayri referans saxlanilir



        //int a = 10;


        //string str1 = "Hello";
        //string str2 = "Hello";
        //Console.WriteLine(str1==str2);

        //Test test1 = new Test(5);
        //Test test2 = new Test(5);
        //Console.WriteLine(test1==test2);

        Test test1 = new Test(5, "Hello");
        string demo = "Hello";

        Console.WriteLine(test1.Name.GetHashCode());
        Console.WriteLine(demo.GetHashCode());
        Console.WriteLine(test1.Name == demo);



        int a = 5;

        //if (a > 5)
        //{
        //    Console.WriteLine("Hello");
        //}
        //else if (a == 5)
        //{
        //    Console.WriteLine("World");
        //}
        //else
        //{
        //    Console.WriteLine("!");

        //}
        //while (a < 10)
        //{
        //    Console.WriteLine(a);
        //    a++;
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

    }
}