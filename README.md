# Модуль 02 – Основные принципы проектирования  
**Курс:** Application Design Patterns  
**Тема:** DRY, KISS, YAGNI  

---

## Обзор
В этом задании показано, как улучшить качество кода с помощью трёх принципов:  

- **DRY (Don’t Repeat Yourself / Не повторяйся)** → убираем дублирование  
- **KISS (Keep It Simple, Stupid / Делай проще)** → упрощаем логику  
- **YAGNI (You Ain’t Gonna Need It / Не делай лишнего)** → не добавляем ненужное  

---

## Примеры

### DRY
```csharp
// До
public void LogError(string msg) => Console.WriteLine($"ERROR: {msg}");
public void LogWarning(string msg) => Console.WriteLine($"WARNING: {msg}");

// После
public enum LogLevel { Error, Warning, Info }
public void Log(string msg, LogLevel level) =>
    Console.WriteLine($"{level.ToString().ToUpper()}: {msg}");
KISS
csharp
Copy code
// До
if (numbers != null) if (numbers.Length > 0) foreach (var n in numbers) if (n > 0) Console.WriteLine(n);

// После
if (numbers == null || numbers.Length == 0) return;
foreach (var n in numbers) if (n > 0) Console.WriteLine(n);
YAGNI
csharp
Copy code
// До
public class User { public string Name; public string Email; public string Address;
  public void SaveToDatabase() { } public void SendEmail() { } }

// После
public class User { public string Name; public string Email; }
