﻿using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student st = new Student("Ali");
            int sum = 1;
            for (int i = 1; i <= 6; i++)
            {
                sum *= i;
            }
            Console.WriteLine("Sum = " + sum);
			ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "ls", Arguments = "-l", };
			ProcessStartInfo startInfo2 = new ProcessStartInfo() { FileName = "grep", Arguments = "'.cs'", };
			Process proc = new Process() { StartInfo = startInfo, };
			proc.Start();
        }
    }
    
    public class Person {
        public string name;
        public Person(string n) {
            name = n;
            Console.WriteLine("Person Constructor!");
        }
        
        
    }

    public class Student : Person {
        public Student(string n) : base(n) {
            Console.WriteLine("Student Constructor!");
        }
    }
}
