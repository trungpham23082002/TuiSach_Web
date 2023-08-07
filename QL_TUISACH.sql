create database QL_TUISACH
go
use QL_TUISACH
go
create table TUISACH
(
MaTuiSach int,
TenTuiSach nvarchar(max),
MaThuongHieu int,
HinhAnh nvarchar(50),
XuatXu nvarchar(30),
GiaBan int,
MaLoai int,
ChatLieu nvarchar(30),
ChieuCao nvarchar(10),
ChieuRong nvarchar(10),
ChieuDai nvarchar(10),
MauSac nvarchar(20),
MoTa nvarchar(max)
constraint PK_TUISACH primary key(MaTuiSach),
)
create table THUONGHIEU
(
MaThuongHieu int,
TenThuongHieu nvarchar(30),
LichSu nvarchar(max),
HinhAnhThuongHieu nvarchar(50)
constraint PK_THUONGHIEU primary key(MaThuongHieu)
)
create table PHANLOAI
(
MaLoai int,
TenLoai nvarchar(50),
GioiTinh nvarchar(10),
constraint PK_PHANLOAI primary key(MaLoai)
)
create table KHACHHANG
(
MaKhachHang int,
HoTen nvarchar(50),
NgaySinh datetime,
GioiTinh nvarchar(10),
DienThoai nvarchar(20),
TaiKhoan nvarchar(30),
MatKhau nvarchar(30),
Email nvarchar(50),
DiaChi nvarchar(50),
AnhKhachHang nvarchar(50),
constraint PK_KHACHHANG primary key(MaKhachHang)
)
create table CHITIETDONHANG
(
MaDonHang int,
MaTuiSach int,
SoLuong int,
DonGia money,
Thue float,
MaKhachHang int,
NgayLap date,
NgayGiao date,
NgayThanhToan date,
constraint PK_CHITIETDONHANG primary key(MaDonHang)
)
update ChiTietDonHang set Thue = 0.1 
alter table TUISACH
add constraint FK_TUISACH_THUONGHIEU foreign key(MaThuongHieu) references THUONGHIEU(MaThuongHieu)
alter table TUISACH
add constraint FK_TUISACH_PHANLOAI foreign key(MaLoai) references PHANLOAI(MaLoai)
alter table CHITIETDONHANG
add constraint FK_CHITIETDONHANG_TUISACH foreign key(MaTuiSach) references TUISACH(MaTuiSach)
alter table CHITIETDONHANG
add constraint FK_CHITIETDONHANG_KHACHHANG foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)

insert into THUONGHIEU
values
(N'1',N'Gucci',N'Được sáng lập bởi Guccio Gucci(1881-1953) tại Florence(Ý) , Gucci được xem là một trong những thương hiệu thời trang nổi tiếng và được yêu thích trên thế giới . Bí quyết thành công của Gucci chính là nét hài hòa qua sự kết hợp của các sản phẩm. Bằng nghệ thuật xử lý da điêu luyện cùng tính đồng bộ trong sáng tạo sản phẩm, Gucci đã chinh phục được các khách hàng khó tính nhất. Danh tiếng lẫy lừng cửa "đế chế" này có thể ví như đã bao trùm làng thời trang quốc tế và ngày càng trở nên vững mạnh hơn',N'img_gucci.jpg'),
(N'2',N'Versace',N'Versace là thương hiệu thời trang cao cấp với ngôi vị hàng đầu trong phong cách lãng mạn mang tính huyền thoại, sự gợi cảm và vẻ đẹp quyền lực đậm chất nghệ thuật của Ý được thành lập bởi Gianni Versace vào năm 1978.Versace là biểu tượng thời trang mang tính di sản của nước Ý với niềm cảm hứng nghệ thuật và thời trang luôn sánh bước cùng nhau. Nhà sáng lập thương hiệu, Gianni Versace là người chịu ảnh hưởng mạnh mẽ bởi truyền thống và lịch sử của vùng đất Hi Lạp cổ đại, ông theo học kiến trúc, nghiên cứu văn hóa , nghệ thuật, ngôn ngữ Latin và Hy Lập, đồng thời bị hấp dẫn bởi trường phái nghệ thuật đại chúng(Pop Art) của Andy Warhol',N'img_versace.jpg'),
(N'3',N'Louis Vuitton',N'Louis Vuitton(viết tắt là LV) là thương hiệu thời trang cao cấp đến từ Pháp danh giá nổi tiếng thế giới, thành lập từ năm 1854, mang tên chính người sáng lập Louis Vuitton. Các sản phẩm của thương hiệu Louis Vuitton hãng bao gồm các vật dụng từ da,túi sách,giày,đồng hồ,vali du lịch,trang sức và phụ kiện. Nét đặc trưng của tất cả các sản phẩm này là họa tiết chữ LV lồng vào nhau và hoa bốn thùy(monogram) cộp mác thương hiệu trên nền da hoặc vải canvas thượng hạng',N'img_lv.jpg'),
(N'4',N'Chanel',N'Chanel là thương hiệu xa xỉ bậc nhất đến từ Pháp và mang tên cửa nhà sáng lập Coco Chanel - một nhân vật có tầm ảnh hưởng quan trọng đến thời trang thế kỷ XX.Thương hiệu Chanel sau đó mở rộng và nhanh chóng trở thành nhãn hiệu thời trang cao cấp đáng tự hào bậc nhất của ngành công nghiệp thời trang nước Pháp. Hơn bất kì nhãn hiệu nào , Chanel mang trọn vẹn nhiều tinh hoa của nghành thời trang cổ điển thời đại trước và là mẫu mực về thời trang cổ điển và kinh điển trong làng thời trang thế giới',N'img_chanel.jpg'),
(N'5',N'Charles & Keith',N'Charles & Keith là thương hiệu giày dép và thời trang Singapore dành cho phái đẹp, với dây chuyền sản xuất nhanh,giá cả phải chăng và các thiết kế mới được tung ra đều đặn hàng tuần. Ra đời tại một trong những quốc gia phát triển và tiên tiến ở khu vực Châu Á, Charles & Keith chịu ảnh hưởng của các phong cách Tây Âu,tối giản và đề cao tính cá biệt. Đòng thời sự hòa hợp và rung cảm với thị hiếu cổ điển của văn hóa Phương Đông thế kỷ XX. Thời trang Charles & Keirth là những nhịp điệu trẻ trung,phóng khoáng của những phong cách trẻ mang màu sắc đường phố và thanh thị',N'img_charles&keith.jpg')

insert into PHANLOAI
values
(N'1',N'Túi đeo chéo',N'Nam'),
(N'2',N'Túi đeo chéo',N'Nữ'),
(N'3',N'Ví',N'Nam'),
(N'4',N'Ví',N'Nữ'),
(N'5',N'Túi đeo hông',N'Nam'),
(N'6',N'Túi đeo hông',N'Nữ'),
(N'7',N'Túi cầm tay',N'Nam'),
(N'8',N'Túi cầm tay',N'Nữ'),
(N'9',N'Túi đeo vai',N'Nam'),
(N'10',N'Túi đeo nữ',N'Nam'),
(N'11',N'Túi xách tay',N'Nữ')

insert into TUISACH
values
(N'1',N'Túi Đeo Chéo Gucci Padlock Mini GG Supreme Canvas ‎658487-2ZGAG-9785 Màu Nâu Đen',N'1',N'img_001.jpg',N'Ý',38000000,N'2',N'Canvas , da',N'16cm',N'5cm',N'21cm',N'Nâu đen',
N'Túi Đeo Chéo Gucci Padlock Mini GG Supreme Canvas 658487-2ZGAG-9785 được làm  từ chất liệu vải canvas và da cao cấp mềm min , lớp lót bằng vải cotton bền đẹp lâu dài trong quá trình sử dụng . Form túi thời trang nhỏ gọn với các đường chỉ may vô cùng chắc chắn'),
(N'2',N'Túi Đeo Chéo Gucci Night Courrier GG Supreme Messenger Màu Đen',N'1',N'img_002.jpg',N'Ý',21500000,N'1',N'Da / Vải',N'26cm',N'5cm',N'27cm',N'Đen',
N'Túi được làm từ chất liệu da và vải cao cấp , lớp lót 100% cotton , form túi với cái đường chỉ khâu vô cùng tỉ mỉ và sắc sảo . Thiết kế tiện lợi với ngăn đựng rộng rãi để được nhiều vật dụng khác nhau . Màu sắc đen nổi bật dễ dàng kết hợp với các trang phục khác nhau để thay đổi phong cách theo sở thích bản thân'),
(N'3',N'Túi Đeo Chéo Gucci Horsebit 1955 Mini Bag Họa Tiết GG Màu Be',N'1',N'img_003.jpg',N'Ý',26000000,N'2',N'Da lộn mix vải canvas',N'12cm',N'5cm',N'18cm',N'Be',
N'Túi mang phong cách thiết kế cổ điển với họa tiết logo CG in hoa trên nền vải canvas monogram. Mẫu túi được thiết kế sang chảnh đúng với hình ảnh một món phụ kiện nhỏ xinh cho chị em. Điểm nổi bật thu hút người nhìn chính là phần khóa mạ vàng bằng kim loại được gắn kết hợp với phần viền da của túi rất chắc chắn và tinh tế'),
(N'4',N'Túi Đeo Hông Versace Jeans Couture Màu Xanh Navy',N'2',N'img_004.jpg',N'Ý',5200000,N'5',N'Da cao cấp',N'7cm',N'16.5cm',N'25.5cm',N'Xanh dương',
N'Túi được thiết kế với form cứng cáp , các đường chỉ khâu vô cùng chắc chắn và tỉ mỉ , khóa kéo chắc chắn . Phần dây đeo có thể điều chỉnh tiện lợi , ngăn trong túi rộng rãi bạn có thể đựng được những vật dụng cần thiết khi đi ra ngoài như: ví tiền , điện thoại...'),
(N'5',N'Túi Đeo Hông Versace Jeans Couture Printed Belt Bag Màu Đen Vàng',N'2',N'img_005.jpg',N'Ý',4200000,N'5',N'Vải Nylon',N'13cm',N'12cm',N'35cm',N'Đen - Vàng',
N'Túi đeo hông Versace được thiết kế với form cứng cáp , các đường chỉ khâu vô cùng chắc chắn và tỉ mỉ , khóa kéo chắc chắn . Phần dây đeo có thể điều chỉnh tiện lợi . Ngăn trong túi rộng rãi bạn có thể đựng được những vật dụng cần thiết khi đi ra ngoài như: ví tiền , điện thoại...'),
(N'6',N'Ví Louis Vuitton Multiple Wallet M61695 Màu Xám Đen',N'3',N'img_006.jpg',N'Pháp',12000000,N'3',N'Da cao cấp',N'9cm',N'1.5cm',N'11.5cm',N'Đen',
N'Ví được làm từ chất liệu da cao cấp bền đẹp trong suốt quá trình sử dụng . Form ví chuẩn đẹp , các đường may rất tinh tế và chắc chắn hài lòng ngay cả khách hàng khó tính . Họa tiết logo thương hiệu tạo điểm nhấn độc đáo'),
(N'7',N'Ví Charles & Keith Micaela Quilted Card Holder Multi CK6-50701179 Phối Màu',N'5',N'img_007.jpg',N'Singapore',1290000,N'4',N'Da nhân tao',N'7.8cm',N'3cm',N'10cm',N'Phối màu',
N'Ví có thiết kế nhỏ nhắn phù hợp để người dùng có thể đựng các loại thẻ , giấy tờ cá nhân một cách tiện lợi . Bên cạnh đó , màu sắc sang trọng , tinh tế sẽ giúp đem đến một vẻ đẹp hiện đại cho người sở hữu. Chiếc ví có quai đeo tiện lợi bạn có thể phối đồ theo sở thích của bản thân'),
(N'8',N'Ví Charles & Keith Tweed Chain Link Card Holder Mint Green CK6-51200016',N'5',N'img_008.jpg',N'Singapore',960000,N'4',N'Tweed và Da nhân tạo',N'8.5cm',N'3cm',N'10cm',N'Xanh green',
N'Ví có thiết kế nhỏ nhắn phù hợp để người dùng có thể đựng các loại thẻ , giấy tờ cá nhân một cách tiện lợi . Bạn có thể để ví trong chiếc túi xách của mình và mang đi bất cứ nơi đâu . Với chiếc ví thời trang này bạn sẽ trở nên nổi bật và tự tin hơn khi xuống phố , đi chơi và gặp gỡ mọi người xung quanh'),
(N'9',N'Túi Đeo Vai Louis Vuitton M59631 Dauphine MM Màu Denim',N'3',N'img_009.jpg',N'Pháp',86000000,N'10',N'Da , vải',N'17cm',N'10.5cm',N'25cm',N'Denim',
N'Túi được làm từ chất liệu da và vải cao cấp , form túi với các đường may vô cùng tỉ mỉ và chắc chắn . Túi phối tông màu hiện đại mang đến nét tươi mới . Ngắn túi rộng rãi đựng được nhiều đồ cần thiết khi đi ra ngoài'),
(N'10',N'Túi Cầm Tay Louis Vuitton Pochette Voyage M81317 Màu Xanh Vàng',N'3',N'img_010.jpg',N'Pháp',29000000,N'8',N'Canvas , da',N'27cm',N'21cm',N'6cm',N'Xanh Vàng',
N'Túi được làm từ chất liệu canvas và da cao cấp .Thiết kế túi khóa zip dễ dàng sử dụng khe cắm thẻ và nội thất rộng rãi , đây là cách thuận tiện để mang theo điện thoại máy tính xách tay và các vật dụng cần thiết khác'),
(N'11',N'Túi Đeo Chéo Chanel C19 Small Flap Bag In Dark Beige Màu Be',N'4',N'img_011.jpg',N'Pháp',150000000,N'2',N'Da cao cấp',N'16cm',N'9cm',N'26cm',N'Nâu',
N'Túi có kích thước vừa phải, có thể đựng được các đồ dùng cần thiết như điện thoại , ví tiền,... khi đi chơi với bạn bè . Túi vừa có thể đeo vai hoặc đéo chéo tùy theo sở thích của mỗi người'),
(N'12',N'Túi Xách Burberry The Medium Triple Stud Belt Light Camel Leather Shoulder Bag Màu Caramel',N'2',N'img_012.jpg',N'Anh',23500000,N'11',N'Da cao cấp',N'40cm',N'20cm',N'39cm',N'Nâu',
N'Túi được làm từ chất liệu da cao cấp với form dáng chuẩn đẹp, ngay cả các ngôi sao nổi tiếng thế giới nhất định phải sở hữu mà còn làm các tín đồ thời trang phải "mê mệt" ngay từ cái chạm mắt đầu tiên'),
(N'13',N'Túi Xách Louis Vuitton Locky BB Monogram Caramel',N'3',N'img_013.jpg',N'Pháp',52000000,N'11',N'Da cao cấp',N'16cm',N'7.5cm',N'20cm',N'Nâu Caramel',
N'Louis Vuitton Locky BB Monogram Caramel là sự hòa trộn hoàn hảo giữa sự sang trọng, đẳng cấp trong chất liệu cùng sự tinh tế , đơn giản trong thiết kế. Chiếc túi gần như phù hợp với nhiều sự kiện khác nhau ,kết hợp dây đeo có thể tháo rời giúp phái đẹp tự tin thay đổi các phong cách thời trang một cách đa dạng'),
(N'14',N'Túi Xách Tay Gucci GG Marmont Half-Moon-Shaped Mini Bag New Beige Màu Beige',N'1',N'img_014.jpg',N'Ý',29000000,N'11',N'Da cao cấp',N'11cm',N'5cm',N'21.5cm',N'Beige',
N'Túi được làm từ chất liệu da cao cấp , Họa tiết GG cổ điển ở mặt túi rất đặc trưng và cực kỳ quen thuộc với những ai đã và đang là fan của Gucci. Bên trong túi có không gian chứa khá thoải mái , mang linh hoạt hàng ngày lẫn dạo phố khiến người mặc trở nên cá tính hơn'),
(N'15',N'Túi Đeo Chéo Charles & Keith Este Belted Tweed Phone Pouch CK6-70701213 Màu Đen',N'5',N'img_015.jpg',N'Singapore',1500000,N'2',N'Da, vải Tweed',N'18cm',N'4cm',N'12cm',N'Đen',
N'Túi được làm từ chất liệu cao cấp với độ bền cao, ngăn bên trong túi để những đồ cá nhân nhỏ khi đi ra ngoài như: điện thoại, ví tiền,...Màu sắc đơn giản dễ dàng kết hợp với nhiều trang phục khác nhau tạo nên set đồ nổi bật')
