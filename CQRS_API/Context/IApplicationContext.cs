using CQRS_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRS_API.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}