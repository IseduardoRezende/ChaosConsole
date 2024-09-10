namespace ChaosConsole
{
    public static class Designer
    {
        public static void Design(IEnumerable<Position> positions, char symbol = '*', int millisecondsToDraw = 30)
        {
            if (positions == null || !positions.Any()) 
                return;

            positions = Random.Shared.GetItems(positions.ToArray(), positions.Count()).Distinct();
            var consoleColors = GetConsoleColors().ToArray();

            foreach (var position in positions) 
            {
                Console.SetCursorPosition(position.Left, position.Top);
                Console.ForegroundColor = Random.Shared.GetItems(consoleColors, length: 1).First();
                Thread.Sleep(millisecondsToDraw);
                Console.Write(symbol);                            
            }

            Stop();
        }
        
        private static void Stop()
        {
            Console.ReadLine();
            Console.ResetColor();
            Thread.Sleep(millisecondsTimeout: 100);
            Console.Clear();
        }
        
        private static IEnumerable<ConsoleColor> GetConsoleColors()
        {
            foreach (var consoleColor in Enum.GetValues<ConsoleColor>()) 
                yield return consoleColor;            
        }
    }
}
