using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_PRESS_Framework
{
    public partial class TestEdit : Form
    {
        public static TestEdit instance;
        public TestEdit()
        {
            InitializeComponent();
            instance = this;
            imageLoad();
        }

        /*************************************************************\   BUTON ICON ATAMA İŞLEMLERİ  /****************************************************************/
        public void imageLoad()       //Butonların iconlarının boyutu ve konumu ayarlandı.
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(35, 35);

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\nameiconoff.png"));            //Kalıp Bilgileri Button
            this.btnMoldInformation.Image = imageList.Images[0];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\testparametreoff.png"));       //Kontrol Parametreleri Button
            this.btnControlParameters.Image = imageList.Images[1];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\returnoff.png"));              //Hareket Profili Button
            this.btnMotionProfile.Image = imageList.Images[2];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\imageoff.png"));               //Resim Yükle Button
            this.btnUploadImage.Image = imageList.Images[3];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\graph2off.png"));              //Grafik Sınırlayıcı Button
            this.btnGraphDelimiter.Image = imageList.Images[4];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\yenikayitoff.png"));           //Yeni Kayıt Button
            this.btnNewRegistration.Image = imageList.Images[5];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\kaydetoff.png"));              //Kaydet Button
            this.btnSaveTest.Image = imageList.Images[6];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\dustbinoff.png"));             //Sil Button
            this.btnDeleteTest.Image = imageList.Images[7];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\okoff.png"));                  //Çalışmaya Gönder Button
            this.btnSendWork.Image = imageList.Images[8];
        }
        
        /********************************************************\   KALIP BİLGİLERİ BUTONU İŞLEMLERİ   /************************************************************/
        private void btnMoldInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MINI_PRESS_Framework.MoldInformation(), btnMoldInformation, Color.FromArgb(172, 204, 223), splitContainer1, sender);
            btnControlParameters.BackColor = Color.Transparent;
            btnMotionProfile.BackColor = Color.Transparent;

        }

        /******************************************************\   KONTROL PARAMETRELERİ BUTONU İŞLEMLERİ   /*******************************************************/
        private void btnControlParameters_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MINI_PRESS_Framework.ControlParameters(), btnControlParameters, Color.FromArgb(158, 194, 216), splitContainer1, sender);
            btnMoldInformation.BackColor = Color.Transparent;
            btnMotionProfile.BackColor = Color.Transparent;
        }

        /*********************************************************\   HAREKET PROFİLİ BUTONU İŞLEMLERİ   /*********************************************************/
        private void btnMotionProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MINI_PRESS_Framework.MotionProfile(), btnMotionProfile, Color.FromArgb(143, 186, 211), splitContainer1, sender);
            btnControlParameters.BackColor = Color.Transparent;
            btnMoldInformation.BackColor = Color.Transparent;
        }

        /*************************************************************\  OPEN CHİLD FORM İŞLEMLERİ  /****************************************************************/
        public void OpenChildForm(Form childForm, Button button, Color color, SplitContainer splitContainer, object sender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            splitContainer1.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            button.BackColor = color;
            splitContainer.BackColor = color;
        }
    }
}


