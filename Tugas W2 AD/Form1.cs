namespace Tugas_W2_AD
{
    public partial class F1PengaturanWarna : Form
    {
        int sizeAwal = 25;
        public F1PengaturanWarna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Txt_Inputan_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Btn_Proses_Click(object sender, EventArgs e)
        {
           

            if (Txt_Inputan.Text.Substring(0, 4).ToUpper() == "ISI:")
            {
                LblOutput.Text = Txt_Inputan.Text.Substring(4);
            }
            else if (Txt_Inputan.Text.ToUpper() == "HIDE")
            {
                LblOutput.Visible = false;
            }
            else if (Txt_Inputan.Text.ToUpper() == "SHOWN")
            {
                LblOutput.Visible = true;
            } 
            else if (Txt_Inputan.Text.Substring(0, 6).ToUpper() == "WARNA:")
            {
                if (Txt_Inputan.Text.Substring(6).ToUpper() == "BIRU")
                {
                    LblOutput.ForeColor = Color.Blue;
                }
                else if (Txt_Inputan.Text.Substring(6).ToUpper() == "HIJAU")
                {
                    LblOutput.ForeColor = Color.Green;
                }
                else if (Txt_Inputan.Text.Substring(6).ToUpper() == "PINK")
                {
                    LblOutput.ForeColor = Color.Pink;
                }
                else if (Txt_Inputan.Text.Substring(6).ToUpper() == "MERAH")
                {
                    LblOutput.ForeColor = Color.Red;
                }
            }
            else if (Txt_Inputan.Text.ToUpper() == "BESARKAN")
            {
                sizeAwal = sizeAwal + 5;
                LblOutput.Font = new Font("serif", sizeAwal);
            }
            else if (Txt_Inputan.Text.ToUpper() == "KECILKAN")
            {
                sizeAwal = sizeAwal - 5;
                LblOutput.Font = new Font ("serif",sizeAwal);
            }
            else if (Txt_Inputan.Text.ToUpper() == "RESTART")
            {
                sizeAwal = 25;
                LblOutput.Text = "[EMPTY]";
                LblOutput.Font = new Font("serif", sizeAwal);
                LblOutput.ForeColor = Color.Black;
            }
            
        }
    }
}