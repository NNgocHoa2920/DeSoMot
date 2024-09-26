using Microsoft.EntityFrameworkCore;

namespace DeSoMot.Models
{
    //đại diện cho sql ở trong visual
    public class SinhVienDbContext : DbContext
    {
        public SinhVienDbContext()
        {
        }

        //nếu dùng các add chuỗi kết nối trực tiếp ở đây thì thêm contructor k có tham số

        //contructor có tham số: ctrl + .
        public SinhVienDbContext(DbContextOptions options) : base(options)
        {
        }

        //db set : đạ-i diện cho 1 bảng
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }

    }
}
