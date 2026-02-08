using Microsoft.AspNetCore.Mvc; // Supaya bisa bikin API controller
using Microsoft.EntityFrameworkCore; // supaya bisa query db
using RoomBooking.API.Data; // akses AppDbContext
using RoomBooking.API.Models; // akses entity PeminjamanRuangan
using System.ComponentModel.DataAnnotations;

namespace RoomBooking.API.Controllers
{
    [ApiController] // controller khusus API
    [Route("api/[controller]")] //TASK 8 -> untuk menentukan URL endpoint 
    public class PeminjamanRuanganController : ControllerBase
    {
        private readonly AppDbContext _db; // Akses db

        public PeminjamanRuanganController(AppDbContext context){
            // Construktor yang dipanggil (otomatis) saat controller dibuat
            _db = context;
        }
        // Melihat semua data peminjaman
        // GET: api/PeminjamanRuangan
        [HttpGet]
        public async Task<IActionResult> LihatSemua(){
            var daftarPeminjaman = await _db.PeminjamanRuangan.ToListAsync();
            return Ok(daftarPeminjaman);
        }

        // Melihat detail data berdasarkan ID
        // GET: api/PeminjamanRuangan/1
        [HttpGet("{id}")]
        public async Task<IActionResult> LihatDetail(int id)
        {
            var data = await _db.PeminjamanRuangan.FindAsync(id);

            if (data == null)
                return NotFound("Data peminjaman tidak ditemukan.");

            return Ok(data);
        }

        // Menambah data peminjaman baru
        // POST: api/PeminjamanRuangan

        [HttpPost]
        public async Task<IActionResult> TambahData(PeminjamanRuangan peminjamanBaru)
        {
            _db.PeminjamanRuangan.Add(peminjamanBaru);
            await _db.SaveChangesAsync();

            return Ok("Data peminjaman berhasil ditambahkan.");
        }

        // Mengubah data peminjaman
        // PUT: api/PeminjamanRuangan/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UbahData(int id, PeminjamanRuangan dataUpdate)
        {
            var dataLama = await _db.PeminjamanRuangan.FindAsync(id);

            if (dataLama == null)
                return NotFound("Data tidak ditemukan.");

            // Update isi data
            dataLama.NamaPeminjam = dataUpdate.NamaPeminjam;
            dataLama.NRP = dataUpdate.NRP;
            dataLama.Ruangan = dataUpdate.Ruangan;
            dataLama.Tanggal = dataUpdate.Tanggal;
            dataLama.JamMulai = dataUpdate.JamMulai;
            dataLama.JamSelesai = dataUpdate.JamSelesai;
            dataLama.Keperluan = dataUpdate.Keperluan;
            dataLama.Status = dataUpdate.Status;

            await _db.SaveChangesAsync();

            return Ok("Data peminjaman berhasil diperbarui.");
        }

        // Menghapus data peminjaman
        // DELETE: api/PeminjamanRuangan/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> HapusData(int id)
        {
            var data = await _db.PeminjamanRuangan.FindAsync(id);

            if (data == null)
                return NotFound("Data tidak ditemukan.");

            _db.PeminjamanRuangan.Remove(data);
            await _db.SaveChangesAsync();

            return Ok("Data peminjaman berhasil dihapus.");
        }
    }
}
