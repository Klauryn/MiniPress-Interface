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
    public partial class Form1 : Form
    {

        public static Form1 instance;   //Form1 i başka formlarda(class) görmek için instance değişkeni oluşturuldu.
        public Panel pnl;               //başka formlarda(class) panel çekebilmek için pnl değişkeni oluşturuldu.
        public Form1()
        {
            InitializeComponent();
            instance = this;            //instance değişkeni Form1 ile eşleştirildi.
            pnl = pnlDesktop.Panel2;    //pnl değişkeni pnlDesktop.Panel2 ile eşleştirildi.

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            /*pnlNav.Width = btnStart.Width;
            pnlNav.Top = btnStart.Top -5;
            pnlNav.Left = btnStart.Left;
            btnStart.BackColor = Color.FromArgb(10, 100, 73);*/

            txtStateInf.Text = "";
            txtPosition.Text = "0mm";
            txtForce.Text = "0N";

            imageLoad();     //Başlangıçta butonların iconları yüklendi
        }

        /*************************************************************\   BUTON ICON ATAMA İŞLEMLERİ  /*************************************************************/
        public void imageLoad()      //Butonların iconlarının boyutu ve konumu ayarlandı.
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\onbutonoff.png"));        //Start Button
            this.btnStart.Image = imageList.Images[0];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\stopoff.png"));           //Stop Button
            this.btnStop.Image = imageList.Images[1];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\folderoff.png"));         //TestCall Button
            this.btnTestCall.Image = imageList.Images[2];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\runoff.png"));            //TestStart Button
            this.btnTestStart.Image = imageList.Images[3];  

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\pauseoff.png"));          //TestStop Button
            this.btnTestStop.Image = imageList.Images[4];   

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\karestopoff.png"));       //TestFinished Button
            this.btnTestFinished.Image = imageList.Images[5];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\raporoff.png"));          //Report Button
            this.btnReport.Image = imageList.Images[6];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\graphoff.png"));          //Compare Button
            this.btnCompare.Image = imageList.Images[7];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\alarmoff.png"));          //Alarms Button
            this.btnAlarms.Image = imageList.Images[8];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\settingsoff.png"));       //Calibration Button
            this.btnCalibration.Image = imageList.Images[9];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\closeoff.png"));          //Exit Button
            this.btnExit.Image = imageList.Images[10];  
        }

        /*************************************************************\   START BUTONU İŞLEMLERİ   /*************************************************************/
        int i = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            /*pnlNav.Width = btnStart.Width;
            pnlNav.Top = btnStart.Top - 5;
            pnlNav.Left = btnStart.Left;
            pnlNav.Height = flowLayoutPanel2.Height;*/
            //btnStart.BackColor = Color.CadetBlue;

            //if yapısı butonun her basıldığında on off durumunu değiştirmesini sağlar

        i++;

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);

            if (i % 2 == 1)
            {
                imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\onbutonon.png"));
                btnStart.Image = imageList.Images[0];
            }
            else
            {
                imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\onbutonoff.png"));
                btnStart.Image = imageList.Images[0];
            }
            txtStateInf.Text = "";
            txtStateInf.Text = "Hidraulic Start";
        }

        /*************************************************************\   STOP BUTONU İŞLEMLERİ   /*************************************************************/
        private void btnStop_Click(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);

            if (i % 2 == 1)
            {
                imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\onbutonoff.png"));
                btnStart.Image = imageList.Images[0];
                i++;
            }
            txtStateInf.Text = "";
            txtStateInf.Text = "Hidraulic Stop";
        }

        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\stopoff.png"));
            btnStop.Image = imageList.Images[0];
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\stopon.png"));
            btnStop.Image = imageList.Images[0];
        }

        /*************************************************************\   TEST ÇAĞIR BUTONU İŞLEMLERİ   /*************************************************************/
        private void btnTestCall_MouseUp(object sender, MouseEventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(System.Drawing.Image.FromFile(@"..\\FolderIcon\\folderoff.png"));
            btnTestCall.Image = imageList.Images[0];
            btnTestCall.BackColor = Color.FromArgb(189, 215, 230);
            pnlDesktop.BackColor = Color.FromArgb(189, 215, 230);
        }

        private void btnTestCall_MouseDown(object sender, MouseEventArgs e)
        {
            btnTestCall.BackColor = Color.FromArgb(189, 215, 230);
            txtStateInf.Text = "Test Call";
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\folderon.png"));
            btnTestCall.Image = imageList.Images[0];
        }
        private void btnTestCall_Click(object sender, EventArgs e)
        {
            this.pnlDesktop.Panel2Collapsed = false;
            OpenChildForm(new MINI_PRESS_Framework.TestCall(), sender);
            //TestCall deneme = new TestCall();
            //MessageBox.Show(deneme.listBox1.Items[0].ToString());
        }

        /*************************************************************\   KARŞILAŞTIR BUTONU İŞLEMLERİ   /*************************************************************/
        private void btnCompare_MouseUp(object sender, MouseEventArgs e)
        {
            btnTestStart.BackColor = Color.Wheat;
            btnTestStop.BackColor = Color.Wheat;
            btnTestFinished.BackColor = Color.Wheat;
            btnReport.BackColor = Color.Wheat;
            btnCompare.BackColor = Color.Wheat;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\graphoff.png"));
            btnCompare.Image = imageList.Images[0];
            txtStateInf.Text = "Compare";
        }

        private void btnCompare_MouseDown(object sender, MouseEventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\graphon.png"));
            btnCompare.Image = imageList.Images[0];
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MINI_PRESS_Framework.Compare(), sender);
            this.pnlDesktop.Panel2Collapsed = true;
        }

        /*************************************************************\   FORM ÇAĞIRMA İŞLEMLERİ   /*************************************************************/
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Panel1.Controls.Add(childForm);
            this.pnlDesktop.Panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnTestCall.BackColor = Color.Transparent;
            btnCompare.BackColor = Color.Transparent;
            btnTestStart.BackColor = Color.Transparent;
            btnTestStop.BackColor = Color.Transparent;
            btnTestFinished.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
        }
        public void OpenChildForm1(Form childForm, object sender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Panel2.Controls.Add(childForm);
            pnlDesktop.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //btnEditTest.BackColor = Color.Transparent;
            /*btnCompare.BackColor = Color.Transparent;
            btnTestStart.BackColor = Color.Transparent;
            btnTestStop.BackColor = Color.Transparent;
            btnTestFinished.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;*/
        }

        /*************************************************************\   EXIT BUTONU İŞLEMLERİ   /*************************************************************/
        private void btnExit_Click(object sender, EventArgs e)
        {
            TestCall.instance.close();
            //pnlDesktop.Panel2Collapsed = true;
        }
    }
}