using ConsoleApp29___23._04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29___23._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            head:
            Console.WriteLine("1) Employee  Əlavə Etmək :");

            Console.WriteLine("2) İd -ə görə Employee-ni tapıb ekrana çıxarsın :");

            Console.WriteLine("3) Bütün Employeelər Ekrana çıxsın :");

            Console.WriteLine("Seciminizi daxil edin");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    if(AddEmployee()) goto head;
                    else Console.WriteLine("Emeliyyat basa catdi");
                    break;

                case 2:
                    GetById();
                    break;

                case 3:
                    Display();
                    break;

                default:
                    Console.WriteLine("Yanlis emeliyyat ");
                    break;


            }



           
        }

        static bool  AddEmployee()
        {
            CustomCollection<Employee> collection = new CustomCollection<Employee>();

            bool check = false;
            Console.Write("Ad daxil edin");
            string ad=Console.ReadLine();

            Console.Write("Soyad daxil edin");
            string soyad = Console.ReadLine();

            Console.Write("Yas daxil edin");
            int yas ;
            while (!int.TryParse(Console.ReadLine(), out yas))
            {
                Console.WriteLine("Yasinizi dogru yazin ");
                Console.Write("Tekrar daxil edin: ");
            }


            Console.Write("Maas daxil edin");
            double maas = Convert.ToDouble(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out maas))
            {
                Console.WriteLine("Dogru deyil tekrar maas daxil edin");
                Console.Write("Tekrar daxil edin: ");
            }

            Employee newemployee=new Employee(ad, soyad, yas,maas);
            collection.add(newemployee);
            Console.WriteLine("Isci elave olundu");
            Console.WriteLine("Davam etmek isteyirsiz? beli ve ya xeyr");
            string choose = Console.ReadLine();
            if(choose.ToLower()=="beli") check=true;
            if (choose.ToLower() == "xeyr") check = false;
            return check;
        }
        static void GetById()
        {
            CustomCollection<Employee> collection = new CustomCollection<Employee>();
            Console.Write("ID daxil edin");
            int id = int.Parse(Console.ReadLine());
            collection.GetById(id);
          
        }

        static void Display()
        {
            CustomCollection<Employee> collection = new CustomCollection<Employee>();
            collection.Display();
        }
    }
}
