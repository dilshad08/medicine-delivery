namespace Common.Models
{
    public class PagedResultModel<T>
    {
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }

        public PagedResultModel(int totalCount, IEnumerable<T> items)
        {
            TotalCount = totalCount;
            Items = items;
        }
    }
}