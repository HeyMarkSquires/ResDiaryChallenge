// See https://aka.ms/new-console-template for more information
namespace ResDiary
{
    public class ResDiaryClass
    {

        static public void Main(String[] args)
        {
            GroupArrayElements(new List<int> { 1, 2, 3, 4, 5 }, 3);
        }

        /// <summary>
        /// This method splits a given array a given number of ways
        /// </summary>
        /// <param name="array">The array that will be split</param>
        /// <param name="split">The number of ways the method will be split</param>
        /// <returns>A 2D array that contains all the arrays that the original array was split into.
        /// It will return the empty array if the split is 0 or lower.</returns>
        public static List<List<int>> GroupArrayElements(List<int> array, int split)
        {
            List<List<int>> result = new List<List<int>>();
            //Prevents the code from splitting it into impossible chunks
            if (split > 0)
            {
                //Find the max size of our various chunks
                double size = Math.Ceiling((double)array.Count / split);
                //Iterate through elements and create arrays for the resulting 2D array
                List<int> list = new List<int>();
                foreach (int i in array)
                {
                    list.Add(i);
                    if (list.Count == size)
                    {
                        result.Add(list);
                        list = new List<int>();
                    }
                }
                //If there is a remainder at the end, add that to the end of the resulting 2D array
                if (list.Count > 0)
                {
                    result.Add(list);
                }
            }


            return result;

        }
    }

}