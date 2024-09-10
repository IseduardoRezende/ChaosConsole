namespace ChaosConsole
{
    public struct Position
    {
        public Position(int left, int top)
        {
            Left = left;
            Top = top;
        }

        public int Left { get; set; }

        public int Top { get; set; }
    }
}
