using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WFASekillerDuyasi
{
    public partial class Form1 : Form
    {
        //Combobox seçilip özellkilerinden dropdownlist olmalý
        List<Sekiller> sekiller = new List<Sekiller>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            cboTur.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekiller sekil;
            switch (cboTur.SelectedItem.ToString())
            {
                case "Dikdörtgen":
                    sekil = new Dikdortgen();
                    break;
                case "Elips":
                    sekil = new Elips();
                    break;
                default:
                    MessageBox.Show("Lütfen bir tür seçiniz.");
                    return;

            }
            sekil.X = (int)nudX.Value;
            sekil.Y = (int)nudY.Value;
            sekil.Genislik = (int)nudGen.Value;
            sekil.Yukseklik = (int)nudYuk.Value;
            sekil.Renk = pboRenk.BackColor;
            sekiller.Add(sekil);
            listele();
        }

        private void listele()
        {
            LstSekiller.Items.Clear();
            foreach (Sekiller sekil in sekiller)
            {
                LstSekiller.Items.Add(sekil);
            }
            pnlCizim.Refresh();
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pboRenk.BackColor = cdiRenk.Color;
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (Sekiller sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
            }
        }

        private void btnRastgeleEkle_Click(object sender, EventArgs e)
        {
            int x = rnd.Next(pnlCizim.Width);
            int y = rnd.Next(pnlCizim.Height);
            int gen = rnd.Next(pnlCizim.Width - x);
            int yuk = rnd.Next(pnlCizim.Height - y);
            Color renk = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
            cdiRenk.Color = renk;

            nudX.Value = x;
            nudY.Value = y;
            nudGen.Value = gen;
            nudYuk.Value = yuk;
            pboRenk.BackColor = renk;
            cboTur.SelectedIndex = rnd.Next(cboTur.Items.Count);
            btnEkle.PerformClick();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            sekiller.Clear();
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = LstSekiller.SelectedIndex;
            if (sid < 0)
            {
                return;
            }
            sekiller.RemoveAt(sid);
            listele();
            LstSekiller.SelectedIndex = Math.Min(sid, sekiller.Count - 1);
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = LstSekiller.SelectedIndex;

            if (sid >= 1)
            {

                Sekiller seciliSekil = sekiller[sid];
                sekiller.RemoveAt(sid);
                sekiller.Insert(sid - 1, seciliSekil);

                // Listeyi güncelleyerek ve þekli yeniden seçebiriz 1 ile sýnýrlandýrdýk
                listele();
                LstSekiller.SelectedIndex = sid - 1;
            }


        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = LstSekiller.SelectedIndex;

            if (sid >= 0 && sid < sekiller.Count - 1)
            {

                Sekiller seciliSekil = sekiller[sid];
                sekiller.RemoveAt(sid);
                sekiller.Insert(sid + 1, seciliSekil);

                // Listeyi güncelleyerek ve þekli yeniden seçebiriz 1 ile sýnýrlandýrdýk
                listele();
                LstSekiller.SelectedIndex = sid + 1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pnlCizim.Width, pnlCizim.Height);
            Rectangle rec = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            pnlCizim.DrawToBitmap(bitmap, rec);
            string yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\resim.png";
            bitmap.Save(yol, ImageFormat.Png);
           
        }
    }
}