using System;
using System.Drawing;

namespace Ref_OutConstructor_Static_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First task
            /*
                Bir metod yazın ki, iki tam ədədi qəbul etsin və onların yerini dəyişsin.
                Bu metodda ref açar sözündən istifadə edin. Əsas Main metodunda iki ədəd verin və
                metoddan sonra onların dəyişdiyindən əmin olun.
            */

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            ChangeVaraible(firstNumber, secondNumber);
            #endregion

            #region Second task
            /*
                Student adında bir class yaradın. Bu class-da name, surname, və age sahələri olsun.Student üçün 
                bir constructor yazın ki, bu 3 sahəni qəbul edib təyin etsin.
            */

            //var name = Console.ReadLine();
            //var surname = Console.ReadLine();
            //var age = int.Parse(Console.ReadLine());
            //Student newStudent = new Student(name,surname,age);
            #endregion


            #region Third task

            /*
                Car adında bir class yaradın. Bu class-da static bir sahə(count) olsun və hər dəfə yeni obyekt
                yaradıldıqda bu say artırılsın.Əlavə olaraq Car constructor-da bu artımı təmin edin
            */

            Car Bmw = new Car("F10","Sedan",260);
            Car Mercedec = new Car("CLS","Sedan",240);

            #endregion
        }

        static void ChangeVaraible(int first, int second)
        {
            int number = first;
            first = second;
            Console.WriteLine($"Birinci deyer {first} - ");
            second = number;
            Console.WriteLine($"Ikinci deyer {second} - ");
        }
    }
}


class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Student() { }

    public Student(string name_, string surname_, int age_)
    {
        this.Name = name_;
        this.Surname = surname_;
        this.Age = age_;
        //Console.WriteLine($"Adi: {Name} Soyadi: {Surname} Yasi: {Age}");
    }
}

class Car
{
    public static int Count { get; set; } = 0;
    public string Name { get; set; }
    public string Type { get; set; }
    public double Speed { get; set; }
    public Car() { }

    public Car(string name_ , string type_, double speed_)
    {
        this.Name= name_;
        this.Type = type_;
        this.Speed = speed_;
        Count++;
        Console.WriteLine(Name);
        Console.WriteLine(Type);
        Console.WriteLine(Speed);
        Console.WriteLine(Count);
    }
}