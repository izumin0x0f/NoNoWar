using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoNoWar
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�摜�t�@�C����ǂݍ���ŁAImage�I�u�W�F�N�g�Ƃ��Ď擾����
            Image img = Image.FromFile(@"D:\workspace\NoNoWar\NoNoWar\Image\dance\a\dance-a-L1.png");
            this.BackgroundImage = img;

            this.Width = img.Width;
            this.Height = img.Height;
        }

        private void setBackgroundImage() {
            Image img = Image.FromFile(@"D:\workspace\NoNoWar\NoNoWar\Image\dance\a\dance-a-L1.png");
            this.BackgroundImage = img;

            this.Width = img.Width;
            this.Height = img.Height;
        }
    }
}