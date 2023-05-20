namespace Main.Algorithms
{
    public class Selection_sort
    {
        private List<int> NoSortList = new();
        private List<int> SortList = new();
        
        public Selection_sort(List<int> NoSortList) => this.NoSortList = NoSortList;

        public List<int> SelectionSort()
        {
            while (NoSortList.Count > 0)
            {
                var addSmallInt = FindSmallestIndex();

                SortList.Add(addSmallInt);
            }

            return SortList;
        }

        private int FindSmallestIndex()
        {
            var index = 0;
            var smallInt = NoSortList[0];

            for(int i = 0; i < NoSortList.Count; i++)
            {
                if (NoSortList[i] < smallInt)
                {
                    index = i;
                    smallInt = NoSortList[i];
                }
            }

            NoSortList.RemoveAt(index);

            return smallInt;
        }
    }
}
