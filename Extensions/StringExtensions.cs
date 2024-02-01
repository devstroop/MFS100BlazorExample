namespace MFS100Example.Extensions
{
    public static class StringExtensions
    {
        public static string WithNALabel(this string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Trim() == "x" || value.Trim().Replace(" ", "") == "()")
            {
                return "N/A";
            }
            return value?.Replace("_", " ") ?? "N/A";
        }
    }
}
