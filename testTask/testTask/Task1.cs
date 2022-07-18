namespace testTask
{
    internal class Task1 : ITestTask
    {
        public void SolveTask()
        {
            Console.WriteLine("input x=");
            string? x = Console.ReadLine();
            Console.WriteLine("input y=");
            string? y = Console.ReadLine();
            Console.WriteLine("input z=");
            string? z = Console.ReadLine();

            if (int.TryParse(x, out int xVal) && int.TryParse(y, out int yVal) && int.TryParse(z, out int zVal))
            {
                Swap(ref xVal, ref yVal, ref zVal);
                Console.WriteLine($"x={xVal} y={yVal} z={zVal}");
            }
            else
                Console.WriteLine("invalid input");
        }

        private void Swap(ref int x,ref int y, ref int z)
        {
            (x, y, z) = (y, z, x);
        }
    }
}
