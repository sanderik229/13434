class TextTypingGame
{
    private static string textToType = "Ваш текст для набора"; // Замените текстом для набора
    private static string userInput = "";
    private static bool gameActive = true;

    public static void StartGame()
    {
        Console.Clear();
        Console.WriteLine($"Введите ваше имя:");
        string userName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Печатайте текст:\n");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Thread timerThread = new Thread(TimerThread);
        timerThread.Start();
    }
