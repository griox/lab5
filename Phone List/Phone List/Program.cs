using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace lab5
{
    internal class Phone : IComparable<Phone>
    {
        public string id {  get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string img { get; set; }
        public Phone(string id = "001", string name = "iphone", float price = 8.7f, string img = "\"\\\\Mac\\Home\\Downloads\\Apple-iPhone-14-1024x1024.webp\"")
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.img = img;

        }
        public float Cost()
        {
            if (name.CompareTo("iphone") == 0)
            {
                return 1.5f * price;
            }
            else return 1.3f * price;
        }
        public int Compare(Phone other)
        {
            return price.CompareTo(other.price);
        }
        public void display()
        {
            Console.WriteLine($"{id}, {name}, {price}, {img}");
        }
    }
    class PhoneList
    {
        List<Phone> list;
        public PhoneList()
        {
            list = new List<Phone>();
        }
        public void ReadFile()
        {
            try
            {
                FileStream f = new FileStream("\\\\Mac\\Home\\Documents\\Lab5\\Phone List\\Phone List\\readme.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;

                while ((line = rd.ReadLine()) != null)
                {
                    string id = line;
                    string name = rd.ReadLine();
                    float price = Convert.ToSingle(rd.ReadLine());
                    string img = rd.ReadLine();
                    Phone phone = new Phone(id, name, price, img);
                    list.Add(phone);
                }

                rd.Close();
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void sortbyprice()
        {
            list.Sort();
        }
        public void xuat()
        {
            foreach(Phone x in list)
            {
                x.display();
            }
        }
        public void Insert()
        {
            Console.WriteLine("nhap id cho dien thoai ");
            string id = Console.ReadLine();
            Console.WriteLine("nhap ten cho dien thoai");
            string name = Console.ReadLine();
            Console.WriteLine("nhap gia cho dien thoai");
            float price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap duong link cua anh ");
            string img = Console.ReadLine();
            Phone p = new Phone(id, name, price,img);
            list.Add(p);
        }
        public void Delete()
        {
           
                Console.Write("Enter id to delete: ");
                string id = Console.ReadLine();

                Phone phoneToRemove = list.Find(p => p.id == id);

                if (phoneToRemove != null)
                {
                    list.Remove(phoneToRemove);
                    Console.WriteLine("Phone deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Phone not found.");
                }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhoneList phoneList = new PhoneList();  
            phoneList.Insert();
            phoneList.sortbyprice();
            phoneList.xuat();
        }
    }
}
