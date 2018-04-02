namespace Bridge_ex_01
{
    public class FancyFormatter : IMyFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("** {0} *** {1} **", key, value);
        }
    }
}