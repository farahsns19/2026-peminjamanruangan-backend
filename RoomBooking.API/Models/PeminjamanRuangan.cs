namespace RoomBooking.API.Models
{
    public class PeminjamanRuangan
    {
        public int Id { get; set; } 
        // Id = PK
        [Required]
        public string NamaPeminjam { get; set; } = "";
        public string NRP { get; set; } = "";
        [Required]
        public string Ruangan { get; set; } = "";

        public DateOnly Tanggal { get; set; }

        public string JamMulai { get; set; } = "";
        public string JamSelesai { get; set; } = "";
        [Required]
        public string Keperluan { get; set; } = "";

        public string Status { get; set; } = "Menunggu";
    }
}