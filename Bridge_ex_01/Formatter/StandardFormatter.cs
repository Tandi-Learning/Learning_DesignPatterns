namespace Bridge_ex_01
{
    public class StandardFormatter : IMyFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}