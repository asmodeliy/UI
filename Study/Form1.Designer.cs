namespace Study
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Study.Properties.Resources.ramschip1;
            this.pictureBox1.Location = new System.Drawing.Point(619, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(11, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "doc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.doc_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(260, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 107);
            this.button2.TabIndex = 3;
            this.button2.Text = "nc";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.nc_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(504, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 107);
            this.button3.TabIndex = 4;
            this.button3.Text = "vcs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.vcs_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(28, 375);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox1.TabIndex = 5;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(504, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 107);
            this.button4.TabIndex = 8;
            this.button4.Text = "gnet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.gnet_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Location = new System.Drawing.Point(260, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 107);
            this.button5.TabIndex = 7;
            this.button5.Text = "lib";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.lib_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.YellowGreen;
            this.button6.Location = new System.Drawing.Point(11, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 108);
            this.button6.TabIndex = 6;
            this.button6.Text = "lef";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.lef_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(11, 787);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1185, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 819);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 60, 11, 10);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Data.DataSet dataSet1;
    }
}

