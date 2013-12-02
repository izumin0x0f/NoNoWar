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
            //画像ファイルを読み込んで、Imageオブジェクトとして取得する
            setBackgroundImage("D:\\workspace\\NoNoWar\\NoNoWar\\Image\\dance\\a\\dance-a-L1.png");
        }

        private void setBackgroundImage(string path) {
            Image img = Image.FromFile(@path);
            this.BackgroundImage = img;

            this.Width = img.Width;
            this.Height = img.Height;
        }
    }
}