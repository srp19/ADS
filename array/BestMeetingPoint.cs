using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * A group of two or more people wants to meet and minimize the total travel distance.
 * You are given a 2D grid of values 0 or 1, where each 1 marks the home of someone in the group.
 * The distance is calculated using Manhattan Distance, where distance(p1, p2) = |p2.x - p1.x| + |p2.y - p1.y|.
 * Find the total distance that needs to be travelled to reach this meeting point.
 *
 * Time complexity O(m*n)
 * Space complexity O(m + n)
 *
 * https://leetcode.com/problems/best-meeting-point/
 */
namespace ADS.array
{
    public class BestMeetingPoint
    {
        public int minTotalDistance(int[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }
            List<int> vertical = new List<int>();
            List<int> horizontal = new List<int>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        vertical.Add(i);
                        horizontal.Add(j);
                    }
                }
            }

            vertical.Sort();
            horizontal.Sort();

            int size = vertical.Count / 2;
            int x = vertical[size];
            int y = horizontal[size];
            int distance = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        distance += Math.Abs(x - i) + Math.Abs(y - j);
                    }
                }
            }

            return distance;
        }

        public static void Main(String[] args)
        {
            BestMeetingPoint bmp = new BestMeetingPoint();
            int[][] grid = new int[3][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new int[5];

            }
            grid[0] = new int[5] { 1, 0, 0, 0, 1 };
            grid[1] = new int[5] { 0, 0, 0, 0, 0 };
            grid[2] = new int[5] { 0, 0, 1, 0, 0 };
            Console.WriteLine(bmp.minTotalDistance(grid));
        }
    }
}
