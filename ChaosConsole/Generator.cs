namespace ChaosConsole
{
    public static class Generator
    {
        private const int LeftMaxValue = 120;
        private const int TopMaxValue = 30;

        public static IEnumerable<Position> Generate(int maxCombinations = 1000)
        {            
            foreach (var _ in Enumerable.Range(1, maxCombinations)) 
            {
                var left = Random.Shared.Next(LeftMaxValue);
                var top = Random.Shared.Next(TopMaxValue);                
                yield return new Position(left, top);
            }
        }
    }
}
