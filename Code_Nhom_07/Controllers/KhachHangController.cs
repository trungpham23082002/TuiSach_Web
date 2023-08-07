using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Nhom_07.Models;

namespace Code_Nhom_07.Controllers
{
    public class KhachHangController : Controller
    {
        //
        // GET: /KhachHang/

        TuiSachDataContext dl = new TuiSachDataContext();

        public ActionResult KhachHang_DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KhachHang_DangNhap(FormCollection col)
        {
            KHACHHANG kh = dl.KHACHHANGs.FirstOrDefault
                (k => k.TaiKhoan == col["txtName"] && k.MatKhau == col["txtPass"]);
            KHACHHANG khsai = dl.KHACHHANGs.FirstOrDefault
                (k => k.TaiKhoan != col["txtName"] && k.MatKhau != col["txtPass"]);
            if (kh != null)
            {
                Session["kh"] = kh.HoTen;
                Session["state"] = "1";
                return RedirectToAction("Home_Index", "Home");
            }
            else if (khsai != null)
            {
                Session["state"] = "0";
                return RedirectToAction("KhachHang_DangNhap", "KhachHang");
            }
            //return View();
            return RedirectToAction("KhachHang_DangNhap", "KhachHang");
        }

        public ActionResult KhachHang_dangXuat()
        {
            Session.Clear();
            return RedirectToAction("Home_Index", "Home");
        }

    }
}
