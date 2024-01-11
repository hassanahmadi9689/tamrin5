// See https://aka.ms/new-console-template for more information


using ConsoleApp81;

while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}
static void Run()
{var Option = GetNumberFromUser("Choose option:\n" +
                                "1.Add Student\n" +
                                "2.Add Math score\n" +
                                "3.Add physics score\n" +
                                "0.exit");
    switch (Option)
    {
        case 1:
        {
            var year = GetNumberFromUser("choose:\n" +
                                         "1=year1\n" +
                                         "2=year2");
            var name = GetValidStringFromUser("enter name of student :");
            var id = GetNumberFromUser("enter id :");
            Management.AddStudent(name,id,year);
            break;
        }
        case 2:
        {
            var name = GetValidStringFromUser("enter name :");
            var score = GetNumberFromUser("enter score :");
            Management.AddMathScore(name,score);
            break;
        }
        case 3:
        {
            var name = GetValidStringFromUser("enter name :");
            var score = GetNumberFromUser("enter score :");
            Management.AddfhysicsScore(name, score);
            break;
        }
        case 4:
        {
            foreach (var student in Management.Getinformation())
            {
                
                Console.WriteLine($"name:{student.Name} - id:{student.Id} - score math:{student.Math} - score physics:{student.Physics} ");
            }
            break;
        }
        
        
    }
    
}
static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}