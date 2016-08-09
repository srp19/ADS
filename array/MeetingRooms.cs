using System;

namespace ADS.array
{


	/// <summary>
	/// Date 05/01/2016
	/// @author Tushar Roy
	/// 
	/// Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei),
	/// find the minimum number of conference rooms required.
	/// 
	/// Both methods have time comlexity of nlogn
	/// Method 1 has space complexity of O(1)
	/// 
	/// https://leetcode.com/problems/meeting-rooms-ii/
	/// </summary>
	public class MeetingRooms
	{

		public class Interval
		{
			  public int start;
			  public int end;
			  public Interval()
			  {
				  start = 0;
				  end = 0;
			  }
			  public Interval(int s, int e)
			  {
				  start = s;
				  end = e;
			  }
		}

		public virtual int minMeetingRooms1(Interval[] intervals)
		{
			int[] start = new int[intervals.Length];
			int[] end = new int[intervals.Length];

			for (int i = 0; i < intervals.Length; i++)
			{
				start[i] = intervals[i].start;
				end[i] = intervals[i].end;
			}

			Array.Sort(start);
			Array.Sort(end);

			int j = 0;
			int rooms = 0;
			for (int i = 0; i < start.Length; i++)
			{
				if (start[i] < end[j])
				{
					rooms++;
				}
				else
				{
					j++;
				}
			}
			return rooms;
		}

		public virtual int minMeetingRooms(Interval[] intervals)
		{
			if (intervals.Length == 0)
			{
				return 0;
			}
			Array.Sort(intervals, (a, b) => a.start - b.start);
			//PriorityQueue<Interval> pq = new PriorityQueue<Interval>((a, b) => a.end - b.end);
			//pq.offer(intervals[0]);
			//int rooms = 1;
			//for (int i = 1; i < intervals.Length; i++)
			//{
			//	Interval it = pq.poll();
			//	if (it.end <= intervals[i].start)
			//	{
			//		it = new Interval(it.start, intervals[i].end);
			//	}
			//	else
			//	{
			//		rooms++;
			//		pq.offer(intervals[i]);
			//	}
			//	pq.offer(it);
			//}
			//return rooms;
			return 0;
		}
	}

	internal class PriorityQueue<T>
	{
	}
}