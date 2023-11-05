using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    public partial class Form1 : MetroFramework.Forms.MetroForm //상속 클래스 변경
    {
        private Label docfilename;
        private Label ncfilename;
        private Label vcsfilename;
        private Label leffilename;
        private Label gnetfilename;
        private Label libfilename;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            docfilename = new Label
            {
                Location = new Point(1000, 100),
                AutoSize = true
            };
            this.Controls.Add(docfilename);

            ncfilename = new Label
            {
                Location = new Point(1000, 120),
                AutoSize = true
            };
            this.Controls.Add(ncfilename);
            vcsfilename = new Label
            {
                Location = new Point(1000, 140),
                AutoSize = true
            };
            this.Controls.Add(vcsfilename);

            leffilename = new Label
            {
                Location = new Point(1000, 160),
                AutoSize = true
            };
            this.Controls.Add(leffilename);
            libfilename = new Label
            {
                Location = new Point(1000, 180),
                AutoSize = true
            };
            this.Controls.Add(libfilename);

            gnetfilename = new Label
            {
                Location = new Point(1000, 200),
                AutoSize = true
            };
            this.Controls.Add(gnetfilename);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void doc_Click(object sender, EventArgs e)
        {
            string docFilePath = ShowFileOpenDialog();
            docfilename.Text = "doc : " + docFilePath;
        }

        private void nc_Click(object sender, EventArgs e)
        {
            string ncFilePath = ShowFileOpenDialog();
            ncfilename.Text = "nc : "+ ncFilePath;
        }

        private void vcs_Click(object sender, EventArgs e)
        {
            string vcsFilePath = ShowFileOpenDialog();
            vcsfilename.Text = "vcs : " + vcsFilePath;
        }

        private void lef_Click(object sender, EventArgs e)
        {
            string lefFilePath = ShowFileOpenDialog();
            leffilename.Text = "lef : " + lefFilePath;
        }

        private void lib_Click(object sender, EventArgs e)
        {
            string libFilePath = ShowFileOpenDialog();
            libfilename.Text = "lib : " + libFilePath;
        }

        private void gnet_Click(object sender, EventArgs e)
        {
            string gnetFilePath = ShowFileOpenDialog();
            gnetfilename.Text = "gnet : " + gnetFilePath;
        }
        public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "deliverables upload";
            ofd.FileName = "";
            ofd.Filter = "모든 파일 (*.*)|*.*";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = ofd.SafeFileName;
                return fileName; // 선택한 파일의 전체 경로 반환
            }
            else
            {
                return ""; // 취소되었을 때 빈 문자열 반환
            }
        }
    }
}
