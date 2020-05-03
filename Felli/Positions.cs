namespace Felli
{
    public class Positions
    {
        private int[] b;
        private int[] w;
        public Positions ()
        {
            b = new int[] {3, 4, 5, 12, 13, 14};
            w = new int[] {22, 23, 24, 31, 32, 33};
        }

        public int[] GetB()
        {
            return b;
        }

        public int[] GetW()
        {
            return w;
        }
    }
}