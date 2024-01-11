namespace ConsoleApp81;

public class StudentCollage : STudent
{
    protected StudentCollage(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public string Name { get; set; }
    public int Id { get; set; }
    public int Math { get; private set; }
    public int Physics { get; private set; }

    public virtual void SetMath(int math)
    {
        if (math<0 || math>20)
        {
            throw new Exception("wrong point");
        }

        Math = math;
    }

    public virtual void SetPhysics(int physics)
    {
        if (physics<0 || physics>20)
        {
            throw new Exception("wrong point");
        }

        Physics = physics;
    }
}