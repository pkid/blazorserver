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
        private ApplicationDbContext applicationDbContext;
        private AuthenticationStateProvider authenticationStateProvider;


        public SitterRequestService(ApplicationDbContext applicationDbContext, AuthenticationStateProvider authenticationStateProvider)
        {
            this.applicationDbContext = applicationDbContext;
            this.authenticationStateProvider = authenticationStateProvider;
        }


        public async Task<List<SitterRequest>> GetSitterRequestsAsync()
        {
            return await this.applicationDbContext.SitterRequests.ToListAsync();
        }



    


    public async Task<SitterRequest> AddSitterRequestAsync(SitterRequest sitterRequest)
        {
            

            try
            {
                var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                sitterRequest.RequesterEmail = user.Identity.Name;
                this.applicationDbContext.SitterRequests.Add(sitterRequest);
                await this.applicationDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return sitterRequest;
        }
    }
}
