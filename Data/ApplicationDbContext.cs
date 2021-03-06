using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace test2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<SitterRequest> SitterRequests { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public IQueryable<ChatMessage> QueryChatMessageByRequestId(long sitterRequestId)
        {
            try
            {
                return ChatMessages.Where(e => e.SitterRequestId == sitterRequestId);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QueryChatMessageByRequestId Failed");
            }
        }

        public IQueryable<ChatMessage> QueryChatMessageByEmail(string email)
        {
            try
            {
                return ChatMessages.Where(e => e.FromUserId == email || e.ToUserId == email);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QueryChatMessageByEmail Failed");
            }
        }

        public IQueryable<SitterRequest> QuerySitterRequestByRequester(string requester)
        {
            try
            {
                return SitterRequests.Where(it => it.RequesterEmail == requester);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QuerySitterRequestByRequester Failed");
            }
        }

        public IQueryable<SitterRequest> QuerySitterRequestBySitter(string sitter)
        {
            try
            {
                return SitterRequests.Where(it => it.SitterEmail == sitter);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QuerySitterRequestBySitter Failed");
            }
        }

        public IQueryable<SitterRequest> QuerySitterRequestById(long id)
        {
            try
            {
                return SitterRequests.Where(it => it.Id == id);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QuerySitterRequestBySitter Failed");
            }
        }


        public IQueryable<SitterRequest> getOpenSitterRequests()
        {
            try
            {
                return SitterRequests.Where(it => it.Status == SitterRequestStatusEnum.INIT);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("getOpenSitterRequests Failed");
            }
        }


    }
}
