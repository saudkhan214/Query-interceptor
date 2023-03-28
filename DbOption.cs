using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreQuery
{
    public class DbOption
    {
        public static DbContextOptions<TestDbContext> GetOption()
        {
            return new DbContextOptionsBuilder<TestDbContext>()
        .UseSqlServer("server=DESKTOP-CIO5P2L\\SQLEXPRESS;user id=sa;password=123456789;persistsecurityinfo=True;database=Interceptor3;TrustServerCertificate=True")
        .Options;
        }
    }
}
