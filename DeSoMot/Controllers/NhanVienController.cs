using DeSoMot.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeSoMot.Controllers
{
    public class NhanVienController : Controller
    {
        //khoi tao lai db 
        SinhVienDbContext _db;
        public NhanVienController(SinhVienDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var nhanVienList = _db.NhanViens.ToList();
            return View(nhanVienList);
        }
        //theem 1 nhan vien
        public IActionResult Create() // chỉ dùng để tạo ra view daao diên crate
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(NhanVien nv)
        {
            _db.NhanViens.Add(nv);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
