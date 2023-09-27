using System.Numerics;

namespace Codility_BinaryGap
{
    public static class Solution
    {
        public static int BinarySolution(int N)
        {
            var binaryNumber = Convert.ToString(N, 2);
            var zeroCounts = new List<int>();
            var positions = binaryNumber.Select((character, index) => new { character, index })
                                        .Where(item => item.character == '1')
                                        .Select(item => item.index)
                                        .ToList();

            for (var i = 0; i < positions.Count - 1; i++)
            {
                int start = positions[i];
                var end = positions[i + 1];

                int zeroCount = end - start - 1;

                if (zeroCount > 0)
                {
                    zeroCounts.Add(zeroCount);
                }
            }

            return zeroCounts.Any() ? zeroCounts.Max() : 0;
        }

        internal static string GetBinaryRepresentation(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
