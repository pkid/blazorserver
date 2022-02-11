using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace test2.Data
{
    public class SitterRequestService
    {
        private SitterRequestDbContext sitterRequestDbContext;
        private AuthenticationStateProvider authenticationStateProvider;


        public SitterRequestService(SitterRequestDbContext sitterRequestDbContext, AuthenticationStateProvider authenticationStateProvider)
        {
            this.sitterRequestDbContext = sitterRequestDbContext;
            this.authenticationStateProvider = authenticationStateProvider;
        }


        public async Task<List<SitterRequest>> GetSitterRequestsAsync()
        {
            return await this.sitterRequestDbContext.SitterRequests.ToListAsync();
        }



    


    public async Task<SitterRequest> AddSitterRequestAsync(SitterRequest sitterRequest)
        {
            

            try
            {
                var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                sitterRequest.Email = user.Identity.Name;
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
