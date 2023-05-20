namespace Main.Algorithms
{
    public class Binary_search
    {
        private int[] array;

        private int low;
        private int high;

        private int item;

        public Binary_search(int[] array, int item)
        {
            this.array = array;
            this.item = item;

            low = 0;
            high = array[array.Length - 1];
        }

        public int Search()
        {
            while (low <= high)
            {
                var mid = (low + high) / 2;

                var guess = array[mid];

                if (guess == item)
                    return array[mid];

                else if (guess > item)
                    high = mid - 1;

                else
                    low = mid + 1;
            }

            return 0;
        }
    }
}
