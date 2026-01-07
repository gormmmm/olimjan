namespace ClassTasks;

public abstract class Animal: IMovableBeing
{
    public string Name { get; set; }
    
    protected decimal Weight { get; set; }
    
    protected bool Sex { get; set; }
    
    protected string Color { get; set; }
    
    public Animal()
    {
        
    }

    public void Eat(string food)
    {
        
    }

    public virtual void Move()
    {
        
    }

    public virtual void Say()
    {
        Console.WriteLine($"Base Animal: some sound");
    }

    public virtual void Wash()
    {
        
    }
}

class Dog : Animal
{
    public Dog()
    {
        Name = "Bublik";
    }

    public override void Say()
    {
        Console.WriteLine($"{Name}: Gav");
    }

    public override void Wash()
    {
        Console.WriteLine($"{Name}: Washed");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}: Moved");
    }
}

class Cat : Animal, IMovableBeing
{
    public Cat()
    {
        Name = "Pushok";
    }
    
    public override void Say()
    {
        Console.WriteLine($"{Name}: Myau");
    }
}

interface IMovableBeing
{
    void Eat(string food);
    void Move();
    void Say();
    void Wash();
}

class Monkey : IMovableBeing
{
    public void Eat(string food)
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Say()
    {
        throw new NotImplementedException();
    }

    public void Wash()
    {
        throw new NotImplementedException();
    }
}