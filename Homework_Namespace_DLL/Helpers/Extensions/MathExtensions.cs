
namespace Homework_Namespace_DLL.Helpers.Extensions
{
    internal static class MathExtensions
    {
        public static int SumOfNums(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static double PowerOfNums(this int a,int b)
        {
            return Math.Pow(a, b);
        }

        public static int MultiplicationOfNums(this int[] nums)
        {
            int multiple = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                multiple *= nums[i];
            }
            return multiple;
        }

    }
}
