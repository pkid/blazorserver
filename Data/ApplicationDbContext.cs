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
        public DbSet<ChatMessage> ChatMessage { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public IQueryable<ChatMessage> QueryChatMessageByRequestId(long sitterRequestId)
        {
            try
            {
                return ChatMessage.Where(e => e.SitterRequestId == sitterRequestId);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("QueryChatMessageByRequestId Failed");
            }
        }
    }
}
