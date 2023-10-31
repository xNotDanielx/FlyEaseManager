using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IServiceClient
    {
        Task<string> GetAsync(string endpoint);
        Task<string> PostAsync(string endpoint, object data);
        Task<string> PutAsync(string endpoint, object data);
        Task<string> DeleteAsync(string endpoint);
    }
}
