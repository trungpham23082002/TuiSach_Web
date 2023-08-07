using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Nhom_07.Models;

namespace Code_Nhom_07.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        TuiSachDataContext dulieu = new TuiSachDataContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult bangDieuKhien()
        {
            return View();
        }

        public ActionResult QLKhachHang()
        {
            List<KHACHHANG> dskh = dulieu.KHACHHANGs.ToList();
            return View(dskh);
        }

        public ActionResult XoaKhachHang(int m)
        {
            KHACHHANG a = dulieu.KHACHHANGs.FirstOrDefault(t => t.MaKhachHang == m);
            CHITIETDONHANG hd = dulieu.CHITIETDONHANGs.FirstOrDefault(t => t.MaKhachHang == a.MaKhachHang);
            dulieu.CHITIETDONHANGs.DeleteOnSubmit(hd);
            dulieu.SubmitChanges();
            dulieu.KHACHHANGs.DeleteOnSubmit(a);
            dulieu.SubmitChanges();
            return RedirectToAction("QLKhachHang", "Admin");
        }

        public ActionResult QLSanPham()
        {
            List<TUISACH> dssp = dulieu.TUISACHes.ToList();
            return View(dssp);
        }

        public ActionResult taoMoiSanPham()
        {
            return View();
        }

        public ActionResult XLThemMoiSanPham(TUISACH t)
        {
            dulieu.TUISACHes.InsertOnSubmit(t);
            dulieu.SubmitChanges();
            return RedirectToAction("QLSanPham");
        }

        public ActionResult SuaSanPham(int id)
        {
            TUISACH t = dulieu.TUISACHes.FirstOrDefault(s => s.MaLoai == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult XLSuaSanPham(FormCollection f, int id)
        {
            TUISACH a = new TUISACH();
            a = dulieu.TUISACHes.FirstOrDefault(s => s.MaTuiSach == id);

            a.TenTuiSach = f["TenTuiXach"];
            a.MaThuongHieu = int.Parse(f["MaThuongHieu"]);
            a.XuatXu = f["XuatXu"];
            a.MaLoai = int.Parse(f["MaLoai"]);
            a.GiaBan = int.Parse(f["GiaBan"]);
            a.ChatLieu = f["ChatLieu"];
            a.ChieuCao = f["ChieuCao"];
            a.ChieuRong = f["ChieuRong"];
            a.ChieuDai = f["ChieuDai"];
            a.MauSac = f["MauSac"];
            a.MoTa = f["MoTa"];

            dulieu.SubmitChanges();
            return RedirectToAction("QLSanPham", "Admin");
        }

        public ActionResult XoaSanPham(int id)
        {
            TUISACH a = dulieu.TUISACHes.FirstOrDefault(t => t.MaTuiSach == id);
            dulieu.TUISACHes.DeleteOnSubmit(a);
            dulieu.SubmitChanges();
            return RedirectToAction("QLSanPham");
        }

        public ActionResult QLLoaiHang()
        {
            List<PHANLOAI> dstl = dulieu.PHANLOAIs.ToList();
            return View(dstl);
        }
        public ActionResult ThemMoiLoaiHang()
        {
            return View();
        }

        public ActionResult XoaLoaiHang(int id)
        {
            PHANLOAI a = dulieu.PHANLOAIs.FirstOrDefault(t => t.MaLoai == id);
            dulieu.PHANLOAIs.DeleteOnSubmit(a);
            dulieu.SubmitChanges();
            return RedirectToAction("QLLoaiHang");
        }

        public ActionResult XLThemMoi(PHANLOAI t)
        {
            dulieu.PHANLOAIs.InsertOnSubmit(t);
            dulieu.SubmitChanges();
            return RedirectToAction("QLLoaiHang");
        }
        public ActionResult SuaLoaiHang(int id)
        {
            PHANLOAI t = dulieu.PHANLOAIs.FirstOrDefault(s => s.MaLoai == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult SuaLoaiHang(int id, PHANLOAI t)
        {
            PHANLOAI f = dulieu.PHANLOAIs.FirstOrDefault(s => s.MaLoai == id);
            f.TenLoai = t.TenLoai;
            UpdateModel(f);
            dulieu.SubmitChanges();
            return RedirectToAction("QLLoaiHang");
        }

        public ActionResult QLDonHang()
        {
            List<CHITIETDONHANG> dsdh = dulieu.CHITIETDONHANGs.ToList();
            return View(dsdh);
        }

        public ActionResult taoMoiDonHang()
        {
            return View();
        }

        public ActionResult XLThemMoiDonHang(CHITIETDONHANG t)
        {
            dulieu.CHITIETDONHANGs.InsertOnSubmit(t);
            dulieu.SubmitChanges();
            return RedirectToAction("QLDonHang");
        }

        public ActionResult quanLy_QLDonHang_ChuaGiao()
        {
            List<CHITIETDONHANG> ds = dulieu.CHITIETDONHANGs.Where(hd => hd.NgayThanhToan == null).ToList();
            return View("QLDonHang", ds);
        }

        public ActionResult quanLy_QLDonHang_DaGiao()
        {
            List<CHITIETDONHANG> ds = dulieu.CHITIETDONHANGs.Where(hd => hd.NgayThanhToan != null).ToList();
            return View("QLDonHang", ds);
        }

        public ActionResult quanLy_ThongKeHoaDon(int m)
        {
            List<CHITIETDONHANG> dsct = dulieu.CHITIETDONHANGs.Where(i => i.MaDonHang == m).ToList();
            return PartialView(dsct);
        }

        public ActionResult XoaHd(int m)
        {
            CHITIETDONHANG a = dulieu.CHITIETDONHANGs.FirstOrDefault(t => t.MaDonHang == m);
            dulieu.CHITIETDONHANGs.DeleteOnSubmit(a);
            dulieu.SubmitChanges();
            return RedirectToAction("QLDonHang", "Admin");
        }


        public ActionResult BaoCaoDoanhThu()
        {
            List<CHITIETDONHANG> dsdh = dulieu.CHITIETDONHANGs.ToList();
            return View(dsdh);
        }

    }
}
