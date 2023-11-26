namespace OCP;

public abstract class Employee
{
    public abstract string Name { get;  }
    public abstract string Position { get; }
    public abstract void Accept(IVisitor visitor);
    


}