namespace LeetCodeSolutions._1_two_sum
{
    public class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            //instantiate dictionary to cache values
            Dictionary<int, int> cache = new Dictionary<int, int>();

            //loop through numbers
            for (int i = 0; i < nums.Length; i++)
            {
                //store first number
                int num = nums[i];

                //get the number it needs to be paired with
                int shouldBePairedWith = target - num;

                //if we've already cached the 2nd number
                if (cache.ContainsKey(shouldBePairedWith))
                {
                    //return the two indices
                    return new int[]
                    {
                        i,
                        cache[shouldBePairedWith]
                    };
                }

                //cache number
                cache[num] = i;
            }

            //return null if we can't find a solution
            return null;
        }
    }
}
