namespace ConsoleApp81;

public static class Management
{
    private static List<StudentCollage> _studentCollages = new();

    public static void AddStudent(string name, int Id,int year)
    {
        if (year==1)
        {
            var student = new StudentYear1(name, Id);
            _studentCollages.Add(student);
        }

        if (year==2)
        {
            var student = new StudentYear2(name, Id);
            _studentCollages.Add(student);
        }
        
    }

    public static void AddMathScore(string name,int score)
    {
        var student = _studentCollages.Find(_ => _.Name == name);
        if (student is null)
        {
            throw new Exception("student not found");
        }
        student.SetMath(score);
    }
    public static void AddfhysicsScore(string name,int score)
    {
        var student = _studentCollages.Find(_ => _.Name == name);
        if (student is null)
        {
            throw new Exception("student not found");
        }
        student.SetPhysics(score);
    }

    public static List<StudentCollage> Getinformation()
    {
        return _studentCollages;
    }
}