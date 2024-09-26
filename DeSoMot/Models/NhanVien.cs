using System.ComponentModel.DataAnnotations;

namespace DeSoMot.Models
{
    public class NhanVien
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Tuoi {  get; set; }
        public string GioiTinh {  get; set; }

        public PhongBan? PhongBan { get; set; }
        //? có hoặc k cũng đc
    }
}
