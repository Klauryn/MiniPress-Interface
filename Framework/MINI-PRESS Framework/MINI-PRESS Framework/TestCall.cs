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
    public partial class TestCall : Form
    {
        public static TestCall instance;            //TestCall formunu başka formlarda kullanabilmek adına instance adında bir nesne oluşturuldu.
        public TestCall()
        {
            InitializeComponent();
            instance = this;
            imageLoad();
        }

        /*************************************************************\   BUTON ICON ATAMA İŞLEMLERİ  /****************************************************************/
        public void imageLoad()      //Butonların iconlarının boyutu ve konumu ayarlandı.
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(35, 35);

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\testidüzenleoff.png"));        //Testi Düzenle Button
            this.btnEditTest.Image = imageList.Images[0];

            imageList.Images.Add(Image.FromFile(@"..\\FolderIcon\\accept.png"));                 //Kayıt Sayfası Button
            this.btnRegPage.Image = imageList.Images[1];
        }

        /*************************************************************\   TESTİ DÜZENLE BUTONU İŞLEMLERİ   /****************************************************************/
        public void btnEditTest_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                Form1.instance.pnlDesktop.Panel2Collapsed = false;                              //panel2 aktif edildi.(compare butonuna basıldığında deaktif edildiği için)
                Form1.instance.OpenChildForm1(new MINI_PRESS_Framework.TestEdit(), sender);        
            }
        }

        /*************************************************************\   FORM ÇAĞIRMA İŞLEMLERİ   /****************************************************************/
        public void close()
        {
            Form1.instance.pnlDesktop.Panel2.Controls.Clear();
        }
    }
}