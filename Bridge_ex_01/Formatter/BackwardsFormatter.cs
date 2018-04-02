using System.Linq;

namespace Bridge_ex_01
{
    public class BackwardsFormatter : IMyFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }
}