using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_Nhom_07.Models
{
    public class Item
    {
        TuiSachDataContext dulieu = new TuiSachDataContext();

        public int maTS { get; set; }
        public string tenTS { get; set; }
        public int thuongHieu { get; set; }
        public string mau { get; set; }
        public string xuatSu { get; set; }
        public int donGia { get; set; }
        public int soLuongMua { get; set; }
        public string hinhAnh { get; set; }

        public Item(int mt)
        {
            maTS = mt;
            TUISACH s = dulieu.TUISACHes.FirstOrDefault(t => t.MaLoai == mt);
            tenTS = s.TenTuiSach;
            thuongHieu = int.Parse(s.MaThuongHieu.ToString());
            mau = s.MauSac;
            xuatSu = s.XuatXu;
            donGia = int.Parse(s.GiaBan.ToString());
            soLuongMua = 1;
            hinhAnh = s.HinhAnh;
        }

        public Item(int mt, int sl)
        {
            maTS = mt;
            TUISACH s = dulieu.TUISACHes.FirstOrDefault(t => t.MaLoai == mt);
            tenTS = s.TenTuiSach;
            thuongHieu = int.Parse(s.MaThuongHieu.ToString());
            mau = s.MauSac;
            xuatSu = s.XuatXu;
            donGia = int.Parse(s.GiaBan.ToString());
            soLuongMua = sl;
            hinhAnh = s.HinhAnh;
        }

        public int thanhTienTemp()
        {
            return soLuongMua * donGia;
        }
    }

    public class GioHang
    {
        public List<Item> lstSP;

        public GioHang()
        {
            lstSP = new List<Item>();
        }
        public GioHang(int ms, int sl)
        {
            Item x = new Item(ms, sl);
            lstSP.Add(x);
        }
        public int DemSLMatHang()
        {
            return lstSP.Count();
        }

        public int Them(int ms)
        {
            Item lk = lstSP.Find(n => n.maTS == ms);

            if (lk == null) // chua co
            {
                Item sach = new Item(ms);
                if (sach == null)
                    return -1;
                lstSP.Add(sach);
            }
            else // co roi
            {
                lk.maTS++; // tang so luong len 1
            }
            return 1;
        }

        public int TongSLMua()
        {
            return lstSP.Sum(x => x.maTS);
        }
    }
}