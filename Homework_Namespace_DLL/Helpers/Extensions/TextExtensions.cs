
namespace Homework_Namespace_DLL.Helpers.Extensions
{
    internal static class TextExtensions
    {
        public static int GetLength(this string str)
        {
            return str.Length;
        }

        public static bool CheckCharInText(this string text,char letter)
        {
            return text.Contains(letter);
        }

        public static int CountOfCharInText(this string text, char letter)
        {
            return text.ToArray().Where(m=>m==letter).Count();

            //int count = 0;

            //for(int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == letter)
            //    {
            //        count++;
            //    }
            //}
            //return count;
        }
    }
}
