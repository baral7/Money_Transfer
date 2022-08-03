using Microsoft.EntityFrameworkCore;

namespace MoneyTransfer.Models
{
    public class Dbcontextclass:DbContext
    {
        public Dbcontextclass(DbContextOptions<Dbcontextclass> option) : base(option)
        {

        }


    }
    
}
