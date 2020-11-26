using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI
{
    class Ngay
    {
        public int KiemTraNhuan(ComboBox cbYear)
        {
            int year = Convert.ToInt32(cbYear.SelectedItem);
            if (year % 4 == 0 && year % 100 != 0)
                return 1;
            if (year % 400 == 0)
                return 1;
            return 0;
        }
        public int NgayMax(ComboBox cbDate, ComboBox cbMonth, ComboBox cbYear)
        {
            int day = Convert.ToInt32(cbDate.SelectedItem);
            int month = Convert.ToInt32(cbMonth.SelectedItem);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31; // Các tháng có 31 ngày
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30; // Các tháng có 30 ngày
                    break;
                case 2:
                    {
                        if (KiemTraNhuan(cbYear) == 1)
                            return 29; // Nếu là năm Nhuận => Tháng 2 : 29 ngày
                        return 28; // Ngược lại => Tháng 2: 28 ngày
                    }
                default:
                    return 0;
            }
        }
        public int KiemTraHopLe(ComboBox cbDate, ComboBox cbMonth, ComboBox cbYear)
        {
            int month = Convert.ToInt32(cbMonth.SelectedItem);
            int day = Convert.ToInt32(cbDate.SelectedItem);
            if (month >= 1 && month <= 12)
            {
                if (day >= 1 && day <= NgayMax(cbDate, cbMonth, cbYear)) // Nếu ngày từ 1 đến cái ngày lớn nhất trong tháng đó

                    return 1;
                return 0;
            }
            return 0;
        }
    }
}

