namespace Binary_Tree
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Ensure nums1 is the smaller array for the binary search
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            int x = nums1.Length;
            int y = nums2.Length;
            int low = 0;
            int high = x;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                // If partitionX is 0, it means there are no elements on the left side in nums1
                // So, we use -∞ for maxLeftX
                // Similarly, if partitionX is equal to x, it means there are no elements on the right side in nums1
                // So, we use +∞ for minRightX
                int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

                // Check if we have found the correct partition
                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    // If the total length is even, the median is the average of maxLeft and minRight
                    if ((x + y) % 2 == 0)
                        return ((double)Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;

                    // If the total length is odd, the median is the max of the left side
                    return (double)Math.Max(maxLeftX, maxLeftY);
                }
                else if (maxLeftX > minRightY)
                {
                    // We are too far on the right side for partitionX, move left
                    high = partitionX - 1;
                }
                else
                {
                    // We are too far on the left side for partitionX, move right
                    low = partitionX + 1;
                }
            }

            // If we reach here, something went wrong
            throw new InvalidOperationException("The arrays are not sorted or have invalid input.");
        }
    }
}
