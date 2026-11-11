public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int buyIdx = 0;
        int lastBuyPrice = int.MaxValue;
        int sellIdx = 0;
        int lastSellPrice = int.MinValue;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < lastBuyPrice) {
                buyIdx = i;
                sellIdx = i;
                lastBuyPrice = prices[i];
            } else if (prices[i] > lastSellPrice) {
                sellIdx = i;
                var profit = prices[sellIdx] - prices[buyIdx];
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        return maxProfit;
    }
}
