using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test2.Data
{
    public class SitterRequestService
    {
        private SitterRequestDbContext sitterRequestDbContext;

        public SitterRequestService(SitterRequestDbContext sitterRequestDbContext)
        {
            this.sitterRequestDbContext = sitterRequestDbContext;
        }


        public async Task<List<SitterRequest>> GetSitterRequestsAsync()
        {
            return await this.sitterRequestDbContext.SitterRequests.ToListAsync();
        }

        public async Task<SitterRequest> AddSitterRequestAsync(SitterRequest sitterRequest)
        {
            try
            {
                this.sitterRequestDbContext.SitterRequests.Add(sitterRequest);
                await this.sitterRequestDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return sitterRequest;
        }
    }
}
