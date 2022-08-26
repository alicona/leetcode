namespace _448.FindAllNumbersDisappearedInArray
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums) 
        {
            var missingNumbers = new List<int>();

            for (int i = 1; i <= nums.Count(); i++)
            {
                if(!nums.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            return missingNumbers;
        }
    }
}

