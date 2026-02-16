# Backend - Sistem Peminjaman Ruangan Kampus

Backend REST API untuk Sistem Peminjaman Ruangan Kampus.  
Dibangun menggunakan ASP.NET Core Web API dan SQLite Database.

---

## Fitur Utama

- CRUD Peminjaman Ruangan
- Status Peminjaman (Menunggu / Disetujui / Ditolak)
- Riwayat dan Filter Status

---

## Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQLite Database
- Swagger UI

---

## Instalasi

Clone repo:

```bash
git clone https://github.com/farahsns19/2026-peminjamanruangan-backend.git
cd 2026-peminjamanruangan-backend
```
Masuk folder API:
cd RoomBooking.API

Install dependency:
dotnet restore

---

# Menjalankan Project
dotnet run

API akan berjalan di:
http://localhost:5133

Swagger tersedia di:
http://localhost:5133/swagger

---

# Database dan Migration
Migration dibuat menggunakan EF Core:
dotnet ef migrations add InitialCreate
dotnet ef database update

Database file:
RoomBooking.db

---

# License
Project ini dibuat untuk tugas Persiapan PDBL 2026.
