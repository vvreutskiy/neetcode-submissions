public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        HashSet<(int, int, int)> result = new();
        for (int firstIdx = 0; firstIdx < nums.Length - 2; firstIdx++)
        {
            var slice = nums.AsSpan(firstIdx + 1);
            int leftIdx = 0;
            int rightIdx = slice.Length - 1;
            while (leftIdx < rightIdx)
            {
                switch (nums[firstIdx] + slice[leftIdx] + slice[rightIdx])
                {
                    case > 0:
                        rightIdx--;
                        break;
                    case < 0:
                        leftIdx++;
                        break;
                    case 0:
                        List<int> sorted = [nums[firstIdx], slice[leftIdx], slice[rightIdx]];
                        result.Add((sorted[0], sorted[1], sorted[2]));
                        leftIdx++;
                        break;
                }
            }
        }
        return result.Select(x => new List<int> { x.Item1, x.Item2, x.Item3}).ToList();
    }
}
