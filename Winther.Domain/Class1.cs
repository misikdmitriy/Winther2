using System.Collections.Specialized;
using System.Text;

namespace Winther.Domain
{
    public static class NameValueCollectionExtensions
    {
        public static string ToQueryString(this NameValueCollection parameters)
        {
            var sb = new StringBuilder();

            foreach (var key in parameters.AllKeys)
            {
                sb.Append(string.Concat(key, "=", parameters[key], "&"));
            }

            return sb.Length > 0 
                ? sb.ToString(0, sb.Length - 1) 
                : string.Empty;
        }
    }
}
