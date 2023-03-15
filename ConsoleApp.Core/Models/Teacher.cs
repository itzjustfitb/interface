using ConsoleApp.Core.Models.BaseModel;

public sealed class Teacher : Person
{
    public readonly int Id;
    public static int countTeacher;

    public Teacher()
    {
        countTeacher++;
        Id = countTeacher;

    }
    public override string ToString()
    {
        return ($"Name:{Name}; Surname:{Surname};Id:{Id};GroupNo:{GroupNo}");
    }
}