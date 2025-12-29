using System;

namespace lab11
{
    public enum CategoryType
    {
        IT,
        HR,
        Finance
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public double Salary { get; set; }
        public bool HasDiploma { get; set; }

        public static Employee Parse(string line)
        {
            var parts = line.Split(',');

            return new Employee
            {
                ID = int.Parse(parts[0]),
                Name = parts[1],
                Category = Enum.Parse<CategoryType>(parts[2]),
                Salary = double.Parse(parts[3]),
                HasDiploma = bool.Parse(parts[4])
            };
        }
    }
}