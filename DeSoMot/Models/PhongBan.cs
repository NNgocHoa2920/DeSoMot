using System.ComponentModel.DataAnnotations;

namespace DeSoMot.Models
{
    public class PhongBan
    {
        [Key]
        public string MaPB { get; set; }
        public string Name { get; set; }

        //thể hiện 1 phòng ban có n nhân vien
        public List<NhanVien> NhanViens { get; set; }
    }
}
