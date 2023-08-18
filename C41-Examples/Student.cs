using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C41_Examples;

internal class Student {

    public static int NextId { get; set; } = 1;

    public int Id { get; set; }
    public string Name { get; set; } // Property
    public string State { get; set; }

    public static void Print(string message) {
        Console.WriteLine(message);
    }

    public void ChangeName(string newName = "New Student") {
        Name = newName;
    }
    public void ChangeName(string firstName, string lastName) {
        Name = $"{firstName} {lastName}";
    }

    public Student(string Name) : this(Name, "OH") {

    }
    public Student(string Name = "New Student", string State = "OH") {
        this.Id = NextId++;
        this.Name = Name;
        this.State = State;
    }
}
