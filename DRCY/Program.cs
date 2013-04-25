using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRCY
{
    public class ProductionContent : DbContext
    {
        public DbSet<Episode> Episodes { get; set; }
    }

    public class Episode
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ProductionContent())
            {
                ctx.Episodes.Add(new Episode() {Id = 100, Title = "(MBC)구가의 서"});

                ctx.SaveChanges();
            }
        }
    }
}
