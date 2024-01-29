using ChallengeApp;

var employee1 = new Employee("Marcin", "Kowalski", 28);
var employee2 = new Employee("Magda", "Wróbel", 20);
var employee3 = new Employee("Dawid", "Kowalski", 40);


employee1.AddScore(1);
employee1.AddScore(6);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(9);

employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(0);
employee3.AddScore(2);
employee3.AddScore(9);




List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3,
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najlepszy pracownik to:" + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "lat" + " " + employeeWithMaxResult.Age + " " + "z wynikiem:"+ maxResult);





