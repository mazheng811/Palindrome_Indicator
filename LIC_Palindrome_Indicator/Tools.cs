
namespace LIC_Palindrome_Indicator
{
    public static class Tools
    {
        public static bool IsOdd(int value)
        {
            var result = value % 2;

            if (result == 0)
            {
                return false;
            }

            return true;            
        }
    }
}
