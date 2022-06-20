class Program
{
    static void Main(string[] args)
    {
        var myTimer = new System.Timers.Timer(2000);
        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer.Elapsed += MyTimer_Elapsed1;
        myTimer.Start();
        Console.WriteLine("Press Enter to stop the Red Event");
        Console.ReadLine();
        myTimer.Elapsed -= MyTimer_Elapsed1;
        Console.ReadLine();
    }

    private static void MyTimer_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Elapsed1:{0:HH:mm:ss.fff}", e.SignalTime);
    }

    private static void MyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Elapsed:{0:HH:mm:ss.fff}",e.SignalTime);
    }
}