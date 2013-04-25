using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DRCY
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ContentDataContext())
            {
                foreach (var episode in ctx.Episodes)
                    Console.WriteLine(episode.Title);
            }
        }
    }
}
