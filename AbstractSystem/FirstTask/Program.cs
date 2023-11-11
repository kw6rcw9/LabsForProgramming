using AbstractSystem;

List<Employee> employees = new List<Employee>()
{
    new Admin(100000),
    new Manager(80000),
    new Worker(60000)
};

foreach (Employee employee in employees)
{
    employee.CalculateSalary();
}
