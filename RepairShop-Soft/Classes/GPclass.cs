using System;

public class GPclass
{
    //generall - perpose class for project
    public static string userbar { get; set; }
    public static System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
    public GPclass()
	{
	}
    public static string getDate ()
    {
        string output = calendar.GetYear(DateTime.Now) + "/" + calendar.GetMonth(DateTime.Now) + "/" + calendar.GetDayOfMonth(DateTime.Now);
        return output;
    }
    public static string getHour()
    {
        
        string output = calendar.GetHour(DateTime.Now) + ":" + calendar.GetMinute(DateTime.Now) + ":" + calendar.GetSecond(DateTime.Now);
        return output;
    }
}
