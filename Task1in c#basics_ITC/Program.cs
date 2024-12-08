#region Print name ,age , favorite hoppy 
string myName = " Rawan Alaa";
int myAge = 22;
string myFavooriteHobby = "Reading books ";
Console.WriteLine($" Myname is {myName}");
Console.WriteLine($"  myAge is {myAge}");
Console.WriteLine($" myFavooriteHobby is {myFavooriteHobby}");
#endregion

#region Declare and assigned
int myId;
myId = 1;
double height;
height = 155.5;
bool single;
single = true;
string mood;
mood = "I'm mad ";

Console.WriteLine( $" MyId is {myId}   , myHieght{height}  , " +
    $"Statues is Single?  {single}  and my current mood is {mood} " );

#endregion

#region converts a temorature 
double celsiusTemperature = 18;
double fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;

#endregion

#region Mathmatical operation 
Console.Write("Enter first number ");
double num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number ");
double num2 = int.Parse(Console.ReadLine());
Console.WriteLine($" operation ={num1+num1}");
Console.WriteLine($"subtractionoperation ={num1 - num2}");
Console.WriteLine($"Maliplcation operation ={num1 * num2}");
Console.WriteLine($"division operation ={num1 / num2}");
#endregion

#region calculates the area of a rectangle. chechs if it's a square

Console.Write("Enter the length of the rectangle: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter the width of the rectangle: ");
double width = double.Parse(Console.ReadLine());
if (length == width)
{
    Console.WriteLine(" this is a Square ");
}

double area = length* width;
Console.WriteLine($"The area of the rectangle is: {area}");
#endregion

#region  checks if it is even or odd. 
Console.Write("Please enter the number : ");
int inputNumber=int.Parse(Console.ReadLine());
if (inputNumber % 2 == 0)
{
    Console.WriteLine($"the number{inputNumber} is an even number ");
}
else
{
    Console.WriteLine($"the number{inputNumber} is an odd number "); ;
}
#endregion

#region prompts the user to enter their age
Console.Write( "Please Enter your Age : " );
int Age=int.Parse(Console.ReadLine());
if (Age <=0 )
{
    Console.WriteLine("your Age sould be a positive number!!");
}
else
if (Age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}
#endregion

#region Score system
Console.WriteLine("Please Enter a score betweem (0-100)");
double Score =double.Parse(Console.ReadLine()); 
 if (Score <0 || Score >100  )
{
    Console.WriteLine("the score you inter is not in the range between (0-100)");
}
 else
    if (Score >=90 && Score<=100)
{
    Console.WriteLine("your grase is Between (90-100) : A");
}
 else if (Score >=70 && Score < 80)
{
    Console.WriteLine("your grase is Between (70-79) : c");
}
else if (Score >= 60 && Score < 69)
{
    Console.WriteLine("your grase is Between (60-69) : B");
}
 else
{
    Console.WriteLine("your grase is below 60: F");
}
#endregion

#region checks if number is positive, negative
Console.Write("Please enter the number : ");
int Number = int.Parse(Console.ReadLine());
if (inputNumber <0)
{
    Console.WriteLine($"the number{Number} is a negative number ");
}
else
{
    Console.WriteLine($"the number{Number} is a positive  number "); ;
}

#endregion

