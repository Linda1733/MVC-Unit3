using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikingLog.Models
{
    public class EFTrailRepository : ITrailRepository {
       private ApplicationDbContext context; 
       public EFTrailRepository(ApplicationDbContext ctx)
        {
            context = ctx;            
        }

        public IQueryable<Trail> Trails => context.Trails;
       
    }
}
