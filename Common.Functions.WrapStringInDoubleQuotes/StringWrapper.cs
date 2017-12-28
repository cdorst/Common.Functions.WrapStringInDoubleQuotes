namespace Common.Functions.WrapStringInDoubleQuotes
{
    public static class StringWrapper
    {
        public static string WrapInDoubleQuotes(string input)
            => $"\"{input}\"";
    }
}
