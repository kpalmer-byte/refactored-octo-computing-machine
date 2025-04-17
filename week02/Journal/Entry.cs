public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryType;
    public void Display()
    {
        Console.WriteLine($"{_entryType}");  // Display Entry Type
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}