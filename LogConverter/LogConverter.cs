using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace LogConverter
{
    public partial class LogConverter : Form
    {
        string[] files = { "", };
        DataTable dtLogData = new DataTable();

        public LogConverter()
        {
            InitializeComponent();
        }

        private void tb_FIlePath_DragDrop(object sender, DragEventArgs e)
        {
            string Filepath = string.Empty;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string str in files)
                {
                    Filepath += str;
                }
            }

            tb_FIlePath.Text = Filepath;
        }

        private void tb_FIlePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (tb_FIlePath.Text == "")
            {
                MessageBox.Show("파일 경로를 설정하세요", "경로 오류", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            else
            {
                GetLogFile();

                ReadingFile();
            }
        }

        private void GetLogFile()
        {
            try
            {
                files = Directory.GetFiles(tb_FIlePath.Text, "*.*", SearchOption.AllDirectories);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadingFile()
        {
            // 전체를 읽어서 새로운 txt 파일에 저장
            string result = string.Empty;

            for (int i = 0; i < files.Length; ++i)
            {
                StreamReader sr = new StreamReader(files[i]);

                if (!files[i].ToString().Contains("Result"))
                {
                    result += sr.ReadToEnd();
                }
                sr.Close();
            }
            

            if (File.Exists(tb_FIlePath.Text + @"\Result.txt"))
            {
                File.Delete(tb_FIlePath.Text + @"\Result.txt");
            }

            File.WriteAllText(tb_FIlePath.Text + @"\Result.txt", result, Encoding.Default);

            TxtToJson();
        }

        private void TxtToJson()
        {
            string checkedGame = string.Empty;
            
            if (rb_Mir4.Checked == true)
            {
                dtLogData.Columns.Add("Type");
                dtLogData.Columns.Add("Time");
                dtLogData.Columns.Add("Server");
                dtLogData.Columns.Add("Data");

                checkedGame = "Type";
            }

            else if (rb_MirM.Checked == true)
            {
                dtLogData.Columns.Add("LogType");
                dtLogData.Columns.Add("Time");
                dtLogData.Columns.Add("Server");
                dtLogData.Columns.Add("Data");

                checkedGame = "LogType";
            }

            MakeRowData(checkedGame);
        }

        private void MakeRowData(string checkedGameType)
        {
            string line = string.Empty;

            StreamReader sr = new StreamReader(tb_FIlePath.Text + @"\Result.txt", Encoding.Default);

            while ((line = sr.ReadLine()) != null)
            {
                JObject json = JObject.Parse(line);

                dtLogData.Rows.Add($"{json[$"{checkedGameType}"]}", $"{json["Time"]}", $"{json["Server"]}", $"{json["Data"]}");

                dgv_LogConvert.DataSource = dtLogData;
            }
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Search.Text))
            {
                MessageBox.Show("검색어를 입력하세요", "검색", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            else
            {
                string query = string.Empty;

                //DataView dv = new DataView(dt);

                for(int i = 0; i < dgv_LogConvert.Columns.Count; ++i)
                {
                    query += $"`{dgv_LogConvert.Columns[i].Name}` like '%{tb_Search.Text}%' or ";
                }

                query = query.Remove(query.Length - 3, 3);

                dtLogData.DefaultView.RowFilter = $"{query}";
            }
        }

        private void tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(sender, e);
            }
        }
    }
}
