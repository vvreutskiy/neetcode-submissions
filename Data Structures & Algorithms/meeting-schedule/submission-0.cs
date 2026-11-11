/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        var byStartEnd =
            intervals.SelectMany(x => new List<(int, bool)> { (x.start, true), (x.end, false) })
                .OrderBy(x => x.Item1)
                .ToList();
        bool started = false;
        for (int i = 0; i < byStartEnd.Count; i++) {
            if (started && byStartEnd[i].Item2)
                return false;
            else
                started = byStartEnd[i].Item2;
        }
        return true;
    }
}
