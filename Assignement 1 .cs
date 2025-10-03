1. DRY Example (Logging)
// ❌ Bad (repeated code)
public void LogError(string message) => Console.WriteLine($"ERROR: {message}");
public void LogWarning(string message) => Console.WriteLine($"WARNING: {message}");
public void LogInfo(string message) => Console.WriteLine($"INFO: {message}");

// ✅ Good (DRY applied)
public enum LogLevel { Error, Warning, Info }

public void Log(string message, LogLevel level)
{
    Console.WriteLine($"{level.ToString().ToUpper()}: {message}");
}

2. KISS Example (Process numbers)
// ❌ Bad (too many nested ifs)
public void ProcessNumbers(int[] numbers)
{
    if (numbers != null)
    {
        if (numbers.Length > 0)
        {
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

// ✅ Good (KISS applied)
public void ProcessNumbers(int[] numbers)
{
    if (numbers == null || numbers.Length == 0) return;

    foreach (var number in numbers)
        if (number > 0)
            Console.WriteLine(number);
}

3. YAGNI Example (User class)
// ❌ Bad (too many unused methods)
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public void SaveToDatabase() { }
    public void SendEmail() { }
    public void PrintAddressLabel() { }
}

// ✅ Good (YAGNI applied)
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}