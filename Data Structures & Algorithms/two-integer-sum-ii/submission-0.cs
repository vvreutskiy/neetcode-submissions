public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        int leftIdx = 0;
        int rightIdx = numbers.Length - 1;
        while(leftIdx != rightIdx)
        {
            
            switch (numbers[leftIdx] + numbers[rightIdx])
            {
                case var sum when sum > target:
                    rightIdx--;
                    break;
                case var sum when sum < target:
                    leftIdx++;
                    break;
                default:
                    return [leftIdx + 1, rightIdx + 1];
            }
        }
        throw new ArgumentException("ololo");
    }
}
