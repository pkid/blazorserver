using System;
namespace test2.Data
{
    public class SitterRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Description { get; set; }
        public string RequesterEmail { get; set; }
        public string SitterEmail { get; set; }
        public string Image { get; set; }
        public SitterRequestStatusEnum Status { get; set; }
    }
}
