using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Nhom_07.Models;

namespace Code_Nhom_07.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TuiSachDataContext dulieu = new TuiSachDataContext();

        public ActionResult Home_Index()
        {
            List<TUISACH> dsts = dulieu.TUISACHes.Take(4).ToList();
            return View(dsts);
        }

        public ActionResult tatCaSanPham()
        {
            List<TUISACH> dsts = dulieu.TUISACHes.ToList();
            List<PHANLOAI> dspl = dulieu.PHANLOAIs.ToList();
            List<THUONGHIEU> dsth = dulieu.THUONGHIEUs.ToList();

            ViewBag.tuiSach = dsts;
            ViewBag.phanLoai = dspl;
            ViewBag.thuongHieu = dsth;

            return View();
        }

        public ActionResult thongTinChiTietCuaSP(int id)
        {
            TUISACH ts = dulieu.TUISACHes.FirstOrDefault(t => t.MaTuiSach == id);
            List<THUONGHIEU> dsTH = dulieu.THUONGHIEUs.Where(i => i.MaThuongHieu == id).ToList();
            List<PHANLOAI> dspl = dulieu.PHANLOAIs.Where(i => i.MaLoai == id).ToList();

            ViewBag.thuongHieu = dsTH;
            ViewBag.phanLoai = dspl;

            return View(ts);
        }

        public ActionResult gioiThieu()
        {
            return View();
        }

        public ActionResult lienHe()
        {
            return View();
        }

        public ActionResult dangNhap()
        {
            return View();
        }

        public ActionResult dangKy()
        {
            return View();
        }

        public ActionResult voHang(int id)
        {
            GioHang g = LayGioHang();
            List<Item> ds = g.lstSP;

            return View(ds);
        }
        public void LuuGioHang(GioHang gio)
        {
            Session["gh"] = gio;
        }

        public GioHang LayGioHang()
        {
            // biến nằm trong server, đưa về client
            GioHang gio = (GioHang)Session["gh"];
            return gio;
        }
        public ActionResult chonMua(int id)
        {
            GioHang g = LayGioHang();

            if (g == null)
            {
                g = new GioHang();
                g.Them(id);
            }
            else
            {
                Item s = g.lstSP.FirstOrDefault(t => t.maTS == id);
                if (s == null)
                {
                    g.Them(id);
                }
                else // đã có, tăng số lượng lên 1
                {
                    s.soLuongMua++;
                }
            }
            LuuGioHang(g);
            //return RedirectToAction("Home_Index");
            return RedirectToAction("thongTinChiTietCuaSP");
        }

        public ActionResult xemGioHang()
        {
            GioHang g = LayGioHang();
            List<Item> ds = g.lstSP;

            return View(ds);
        }

        public ActionResult TimKiem()
        {
            ViewBag.cd = dulieu.TUISACHes.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult XLTimKiem(FormCollection fc)
        {
            string ten = fc["txtTen"].ToString();

            List<TUISACH> dsT = dulieu.TUISACHes.Where(t => t.TenTuiSach == ten && t.TenTuiSach.Contains(ten)).ToList();

            
            return View("Home_Index", dsT);
        }

    }
}
