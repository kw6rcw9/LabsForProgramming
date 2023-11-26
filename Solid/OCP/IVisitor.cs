namespace OCP;

public interface IVisitor
{
    void VisitOldEmployee(OldEmployee employee);
    void VisitNewEmployee(NewEmployee employee);
}