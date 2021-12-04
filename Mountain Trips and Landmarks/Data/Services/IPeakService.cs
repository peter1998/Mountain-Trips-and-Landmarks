using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Services
{
    public interface IPeakService
    {
        Task<IEnumerable<Peak>> GetAllAsync();
        Task<Peak> GetByIdAsync(int id);

        Task AddAsync(Peak peak);
        Peak Update(int id, Peak peak);

        void Delete(int id);
    }
}
