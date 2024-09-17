using Microsoft.EntityFrameworkCore;
using WebAPI_Pagination.DataAccess.Models;

namespace WebAPI_Pagination.DataAccess.Core
{
    public class AppContextFile : DbContext
    {
        public AppContextFile(DbContextOptions<AppContextFile> options) : base(options) { }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Pen", Description = "A tool for writing or drawing with ink." },
                new Item { Id = 2, Name = "Pencil", Description = "A tool for writing or drawing with graphite." },
                new Item { Id = 3, Name = "Notebook", Description = "A book of blank pages for writing notes." },
                new Item { Id = 4, Name = "Eraser", Description = "A tool for erasing pencil marks." },
                new Item { Id = 5, Name = "Ruler", Description = "A tool for measuring and drawing straight lines." },
                new Item { Id = 6, Name = "Marker", Description = "A pen with a broad tip for marking." },
                new Item { Id = 7, Name = "Highlighter", Description = "A pen for highlighting text." },
                new Item { Id = 8, Name = "Stapler", Description = "A device for fastening papers together." },
                new Item { Id = 9, Name = "Paper Clips", Description = "Small devices for holding papers together." },
                new Item { Id = 10, Name = "Scissors", Description = "A tool for cutting paper." },
                new Item { Id = 11, Name = "Glue", Description = "A substance used for sticking things together." },
                new Item { Id = 12, Name = "Tape", Description = "A strip of material used for sticking things together." },
                new Item { Id = 13, Name = "Binder", Description = "A cover for holding loose sheets of paper." },
                new Item { Id = 14, Name = "Folder", Description = "A cover for holding loose sheets of paper." },
                new Item { Id = 15, Name = "Calculator", Description = "A device for performing mathematical calculations." },
                new Item { Id = 16, Name = "Sharpener", Description = "A tool for sharpening pencils." },
                new Item { Id = 17, Name = "Whiteboard", Description = "A smooth, white surface for writing on with markers." },
                new Item { Id = 18, Name = "Chalk", Description = "A soft, white limestone used for writing on blackboards." },
                new Item { Id = 19, Name = "Blackboard", Description = "A dark surface for writing on with chalk." },
                new Item { Id = 20, Name = "Sticky Notes", Description = "Small pieces of paper with a re-adherable strip of glue on their back." },
                new Item { Id = 21, Name = "Index Cards", Description = "Small cards used for recording and storing information." },
                new Item { Id = 22, Name = "Printer", Description = "A device for printing documents." },
                new Item { Id = 23, Name = "Paper", Description = "Material for writing or printing on." },
                new Item { Id = 24, Name = "Envelope", Description = "A flat paper container for a letter or document." },
                new Item { Id = 25, Name = "Stamp", Description = "A small piece of paper that you buy and stick onto an envelope or package to pay for mailing it." },
                new Item { Id = 26, Name = "Rubber Bands", Description = "Elastic bands used for holding things together." },
                new Item { Id = 27, Name = "Push Pins", Description = "Small pins used for attaching papers to a board." },
                new Item { Id = 28, Name = "Thumbtacks", Description = "Small pins used for attaching papers to a board." },
                new Item { Id = 29, Name = "Clipboard", Description = "A small board with a clip at the top for holding papers." },
                new Item { Id = 30, Name = "Desk Organizer", Description = "A container for keeping office supplies organized." },
                new Item { Id = 31, Name = "File Cabinet", Description = "A piece of furniture used for storing files." },
                new Item { Id = 32, Name = "Label Maker", Description = "A device for printing labels." },
                new Item { Id = 33, Name = "Mouse Pad", Description = "A pad for a computer mouse to move on." },
                new Item { Id = 34, Name = "Keyboard", Description = "A device for typing on a computer." },
                new Item { Id = 35, Name = "Monitor", Description = "A screen for displaying computer output." },
                new Item { Id = 36, Name = "USB Drive", Description = "A small, portable device for storing data." },
                new Item { Id = 37, Name = "External Hard Drive", Description = "A portable device for storing large amounts of data." },
                new Item { Id = 38, Name = "Headphones", Description = "A device for listening to audio." },
                new Item { Id = 39, Name = "Speakers", Description = "Devices for playing sound." },
                new Item { Id = 40, Name = "Webcam", Description = "A camera for video conferencing." },
                new Item { Id = 41, Name = "Microphone", Description = "A device for recording or amplifying sound." },
                new Item { Id = 42, Name = "Projector", Description = "A device for projecting images onto a screen." },
                new Item { Id = 43, Name = "Screen", Description = "A surface for displaying projected images." },
                new Item { Id = 44, Name = "Router", Description = "A device for connecting to the internet." },
                new Item { Id = 45, Name = "Modem", Description = "A device for connecting to the internet." },
                new Item { Id = 46, Name = "Ethernet Cable", Description = "A cable for connecting devices to a network." },
                new Item { Id = 47, Name = "Power Strip", Description = "A strip of sockets for plugging in multiple electrical devices." },
                new Item { Id = 48, Name = "Extension Cord", Description = "A long electrical cord for extending the reach of a power outlet." },
                new Item { Id = 49, Name = "Surge Protector", Description = "A device for protecting electrical devices from power surges." },
                new Item { Id = 50, Name = "Battery Charger", Description = "A device for charging batteries." }
            );
        }
    }
}
