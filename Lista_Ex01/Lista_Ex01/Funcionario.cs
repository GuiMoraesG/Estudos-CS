using System;

namespace Lista_Ex01
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Aumento(int percent)
        {
            Salary = Salary + (Salary * percent / 100);
        }
    }
}
