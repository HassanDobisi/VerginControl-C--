namespace VERGINCONTROL 
{
    public class functions
    {
        public string TakeGradeByPercentage(percentage)
        {
            if (percentage>=90 && percentage<=100)
            return "A+";
            else if (percentage>=80 && percentage <=90)
            return "B+";
        }
    }
}
