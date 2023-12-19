
using Microsoft.Win32;

internal class Program
{

    static void Main(string[] args)
    {
        string? exists = (string?)Registry.GetValue(@"HKEY_CURRENT_USER\Software\MyCompany\MyApp", "LimitDate", "");

        DateTime limitDate;

        if (string.IsNullOrEmpty(exists))
        {
            limitDate = DateTime.Today.AddMonths(1);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\MyCompany\MyApp", "LimitDate", limitDate.ToString("yyyy-MM--dd"));

        }
        else
            limitDate = DateTime.Parse(exists);

        if (DateTime.Now > limitDate)
            Console.WriteLine("Купите лицензию");
        else
            Console.WriteLine("Наслаждайтесь игрой");
    }
}