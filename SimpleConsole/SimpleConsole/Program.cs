namespace SimpleConsole;

class Program
{
    void Main(string[] args)
    {
        // 1. Выведи подсказку пользователю:
        //    Попроси ввести список задач в формате: Название:Приоритет
        //    Пример ввода: "Покупки:3 Уборка:1 Работа:5 Звонок_маме:2"
        Console.WriteLine("Enter string with list of tasks separated by spaces like 'Walk:4 Eat:9 Do_Homework:1'");
        
        // 2. Считай одну строку текста с консоли.
        var input = Console.ReadLine();

        // 3. Разбей введённую строку на отдельные элементы по пробелу.
        //    Каждый элемент — это одна задача.
        var output = input.Split(' ');
        // foreach (var value in output)
        // {
        //     Console.WriteLine(value);  
        // }
        
        // 4. Создай пустую коллекцию List<TaskItem>.
        var tasks = new List<TaskItem>();
        
        // 5. Пройди по каждому элементу в цикле:
        //    - Разбей элемент по ':' чтобы отделить название от приоритета.
        //    - Создай новый объект TaskItem.
        //    - Заполни поля Name и Priority.
        //    - Добавь объект в коллекцию.
        foreach (var value in output)
        {
            // sleep - 0
            // 1 - 1
            var dividedValue = value.Split(':');
            var task = new TaskItem();
            task.Name = dividedValue[0]; // sleep
            task.Priority = int.Parse(dividedValue[1]); // 1
            
            tasks.Add(task);
        }

        // 6. Вызови метод CalculateStatistics и передай туда список задач.
        var tasksStatResult = CalculateStatistics(tasks);

        // 7. Вызови метод PrintStatistics и передай туда результат посчитанной статистики
        //    Этот метод должен вывести:
        //      - общее количество задач
        //      - количество задач с высоким приоритетом
        //      - количество задач с низким приоритетом
        //      - название самой важной задачи
        //    Используй Console.WriteLine для вывода информации.
    }

    private StatisticsResult CalculateStatistics(List<TaskItem> tasks)
    {
        //    Внутри метода ты должен:
        //      * подсчитать количество задач с высоким приоритетом (3 и выше)
        //      * подсчитать количество задач с низким приоритетом (2 и ниже)
        //      * найти задачу с максимальным приоритетом
        //      * вернуть результаты
        int i = 0;
        int amountHighPriority = 0;
        int amountLowPriority = 0;
        foreach(var task in tasks)
        {
            if (task.Priority >= 3)
            { 
                amountHighPriority++; // увеличить на 1
            }
            else
            { 
                amountLowPriority++; // увеличить на 1
            }
        }
        
        var maxValue = tasks.Max(task => task.Priority);

        return new StatisticsResult()
        {
            AmountHighPriority = amountHighPriority, 
            AmountLowPriority = amountLowPriority,
            MaxValuePriority = maxValue
        };
    }
}

class TaskItem
{
    public string Name;
    public int Priority; 
}

class StatisticsResult
{
    public int AmountHighPriority;
    public int AmountLowPriority;
    public int MaxValuePriority;
}