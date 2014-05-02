using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLTOLabel
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        //Construction
        List<Etiket> etiketler;
        public frmMain()
        {
            InitializeComponent();
            etiketler = new List<Etiket>();
            cbType.SelectedIndex = 0;
            spWidth.Value = Properties.Settings.Default.W;
            spHeight.Value = Properties.Settings.Default.H;
        }
        //Events
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            barkodEkle();
        }
        private void txtLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                barkodEkle();
            }
        }
        private void cmdRemove_Click(object sender, EventArgs e)
        {
            barkodSil();
        }
        private void listboxLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                barkodSil();
            }
        }
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            barkodYazdir();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.W = spWidth.Value;
            Properties.Settings.Default.H = spHeight.Value;
            Properties.Settings.Default.Save();
        }
        //Methods
        private void barkodEkle()
        {
            if (txtLabel.Text.Length != 0)
            {
                if (txtLabel.Text.Length != 6)
                {
                    MessageBox.Show("Barkod 6 karakter olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listboxLabel.Items.Add(txtLabel.Text.ToUpper() + cbType.Text.Substring(0, 2));
                txtLabel.Text = null;
                txtLabel.Focus();
            }
            else
            {
                MessageBox.Show("Barkodu boş geçemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void barkodSil()
        {
            if (listboxLabel.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                listboxLabel.Items.RemoveAt(listboxLabel.SelectedIndex);
            }
        }
        private void barkodYazdir()
        {
            int x = 1;
            etiketler.Clear();
            foreach (string item in listboxLabel.Items)
            {
                Etiket s = new Etiket();
                s.ID = x;
                s.Barkod = item;
                etiketler.Add(s);
                x++;
            }
            if (MessageBox.Show(string.Format("{0} adet barkod bulundu. Yazdırılacak emin misiniz ?", etiketler.Count), "Yazdırma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                rptBarkod Rapor = new rptBarkod();
                Rapor.DataSource = etiketler;
                Rapor.PageWidth = (int)spWidth.Value;
                Rapor.PageHeight = (int)spHeight.Value;
                ReportPrintTool reportPrintTool = new ReportPrintTool(Rapor);
                reportPrintTool.ShowPreviewDialog();
            }
            else
            {
                return;
            }
        }
    }
}