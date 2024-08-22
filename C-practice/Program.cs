using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1. Hello World - การสร้างโปรแกรมแรกใน C#
        Console.WriteLine("Hello World!");

        // 2. การใช้งานตัวแปรและเงื่อนไขเบื้องต้น
        string name = "Alice";
        if (name == "Alice")
        {
            Console.WriteLine("Hello, Alice!");
        }
        else
        {
            Console.WriteLine("Who are you?");
        }

        // 3. การใช้งานลูป while และ Boolean
        bool isActive = true;
        int counter = 0;

        while (isActive)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
            if (counter >= 5)
            {
                isActive = false;
            }
        }

        // 4. การจัดการกับข้อมูล - การใช้งานตัวแปร string และตัวเลข
        string firstName = "John";
        string lastName = "Doe";
        int age = 30;
        string fullName = $"{firstName} {lastName}";

        Console.WriteLine($"Name: {fullName}, Age: {age}");

        // 5. การใช้ record type - ฟีเจอร์ใหม่ใน C# 9
        Person person = new Person("John", "Doe");
        Console.WriteLine(person);

        // 6. การใช้ Properties ในคลาส
        Car myCar = new Car { Make = "Toyota", Model = "Corolla", Year = 2020 };
        Console.WriteLine($"Car: {myCar.Make} {myCar.Model} ({myCar.Year})");

        // 7. การกรองข้อมูลในลิสต์ด้วย LINQ
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // 8. การใช้ switch statement
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Another day");
                break;
        }

        // 9. การใช้งาน string และ string interpolation
        string text = "Hello World!";
        bool containsHello = text.Contains("Hello");
        Console.WriteLine($"Contains 'Hello': {containsHello}");

        string trimmedName = $"{firstName} {lastName}".Trim();
        Console.WriteLine(trimmedName);

        // 10. การใช้ Foreach loop กับ Arrays
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 11. การใช้ LINQ กับการจัดเรียงข้อมูลและกรองข้อมูล
        var sortedEvenNumbers = from num in numbers
                                where num % 2 == 0
                                orderby num descending
                                select num;

        foreach (var num in sortedEvenNumbers)
        {
            Console.WriteLine(num);
        }

        // 12. การจัดการข้อมูลด้วย List<T>
        List<int> numberList = new List<int> { 1, 2, 3 };
        numberList.Add(4);
        numberList.Remove(2);

        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }

        // 13. การจัดการวันที่และเวลา
        DateTime today = DateTime.Now;
        Console.WriteLine($"Today is {today:MMMM dd, yyyy}");

        // 14. การอ่านและเขียนไฟล์
        string filePath = "test.txt";
        File.WriteAllText(filePath, "Hello, C#!");
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}

// ฟีเจอร์ใหม่ใน C# 9 - การใช้ record type
public record Person(string FirstName, string LastName);

// การใช้ Properties ในคลาส
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
