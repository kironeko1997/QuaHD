namespace QuaHD.Mvc.Areas.Admin.Models
{
    public class Page<T> : List<T>
    {
        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public Page()
        {

        }

        public Page(List<T> items, SearchModel searchModel)
        {
            PageIndex = searchModel.PageIndex;
            TotalPages = (int)Math.Ceiling(items.Count / (double)searchModel.PageSize);
            items = items.Skip((searchModel.PageIndex - 1) * searchModel.PageSize).Take(searchModel.PageSize).ToList();
        }
    }
}
