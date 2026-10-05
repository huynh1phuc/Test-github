using System.Text.Json;

NhanVien nv = new NhanVien();
Console.WriteLine($"Nhân viên: {JsonSerializer.Serialize(nv)}");

SanPham nv1 = new SanPham();
Console.WriteLine($"Nhân viên: {JsonSerializer.Serialize(nv1)}");
