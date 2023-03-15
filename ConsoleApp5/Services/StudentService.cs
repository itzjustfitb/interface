using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Core.Models.BaseModel;
using ConsoleApp5.Interfaces;
using ConsoleApp5.Extensions;

namespace ConsoleApp.Core.Services.BaseService
{
    public class StudentService:IStudentService
    {
        Student[] students = { };
        public void Create()
        {

            Student student = new Student();

            Array.Resize(ref students, students.Length + 1);


            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("SurName:");
            string surname = Console.ReadLine();

            Console.WriteLine("GroupNo:");
            string groupNo = Console.ReadLine();


            while (!name.CheckAll() || !surname.CheckAll() || string.IsNullOrEmpty(groupNo))
            {

                Console.WriteLine("It has wrong,Again.");
                Console.WriteLine("Name:");
                name = Console.ReadLine();

                Console.WriteLine("SurName:");
                surname = Console.ReadLine();

                Console.WriteLine("GroupNo:");
                groupNo = Console.ReadLine();
            }
            student.Name = name;
            student.Surname = surname;
            student.GroupNo = groupNo;
            students[students.Length - 1] = student;

        }

        public void Delete()
        {
            Console.WriteLine("Enter Id");
            int Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {

                if (Id == students[i].Id)
                {
                    int index = Array.IndexOf(students, students[i]);
                    students = ArrayRemove(ref students, students.Length - 1, index);
                }
            }

        }


        public void GetById()
        {
            Console.WriteLine("Enter Id:");
            int Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {


                if (students[i].Id == Id)
                {
                    Console.WriteLine(students[i]);
                    break;
                }
                else if (i == students.Length - 1)
                {
                    Console.WriteLine("There is no student in this id");
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Empty");
            }


        }

        public void Show()
        {
            foreach (Student student in students)
            {
                if (student != null)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Now,there is no student");
            }
        }

        Student[] ArrayRemove(ref Student[] array, int newSize, int index)
        {
            Student[] newArray = new Student[newSize];
            int i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    newArray[i2] = array[i];
                    i2++;
                }
            }
            return newArray;
        }
    }
}
