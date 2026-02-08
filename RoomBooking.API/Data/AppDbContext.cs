// ASP.NET Web API (lebih tepatnya ASP.NET Core + Entity Framework Core).
// Merupakan jembatan antara code C# dan database.

using Microsoft.EntityFrameworkCore; // pakai library Entity Framework Core. EF Core itu tool resmi .NET untuk database.
using RoomBooking.API.Models; // Model ini nanti jadi tabel database.

namespace RoomBooking.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<PeminjamanRuangan> PeminjamanRuangan { get; set; } 
        // Buat tabel bernama PeminjamanRuangan berdasarkan model class PeminjamanRuangan
        // DbSet = Kumpulan data dari tabel itu
    }
}

// Catatan:
// 1. Model = bentuk data
//PeminjamanRuangan.cs
//2. DbContext = penghubung database
//AppDbContext.cs
// 3. DbSet = tabel
//DbSet<PeminjamanRuangan>
//4. Migration = bikin tabel otomatis
//dotnet ef migrations add InitialCreate
//dotnet ef database update
//5. Controller = API akses data
//GET /api/peminjaman
//POST /api/peminjaman