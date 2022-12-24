using VERGINCONTROL;

// take the percentage of the student
var Functions = new functions();

Console.Write("Enter your percentage :");

var percentage = Convert.ToInt32(Console.ReadLine());

var grade = Functions.TakeGradeByPercentage(percentage);

//Print Grade for the student
Console.WriteLine($"Student Grade : {grade}");

