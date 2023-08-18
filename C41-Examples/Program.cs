
using C41_Examples;

Student.Print("This is a static method display");

//var greg = new Instructor();

var david = new Student("David");
Console.WriteLine($"Id [{david.Id}], Name is [{david.Name}] State is [{david.State}] ");

var megan = new Student("Megan");

var tony = new Student();
tony.Name = "Tony";
tony.State = "AZ";
tony.ChangeName("Anthony");

Console.WriteLine($"Students are {megan.Name} and {tony.Name}");



Console.WriteLine($"Id [{megan.Id}], Name is [{megan.Name}] State is [{megan.State}] ");
Console.WriteLine($"Id [{tony.Id}], Name is [{tony.Name}] State is [{tony.State}] ");

















/* Previous examples
for(var idx = 1; idx <= 30; idx++) {

    if(idx % 3 == 0 && idx % 5 == 0) {
        Console.Write($"FIZZBUZZ ");
        continue;
    }
    if(idx % 3 == 0) {
        Console.Write($"FIZZ ");
        continue;
    }
    if(idx % 5 == 0) {
        Console.Write($"BUZZ ");
        continue;
    }
    Console.Write($"{idx} ");

}
Console.WriteLine("\nDone...");



var stateCode = "OH";
var stateName = "";

// switch expression
stateName = stateCode switch {
    "OH" => "Ohio",
    "KY" => "Kentucky",
    "IN" => "Indiana",
    _ => "I don't know"
};

// switch statement
switch(stateCode) {
    case "OH":
        stateName = "Ohio";
        break;
    case "KY":
        stateName = "Kentucky";
        break;
    case "IN":
        stateName = "Indiana";
        break;
    default:
        stateName = "I don't know";
        break;
}



int i = 1;
while(i <= 25) {

    if(i % 2 == 1) { 
        Console.WriteLine($"{i} cubed is {i * i * i}");
    }
    i += 2;
}



 
int[] nbrs = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
}; 

var MaxNbr = int.MinValue;
var MinNbr = int.MaxValue;
var Sum = 0;

foreach(var nbr in nbrs) {
    if(nbr > MaxNbr) {
        MaxNbr = nbr;
    }
    if(nbr < MinNbr) {
        MinNbr = nbr;
    }
    //Sum = Sum + nbr;
    Sum += nbr;
}
Console.WriteLine($"Max is {MaxNbr} and Min is {MinNbr}");
Console.WriteLine($"Average is {Sum / nbrs.Length}");
*/

