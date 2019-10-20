using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikingLog.Models
{
    //Added Repository for Unit 4 Requirements for Collections 
    public interface ITrailRepository
    {
        IQueryable<Trail> Trails { get; }
    }
}
