namespace CronParser;

public class CronSchedule(
    List<int> minutes,
    List<int> hours,
    List<int> daysOfMonth,
    List<int> months,
    List<int> daysOfWeek,
    List<int> year,
    string command)
{
    public List<int> Minutes { get; } = minutes;
    public List<int> Hours { get; } = hours;
    public List<int> DaysOfMonth { get; } = daysOfMonth;
    public List<int> Months { get; } = months;
    public List<int> DaysOfWeek { get; } = daysOfWeek;
    
    public List<int> Year { get; } = year;
    public string Command { get; } = command;
}