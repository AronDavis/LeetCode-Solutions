namespace Solutions._0728_self_dividing_numbers
{
    public class Solution
    {
        private bool _isSelfDividing(in int number)
        {
            int current = number;

            //checking if current > 1 let's us skip the calculation for the last digit if it is 1
            while(current > 1)
            {
                //get the last digit
                int digit = current % 10;

                switch (digit)
                {
                    case 0:
                        //zeros are not allowed
                        return false;
                    case 1:
                        //never need to check 1
                        break;
                    default:
                        if (number % digit != 0)
                        {
                            return false;
                        }
                        break;
                }

                //drop the last digit
                current /= 10;
            }

            return true;
        }

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> selfDividingNumbers = new List<int>();

            for(int number = left; number <= right; number++)
            {
                if(_isSelfDividing(number))
                {
                    selfDividingNumbers.Add(number);
                }
            }

            return selfDividingNumbers;
        }
    }
}