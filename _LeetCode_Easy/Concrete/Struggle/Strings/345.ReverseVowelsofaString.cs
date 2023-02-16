namespace _LeetCode_Easy.Concrete.Struggle.Strings
{
    public class ReverseVowelsofaString
    {
        // Good solution
        public static string ReverseVowels(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            var sToArray = s.ToCharArray();
            var wovels = "aAeEoOiIuU";

            while (left < right)
            {
                // I increase the left index if the element is element is not a wovel
                if (wovels.IndexOf(sToArray[left]) == -1)
                {
                    left++;
                }
                // I increase the right index if the element is element is not a wovel
                else if (wovels.IndexOf(sToArray[right]) == -1)
                {
                    right--;
                }
                // If above if's are false I am ready to swap the wovels.
                else
                {
                    var temp = sToArray[left];
                    sToArray[left] = sToArray[right];
                    sToArray[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(sToArray);
        }

        // Fail
        // I tried to avoid using .Contains or .IndexOf but I ran into spaghetti code and I had troubles with the length
        // I think it would be easier to do an extension method to mimic indexOf rather than doing this.
        public static string ReverseVowels1(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            var sToArray = s.ToCharArray();
            var wovels = "aAeEoOiIuU";

            while (left < right)
            {
                var leftHasVowel = false;
                while (left < s.Length / 2)
                {
                    for (int k = 0; k < wovels.Length; k++)
                    {
                        if (sToArray[left] == wovels[k])
                        {
                            leftHasVowel = true;
                            break;
                        }
                    }
                    if (!leftHasVowel) break;
                    left++;
                }
                var rightHasVowel = false;
                while (right > (s.Length - 1) / 2)
                {
                    for (int k = 0; k < wovels.Length; k++)
                    {
                        if (sToArray[right] == wovels[k])
                        {
                            rightHasVowel = true;
                            break;
                        }
                    }
                    if (rightHasVowel) break;
                    right--;
                }

                if (rightHasVowel && leftHasVowel)
                {
                    var temp = sToArray[left];
                    sToArray[left] = sToArray[right];
                    sToArray[right] = temp;
                    left++;
                    right--;
                    leftHasVowel = false;
                    rightHasVowel = false;
                }
            }

            return new string(sToArray);
        }
    }
}