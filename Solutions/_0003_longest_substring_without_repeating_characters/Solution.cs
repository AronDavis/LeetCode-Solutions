namespace Solutions._0003_longest_substring_without_repeating_characters
{
    public class Solution
    {
        /// <summary>
        /// The highest value ASCII code in the listed character set in 127.  We add 1 because ASCII codes start at 0.
        /// </summary>
        private const int _MAX_CHARACTERS_IN_ASCII_SET = 128;

        /// <summary>
        /// Given a string <paramref name="s"/>, find the length of the longest substring without duplicate characters.
        /// </summary>
        /// <param name="s">Consists of English letters, digits, symbols and space.  Length should be between 0 and 50,000 characters (inclusive).
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int leftPoint = 0;
            int maxLength = 0;

            Span<short?> lastSeen = stackalloc short?[_MAX_CHARACTERS_IN_ASCII_SET];

            //loop through the string
            for (short i = 0; i < s.Length; i++)
            {
                char current = s[i];
                
                //if the last time we saw the current character was at or after the left point
                if (lastSeen[current] >= leftPoint)
                {
                    //update left point to the point after we last saw the current character
                    leftPoint = lastSeen[current].Value + 1;
                }

                //update when we last saw the current character
                lastSeen[current] = i;

                //calculate the length of our current substring
                int length = i + 1 - leftPoint;

                if(length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }
    }
}