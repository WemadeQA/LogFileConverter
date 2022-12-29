
namespace LogConverter
{
    partial class LogConverter
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.tb_FIlePath = new System.Windows.Forms.TextBox();
            this.dgv_LogConvert = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pn_Game = new System.Windows.Forms.Panel();
            this.rb_Mir4 = new System.Windows.Forms.RadioButton();
            this.rb_MirM = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogConvert)).BeginInit();
            this.pn_Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Convert.BackColor = System.Drawing.Color.White;
            this.btn_Convert.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Convert.Location = new System.Drawing.Point(275, 34);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "변환";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // tb_FIlePath
            // 
            this.tb_FIlePath.AllowDrop = true;
            this.tb_FIlePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_FIlePath.Location = new System.Drawing.Point(12, 34);
            this.tb_FIlePath.Name = "tb_FIlePath";
            this.tb_FIlePath.Size = new System.Drawing.Size(257, 21);
            this.tb_FIlePath.TabIndex = 1;
            this.tb_FIlePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_FIlePath_DragDrop);
            this.tb_FIlePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_FIlePath_DragEnter);
            // 
            // dgv_LogConvert
            // 
            this.dgv_LogConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LogConvert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LogConvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogConvert.Location = new System.Drawing.Point(13, 63);
            this.dgv_LogConvert.Name = "dgv_LogConvert";
            this.dgv_LogConvert.RowTemplate.Height = 23;
            this.dgv_LogConvert.Size = new System.Drawing.Size(805, 375);
            this.dgv_LogConvert.TabIndex = 2;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(571, 36);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(166, 21);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Location = new System.Drawing.Point(743, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pn_Game
            // 
            this.pn_Game.Controls.Add(this.rb_MirM);
            this.pn_Game.Controls.Add(this.rb_Mir4);
            this.pn_Game.Location = new System.Drawing.Point(12, 2);
            this.pn_Game.Name = "pn_Game";
            this.pn_Game.Size = new System.Drawing.Size(365, 26);
            this.pn_Game.TabIndex = 5;
            // 
            // rb_Mir4
            // 
            this.rb_Mir4.AutoSize = true;
            this.rb_Mir4.Location = new System.Drawing.Point(4, 5);
            this.rb_Mir4.Name = "rb_Mir4";
            this.rb_Mir4.Size = new System.Drawing.Size(53, 16);
            this.rb_Mir4.TabIndex = 0;
            this.rb_Mir4.TabStop = true;
            this.rb_Mir4.Text = "미르4";
            this.rb_Mir4.UseVisualStyleBackColor = true;
            // 
            // rb_MirM
            // 
            this.rb_MirM.AutoSize = true;
            this.rb_MirM.Checked = true;
            this.rb_MirM.Location = new System.Drawing.Point(63, 5);
            this.rb_MirM.Name = "rb_MirM";
            this.rb_MirM.Size = new System.Drawing.Size(58, 16);
            this.rb_MirM.TabIndex = 1;
            this.rb_MirM.TabStop = true;
            this.rb_MirM.Text = "미르M";
            this.rb_MirM.UseVisualStyleBackColor = true;
            // 
            // LogConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.pn_Game);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_LogConvert);
            this.Controls.Add(this.tb_FIlePath);
            this.Controls.Add(this.btn_Convert);
            this.Name = "LogConverter";
            this.Text = "LogConverter";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogConvert)).EndInit();
            this.pn_Game.ResumeLayout(false);
            this.pn_Game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox tb_FIlePath;
        private System.Windows.Forms.DataGridView dgv_LogConvert;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pn_Game;
        private System.Windows.Forms.RadioButton rb_MirM;
        private System.Windows.Forms.RadioButton rb_Mir4;
    }
}

