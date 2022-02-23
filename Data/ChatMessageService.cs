using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace test2.Data
{
    public class ChatMessageService
    {
        private ApplicationDbContext applicationDbContext;
        private AuthenticationStateProvider authenticationStateProvider;


        public ChatMessageService(ApplicationDbContext applicationDbContext, AuthenticationStateProvider authenticationStateProvider)
        {
            this.applicationDbContext = applicationDbContext;
            this.authenticationStateProvider = authenticationStateProvider;
        }


        public List<ChatMessage> GetChatMessagesByRequestId(long requestId)
        {
           var temp = this.applicationDbContext.QueryChatMessageByRequestId(requestId);

            if (temp.Any())
            {
                return temp.ToList<ChatMessage>() ;
            }
            else
            {
                return new List<ChatMessage>();
            }
        }

        public List<ChatMessage> GetChatMessagesByCurrentUserEmail(string email)
        {
            var temp = this.applicationDbContext.QueryChatMessageByEmail(email);

            if (temp.Any())
            {
                return temp.ToList<ChatMessage>();
            }
            else
            {
                return new List<ChatMessage>();
            }
        }


        public async Task<ChatMessage> SaveChatMessage(ChatMessage chatMessage)
        {

            try
            {
                this.applicationDbContext.ChatMessages.Add(chatMessage);
                await this.applicationDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return chatMessage;

        }






        //public async Task<SitterRequest> AddSitterRequestAsync(SitterRequest sitterRequest)
        //    {


        //        try
        //        {
        //            var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
        //            var user = authState.User;

        //            sitterRequest.RequesterEmail = user.Identity.Name;
        //            this.applicationDbContext.SitterRequests.Add(sitterRequest);
        //            await this.applicationDbContext.SaveChangesAsync();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        return sitterRequest;
        //    }
    }
}
