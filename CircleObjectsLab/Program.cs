using CircleObjectsLab;

bool runProgram = true;
while (runProgram)
{

    double radius = 0;
    string area = "";
    string circumference = "";

    Console.WriteLine("Please enter the radius of a circle:");
    radius = double.Parse(Console.ReadLine());

    Circle myCircle = new Circle(radius);

    area = myCircle.CalculateFormattedArea();
    circumference = myCircle.CalculateFormattedCircumference();

    Console.WriteLine(area);
    Console.WriteLine(circumference);
    while (true)
    {
        Console.WriteLine("Would you like to find the radius and circumference of another number? y/n");
        string choice = Console.ReadLine();
        if (choice.ToLower().Trim() == "y")
        {
            break;
        }
        else if (choice.ToLower().Trim() == "n")
        {
            runProgram = false;
            break;
        }
    }
}
