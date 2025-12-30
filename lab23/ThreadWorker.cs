using lab23;
using System;

namespace lab23
{
    public static class ThreadWorker
    {

        public static void FindLongestString(object data)
        {
            if (data is StringArrayData input)
            {
                if (input.Strings == null || input.Strings.Length == 0)
                {
                    input.LongestString = string.Empty;
                    return;
                }

                string longest = input.Strings[0];
                foreach (string s in input.Strings)
                {
                    if (s != null && s.Length > longest.Length)
                        longest = s;
                }
                input.LongestString = longest;
            }
        }
    }
}