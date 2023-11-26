// Реализуйте класс "Сотрудник" с методами "Рассчитать зарплату"
// и "Распечатать отчет". Убедитесь, что класс соответствует
// принципу OCP (Open/Closed Principle).

using OCP;

Employee employee = new NewEmployee("Frank", "Code");
Employee employee2 = new OldEmployee("George", "Leader", "3 years", "Project`s done");
employee.Accept(new Report());
employee.Accept(new Salary());
employee2.Accept(new Report());
employee2.Accept(new Salary());