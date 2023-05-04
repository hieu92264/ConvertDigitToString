namespace ConvertDigitToString
{
    public partial class Form1 : Form
    {
        bool check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai kiểu dữ liệu!");
            }
        }
        private void dem_hang_tram(int n)
        {
            switch (n)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        richText_output.Text = richText_output.Text + "Một trăm ";
                        break;
                    }
                case 2:
                    {
                        richText_output.Text = richText_output.Text + "Hai trăm ";
                        break;
                    }
                case 3:
                    {
                        richText_output.Text = richText_output.Text + "Ba trăm ";
                        break;
                    }
                case 4:
                    {
                        richText_output.Text = richText_output.Text + "Bốn trăm ";
                        break;
                    }
                case 5:
                    {
                        richText_output.Text = richText_output.Text + "Năm trăm ";
                        break;
                    }
                case 6:
                    {
                        richText_output.Text = richText_output.Text + "Sáu trăm ";
                        break;
                    }
                case 7:
                    {
                        richText_output.Text = richText_output.Text + "Bảy trăm ";
                        break;
                    }
                case 8:
                    {
                        richText_output.Text = richText_output.Text + "Tám trăm ";
                        break;
                    }
                case 9:
                    {
                        richText_output.Text = richText_output.Text + "Chín trăm ";
                        break;
                    }
            }
        }
        private void dem_hang_chuc(int n)
        {
            switch (n)
            {
                case 0:
                    {
                        richText_output.Text = richText_output.Text + "linh ";
                        break;
                    }
                case 1:
                    {
                        richText_output.Text = richText_output.Text + "mười ";
                        break;
                    }
                case 2:
                    {
                        richText_output.Text = richText_output.Text + "hai mươi ";
                        break;
                    }
                case 3:
                    {
                        richText_output.Text = richText_output.Text + "ba mươi ";
                        break;
                    }
                case 4:
                    {
                        richText_output.Text = richText_output.Text + "bốn mươi ";
                        break;
                    }
                case 5:
                    {
                        richText_output.Text = richText_output.Text + "năm mươi ";
                        break;
                    }
                case 6:
                    {
                        richText_output.Text = richText_output.Text + "sáu mươi ";
                        break;
                    }
                case 7:
                    {
                        richText_output.Text = richText_output.Text + "bảy mươi ";
                        break;
                    }
                case 8:
                    {
                        richText_output.Text = richText_output.Text + "tám mươi ";
                        break;
                    }
                case 9:
                    {
                        richText_output.Text = richText_output.Text + "chín mươi ";
                        break;
                    }
            }
        }
        private void dem_hang_don_vi(int n, bool check)
        {
            int dv = n % 10;
            n = n / 10;
            int chuc = n % 10;
            switch (dv)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        if (chuc == 0 || check == true)
                        {
                            richText_output.Text = richText_output.Text + "một";
                        }
                        else richText_output.Text = richText_output.Text + "mốt";
                        break;
                    }
                case 2:
                    {
                        richText_output.Text = richText_output.Text + "hai";
                        break;
                    }
                case 3:
                    {
                        richText_output.Text = richText_output.Text + "ba";
                        break;
                    }
                case 4:
                    {
                        richText_output.Text = richText_output.Text + "bốn";
                        break;
                    }
                case 5:
                    {
                        richText_output.Text = richText_output.Text + "năm";
                        break;
                    }
                case 6:
                    {
                        richText_output.Text = richText_output.Text + "sáu";
                        break;
                    }
                case 7:
                    {
                        richText_output.Text = richText_output.Text + "bảy";
                        break;
                    }
                case 8:
                    {
                        richText_output.Text = richText_output.Text + "tám";
                        break;
                    }
                case 9:
                    {
                        richText_output.Text = richText_output.Text + "chín";
                        break;
                    }
            }
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_input.Text == "") MessageBox.Show("Chưa nhập dữ liệu!");
                else if (Convert.ToInt32(txt_input.Text) >= 1 && Convert.ToInt32(txt_input.Text) <= 999)
                {
                    int n = Convert.ToInt32(txt_input.Text);
                    if (1 <= n && n <= 9)
                    {
                        check = true;
                        this.dem_hang_don_vi(n, check);
                    }
                    else if (10 <= n && n <= 99)
                    {
                        int donvi = n % 10;
                        n = n / 10;
                        int chuc = n % 10;
                        this.dem_hang_don_vi(donvi, check);
                        this.dem_hang_chuc(chuc);
                    }
                    else if (100 <= n && n <= 999)
                    {
                        int donvi = n % 10;
                        n = n / 10;
                        int chuc = n % 10;
                        n = n / 10;
                        int tram = n % 10;
                        this.dem_hang_tram(tram);
                        this.dem_hang_chuc(chuc);
                        this.dem_hang_don_vi(donvi, check);
                    }
                }
                else MessageBox.Show("Số cần chuyển không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            richText_output.Clear();
        }
    }
}