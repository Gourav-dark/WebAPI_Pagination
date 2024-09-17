using WebAPI_Pagination.Filter;

namespace WebAPI_Pagination.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
