using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_Pagination.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A tool for writing or drawing with ink.", "Pen" },
                    { 2, "A tool for writing or drawing with graphite.", "Pencil" },
                    { 3, "A book of blank pages for writing notes.", "Notebook" },
                    { 4, "A tool for erasing pencil marks.", "Eraser" },
                    { 5, "A tool for measuring and drawing straight lines.", "Ruler" },
                    { 6, "A pen with a broad tip for marking.", "Marker" },
                    { 7, "A pen for highlighting text.", "Highlighter" },
                    { 8, "A device for fastening papers together.", "Stapler" },
                    { 9, "Small devices for holding papers together.", "Paper Clips" },
                    { 10, "A tool for cutting paper.", "Scissors" },
                    { 11, "A substance used for sticking things together.", "Glue" },
                    { 12, "A strip of material used for sticking things together.", "Tape" },
                    { 13, "A cover for holding loose sheets of paper.", "Binder" },
                    { 14, "A cover for holding loose sheets of paper.", "Folder" },
                    { 15, "A device for performing mathematical calculations.", "Calculator" },
                    { 16, "A tool for sharpening pencils.", "Sharpener" },
                    { 17, "A smooth, white surface for writing on with markers.", "Whiteboard" },
                    { 18, "A soft, white limestone used for writing on blackboards.", "Chalk" },
                    { 19, "A dark surface for writing on with chalk.", "Blackboard" },
                    { 20, "Small pieces of paper with a re-adherable strip of glue on their back.", "Sticky Notes" },
                    { 21, "Small cards used for recording and storing information.", "Index Cards" },
                    { 22, "A device for printing documents.", "Printer" },
                    { 23, "Material for writing or printing on.", "Paper" },
                    { 24, "A flat paper container for a letter or document.", "Envelope" },
                    { 25, "A small piece of paper that you buy and stick onto an envelope or package to pay for mailing it.", "Stamp" },
                    { 26, "Elastic bands used for holding things together.", "Rubber Bands" },
                    { 27, "Small pins used for attaching papers to a board.", "Push Pins" },
                    { 28, "Small pins used for attaching papers to a board.", "Thumbtacks" },
                    { 29, "A small board with a clip at the top for holding papers.", "Clipboard" },
                    { 30, "A container for keeping office supplies organized.", "Desk Organizer" },
                    { 31, "A piece of furniture used for storing files.", "File Cabinet" },
                    { 32, "A device for printing labels.", "Label Maker" },
                    { 33, "A pad for a computer mouse to move on.", "Mouse Pad" },
                    { 34, "A device for typing on a computer.", "Keyboard" },
                    { 35, "A screen for displaying computer output.", "Monitor" },
                    { 36, "A small, portable device for storing data.", "USB Drive" },
                    { 37, "A portable device for storing large amounts of data.", "External Hard Drive" },
                    { 38, "A device for listening to audio.", "Headphones" },
                    { 39, "Devices for playing sound.", "Speakers" },
                    { 40, "A camera for video conferencing.", "Webcam" },
                    { 41, "A device for recording or amplifying sound.", "Microphone" },
                    { 42, "A device for projecting images onto a screen.", "Projector" },
                    { 43, "A surface for displaying projected images.", "Screen" },
                    { 44, "A device for connecting to the internet.", "Router" },
                    { 45, "A device for connecting to the internet.", "Modem" },
                    { 46, "A cable for connecting devices to a network.", "Ethernet Cable" },
                    { 47, "A strip of sockets for plugging in multiple electrical devices.", "Power Strip" },
                    { 48, "A long electrical cord for extending the reach of a power outlet.", "Extension Cord" },
                    { 49, "A device for protecting electrical devices from power surges.", "Surge Protector" },
                    { 50, "A device for charging batteries.", "Battery Charger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
