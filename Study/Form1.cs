using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



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
        private Label fileContents;
        private Label content;

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

            content = new Label
            {
                Location = new Point(1000, 220), // Adjusted the location for file content display
                AutoSize = true
            };
            this.Controls.Add(content);

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

            if (!string.IsNullOrEmpty(docFilePath))
            {
                string fileContent = ReadExcelFileContents(docFilePath);
                DisplayFileContents(fileContent, BorderStyle);
            }
        }

        private MetroFramework.Forms.MetroFormBorderStyle GetBorderStyle()
        {
            return BorderStyle;
        }

        // Add a method to display file contents
        private void DisplayFileContents(string content, MetroFramework.Forms.MetroFormBorderStyle borderStyle)
        {
            if (fileContents != null)
            {
                fileContents.Text = "File Contents:\n" + content;
                fileContents.AutoSize = false; // Allow multi-line display
                fileContents.Width = 300; // Adjust the width as needed
                fileContents.Height = 200; // Adjust the height as needed for display
                fileContents.Padding = new Padding(5); // Add padding for better appearance
                fileContents.Font = new Font("Arial", 10); // Setting a specific font
            }
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
        private string ReadExcelFileContents(string filePath)
        {
            string content = "";

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
            Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // 첫 번째 시트 선택

            Excel.Range excelRange = excelWorksheet.UsedRange;

            int rowCount = excelRange.Rows.Count;
            int colCount = excelRange.Columns.Count;

            // 이중 for 루프를 사용하여 각 셀의 내용 읽기
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    // 각 셀의 내용을 content에 추가
                    content += excelRange.Cells[i, j].Value2.ToString() + "\t";
                }
                content += "\n"; // 다음 행으로 이동
            }

            // 리소스 정리
            excelWorkbook.Close();
            excelApp.Quit();

            ReleaseObject(excelRange);
            ReleaseObject(excelWorksheet);
            ReleaseObject(excelWorkbook);
            ReleaseObject(excelApp);

            return content;
        }
        private string ReadFileContents(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                try
                {
                    // 파일 내용을 읽어옵니다
                    string fileContents = File.ReadAllText(filePath);

                    // 파일 내용을 데이터로 저장하거나 필요한 작업 수행
                    return fileContents; // 파일 내용 반환
                }
                catch (Exception ex)
                {
                    return $"Error reading file: {ex.Message}";
                }
            }
            return "Invalid file path or file does not exist";
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                // 로깅 또는 예외 처리
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
