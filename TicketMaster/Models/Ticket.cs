using System.ComponentModel.DataAnnotations;

namespace TicketMaster.Models
{
    public class Ticket
    {
        private DateTime ticketCreationTime;

        public int Id { get; set; }
        
        public string TicketBody { get; set; }
        
        public DateTime TicketTimeToFinish { get; set; }

        public DateTime TicketCreationTime { get => ticketCreationTime; set => ticketCreationTime = DateTime.Now; }

        public Ticket()
        {
            TicketCreationTime = DateTime.Now;
        }
    }
}
