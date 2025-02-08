
using DE.Infrastructure.HTTP.Models;

namespace DE.Infrastructure.HTTP
{
    public interface IHttpService : IDisposable
    {
        Response ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}

