using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace MyProject;

internal class Excercises
{
            enum Currency
    {
        USD=1,
        EUR,
        JPY,
        GBP,
    }
    static void Bai_1()
    {
    Console.OutputEncoding = Encoding.UTF8;
      float csd_cu;
    do
    {
        Console.Write("Nhập chỉ số điện cũ (kWh):");
        if (float.TryParse(Console.ReadLine(), out csd_cu))
            break;
        else
            Console.WriteLine("Không hợp lệ");
    
            
    } while (true);
    float csd_moi;
    do
    {
        Console.Write("Nhập chỉ số điện mới: (kWh):");
        if (float.TryParse(Console.ReadLine(), out csd_moi))
            if (csd_moi >= csd_cu)
            break;
            else
            Console.WriteLine("\t***Chỉ số điện mới phải lớn hơn chỉ số điện cũ");
        else
            Console.WriteLine("Không hợp lệ");

    } while (true);
    float tieuthu = csd_moi-csd_cu;
    float gia_tien = 0;
    const float rate1 = 1806;
    const float rate2 = 1866;
    const float rate3 = 2167;
    const float rate4 = 2729;
    const float rate5 = 3050;
    if (0 < tieuthu && tieuthu <= 50)
        {
            gia_tien=rate1*tieuthu;
        }
    else if (51 <= tieuthu && tieuthu <= 100)
        {
            gia_tien=50*rate1+(tieuthu-50)*rate2;
        }
    else if (101 <= tieuthu && tieuthu <= 200)
        {
            gia_tien=50*rate1+50*rate2+(tieuthu-100)*rate3;
        }
    else if (201 <= tieuthu && tieuthu <=300)
        {
            gia_tien=50*rate1+50*rate2+100*rate3+(tieuthu-200)*rate4;
        }
    else if (tieuthu >= 301)
        {
            gia_tien=50*rate1+50*rate2+100*rate3+100*rate4+(tieuthu-300)*rate5;
        }
    decimal VAT = (decimal)(gia_tien*0.08f);
    decimal after_gia_tien=(decimal)gia_tien+VAT;
    
    Console.WriteLine($"Số điện tiêu thụ: {tieuthu} kWh");
    Console.WriteLine($"Tiền điện chưa thuế: {gia_tien:C} ");
    Console.WriteLine($"Thuế VAT: {VAT:C}");
    Console.WriteLine($"Tổng thanh toán: {after_gia_tien:C}");
    }
    static void Bai_2()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double can_nang;
        double chieu_cao;
        while (true){
            Console.Write("Chiều cao (m):");
            if(double.TryParse(Console.ReadLine(), out chieu_cao))
            {
                break;
            }
            else
            {
                Console.WriteLine("Không hợp lệ");
            }
            
        };
        while (true){
        Console.Write("Cân nặng (kg):");
           
            
            if (double.TryParse(Console.ReadLine(), out can_nang))
            {
                break;
            }
            else
            {
                Console.WriteLine("Không hợp lệ");
            }
        }
        double BMI=can_nang/(chieu_cao*chieu_cao);
        Console.WriteLine($"Chỉ số sức khỏe của bạn: {BMI:F2}");
        if (BMI<18.5)
        {
            Console.WriteLine("Phân loại sức khỏe: Gầy");
        }
        else if (18.5 <=BMI && BMI < 23)
        {
            Console.WriteLine("Phân loại sức khỏe: Bình thường");
        }
        else if (23 <= BMI && BMI <25)
        {
            Console.WriteLine("Phân loại sức khỏe: Thừa cân");
        }
        else
        {
            Console.WriteLine("Phân loại sức khỏe: Béo phì");
        }
        double nang_toi_thieu=18.5*chieu_cao*chieu_cao;
        double nang_toi_da=22.9*chieu_cao*chieu_cao;
        Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {nang_toi_thieu:F2} kg đến {nang_toi_da:F2} kg.");
    }
    static void Bai_3()
    {
        float so_tien;
        while (true)
        {
            Console.Write("Nhập số tiền VNĐ:");
            if (float.TryParse(Console.ReadLine(), out so_tien))
            {
                break;
            }
            else
            {
                Console.WriteLine("Không hợp lệ");
            }
        }
        int chon_so;
        while (true)
        {
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP):");
            if (int.TryParse(Console.ReadLine(), out chon_so))
            {
                break;
            }
            else
            {
                Console.WriteLine("Không hợp lệ");
            }
        }
        decimal phi_dich_vu= (decimal) (0.005f*so_tien);
        decimal tien_tinh_doi= (decimal)so_tien-phi_dich_vu;
        Console.WriteLine($"Phí dịch vụ (0.5%): {phi_dich_vu} VNĐ");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {tien_tinh_doi} VNĐ");
        int loai_tien=chon_so;
        float rate=0;
        switch (loai_tien)
        {
            case (int)Currency.USD:
            rate=25400;
            decimal tien_quy_doi = (decimal)(so_tien/rate);
            Console.WriteLine($"Số tiền USD nhận được: {tien_quy_doi:F2} USD");
            break;
            case (int)Currency.EUR:
            rate=27200;
            tien_quy_doi = (decimal)(so_tien/rate);
            Console.WriteLine($"Số tiền EUR nhận được: {tien_quy_doi:F2} EUR");
            break;
            case (int)Currency.JPY:
            rate = 165;
            tien_quy_doi = (decimal)(so_tien/rate);
            Console.WriteLine($"Số tiền JPY nhận được: {tien_quy_doi:F2} JPY");
            break;
            case (int)Currency.GBP:
            rate = 32100;
            tien_quy_doi = (decimal)(so_tien/rate);
            Console.WriteLine($"Số tiền GBP nhận được: {tien_quy_doi:F2} GBP");
            break;
        }
        
    }
    static void Bai_4()
    {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime ngay_thang_nam;
        while (true)
        {
            Console.Write($"Nhập ngày sinh (dd/MM/yyyy):");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay_thang_nam))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ngày không hợp lệ");
            }
        }
        DateTime hien_tai = DateTime.Now;
        float so_tuoi = hien_tai.Year-ngay_thang_nam.Year;
        TimeSpan so_ngay_da_song= hien_tai - ngay_thang_nam;
        Console.WriteLine($"Số tuổi của bạn là: {so_tuoi}");
        Console.WriteLine($"Số ngày tổng cộng đã sống: {so_ngay_da_song.Days}");
        DateTime sinh_nhat_trong_nam_hien_tai = new DateTime(hien_tai.Year, ngay_thang_nam.Month, ngay_thang_nam.Day);
        DateTime sinh_nhat_nam_ke = new DateTime(hien_tai.Year + 1, ngay_thang_nam.Month, ngay_thang_nam.Day);
        TimeSpan so_ngay_con_lai = sinh_nhat_trong_nam_hien_tai - hien_tai;
        TimeSpan so_ngay_con_lai_2 = sinh_nhat_nam_ke - hien_tai;
        if (so_ngay_con_lai.Days >= 0)
        {
            Console.WriteLine($"Sinh nhật tiếp theo còn:{so_ngay_con_lai.Days} ngày");
        }
        else
        {
            Console.WriteLine($"SInh nhật tiếp theo còn: {so_ngay_con_lai_2.Days} ngày");
        }


    }
    static void Bai_5()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số tín chỉ của môn C#:");
        int so_tin_chi_c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số điểm của môn C#:");
        float so_diem_c = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập số tín chỉ của môn toán rời rạc:");
        int so_tin_chi_t = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số điểm của môn toán rời rạc:");
        float so_diem_t = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhập số tín chỉ của môn tiếng Anh:");
        int so_tin_chi_a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số điểm của môn tiếng Anh:");
        float so_diem_a = Convert.ToSingle(Console.ReadLine());
        float sco_avg = (so_tin_chi_c * so_diem_c + so_tin_chi_t*so_diem_t+so_tin_chi_a*so_diem_a)/(so_tin_chi_a+so_tin_chi_c+so_tin_chi_t);
        double GPA;
        if (8.5 <= sco_avg && sco_avg <= 10)
        {
            GPA = 4.0;
            Console.WriteLine($"Điểm TB thang 10: {sco_avg:F2}");
            Console.WriteLine("Điểm chữ quy đổi: A");
            Console.WriteLine($"Điểm GPA thang 4: {GPA:F1}");
            Console.WriteLine("Xếp loại học lực: Xuất sắc/giỏi");
        }
        else if (7.0 <= sco_avg && sco_avg <= 8.4)
        {
            GPA = 3.0;
            Console.WriteLine($"Điểm TB thang 10: {sco_avg:F2}");
            Console.WriteLine("Điểm chữ quy đổi: B");
            Console.WriteLine($"Điểm GPA thang 4: {GPA:F1}");
            Console.WriteLine("Xếp loại học lực: Khá");
        }
        else if (5.5 <= sco_avg && sco_avg <= 6.9)
        {
            GPA = 2.0;
            Console.WriteLine($"Điểm TB thang 10: {sco_avg:F2}");
            Console.WriteLine("Điểm chữ quy đổi: C");
            Console.WriteLine($"Điểm GPA thang 4: {GPA:F1}");
            Console.WriteLine("Xếp loại học lực: Trung bình");
        }
        else if (4.0 <= sco_avg && sco_avg <= 5.4)
        {
            GPA = 1.0;
            Console.WriteLine($"Điểm TB thang 10: {sco_avg:F2}");
            Console.WriteLine("Điểm chữ quy đổi: D");
            Console.WriteLine($"Điểm GPA thang 4: {GPA:F1}");
            Console.WriteLine("Xếp loại học lực: Yếu");
        }
        else
        {
            GPA = 0.0;
            Console.WriteLine($"Điểm TB thang 10: {sco_avg:F2}");
            Console.WriteLine("Điểm chữ quy đổi: F");
            Console.WriteLine($"Điểm GPA thang 4: {GPA:F1}");
            Console.WriteLine("Xếp loại học lực: Kém (Trượt)");
        }

    }

    public static void Main(string[] args)
    {
        Bai_1();
        Bai_2();
        Bai_3();
        Bai_4();
        Bai_5();
    }
}
