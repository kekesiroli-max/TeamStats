namespace TeamStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Név1", "center", 1);
            ConsoleView consoleview = new ConsoleView();
            consoleview.ShowPlayer(player1);
            consoleview.ShowMessage("Message");
        }
    }
}
