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
    public partial class Compare : Form
    {
        public static Compare instance;
        public Compare()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
