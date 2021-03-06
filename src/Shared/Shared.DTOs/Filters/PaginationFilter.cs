namespace DN.WebApi.Shared.DTOs.Filters
{
    public abstract class PaginationFilter : BaseFilter
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string[] OrderBy { get; set; }

    }
}