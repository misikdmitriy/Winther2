namespace Winther.YahooIntegration
{
    public class QueryBuilder
    {
        public string Select(string fields, string tableName, string condition)
        {
            return $"SELECT {fields} FROM {tableName} WHERE {condition}";
        }
    }
}
