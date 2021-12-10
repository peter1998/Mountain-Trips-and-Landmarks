using Mountain_Trips_and_Landmarks.Data.Base;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public interface IPeakService : IEntityBaseRepository<Peak>
    {
        //    Task<IEnumerable<Peak>> GetAllAsync();
        //    Task<Peak> GetByIdAsync(int id);

        //    Task AddAsync(Peak peak);
        //    Task<Peak> UpdateAsync(int id, Peak peak);
        Task<Peak> GetPeakByIdAsync(int id);
        //    Task DeleteAsync(int id);
        //}
    }
}
