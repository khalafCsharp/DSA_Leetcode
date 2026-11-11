public class Solution 
{
    public string LongestCommonPrefix(string[] strs)
    {
         if (strs.Length <= 0)
    {
        return "";
    }

    StringBuilder commonPrefix = new StringBuilder(strs[0]);

    for (int i = 1; i < strs.Length; i++)
    {
        string currentItem = strs[i];
       
        for (int x = 0; x < commonPrefix.Length; x++)
        {
            if (x >= currentItem.Length || commonPrefix[x] != currentItem[x])
            {
                commonPrefix.Length = x;
                break;
            }
        }
    }
    return commonPrefix.ToString();
    }
}








