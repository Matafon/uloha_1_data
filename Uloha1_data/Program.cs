Console.WriteLine("Napiš datum:");

string inputDate = Console.ReadLine();

string[] dateParts = inputDate.Split('.');

int year = int.Parse(dateParts[2]);
int month = int.Parse(dateParts[1]);
int day = int.Parse(dateParts[0]);

if ((year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)) && (month == 2 && day <= 29))
{
    Console.WriteLine("Datum existuje.");
}
else if (month >= 1 && month <= 12 && day >= 1 && day <= DateTime.DaysInMonth(year, month))
{
    Console.WriteLine("Datum existuje.");
}
else
{
    Console.WriteLine("Datum neexistuje.");
}