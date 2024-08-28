namespace Us.Alburt.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmptyOrWordNull(this string value)
        {
            if (string.IsNullOrEmpty(value)) return true;

            return value.ToLower().Trim() == "null";
        }
    }
}
