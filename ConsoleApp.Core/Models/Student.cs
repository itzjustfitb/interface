namespace ConsoleApp.Core.Models.BaseModel
{
    public sealed class Student:Person
    {
        public static int countStudent = 0;
        public readonly int Id;
        public Student()
        {
            countStudent++;
            Id = countStudent;
        }

        public override string ToString()
        {
            return ($"Name:{Name}; Surname:{Surname};Id:{Id};GroupNo:{GroupNo}");
        }

    }
}