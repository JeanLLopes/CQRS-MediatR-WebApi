using CQRS_MediatR_WebApi.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRS_MediatR_WebApi.Web
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}