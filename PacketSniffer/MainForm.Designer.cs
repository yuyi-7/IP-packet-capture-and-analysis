namespace PacketSniffer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Source_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_TotalLength = new System.Windows.Forms.Label();
            this.lbl_PackCount = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.btn_Open);
            this.panel_Top.Controls.Add(this.btn_Save);
            this.panel_Top.Controls.Add(this.btn_Info);
            this.panel_Top.Controls.Add(this.btn_Clear);
            this.panel_Top.Controls.Add(this.btn_Stop);
            this.panel_Top.Controls.Add(this.btn_Start);
            this.panel_Top.Controls.Add(this.comboBox1);
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(881, 47);
            this.panel_Top.TabIndex = 0;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(698, 15);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 20);
            this.btn_Open.TabIndex = 7;
            this.btn_Open.Text = "打开";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(614, 15);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 20);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(530, 15);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(75, 20);
            this.btn_Info.TabIndex = 5;
            this.btn_Info.Text = "详细信息";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(786, 15);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 20);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "清除显示";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(440, 15);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 20);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "暂停";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(342, 15);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 20);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(83, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择网卡：";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source_ip,
            this.Source_port,
            this.Destination_ip,
            this.Destination_port,
            this.Type,
            this._Time,
            this._Length});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(881, 332);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Source_ip
            // 
            this.Source_ip.HeaderText = "源IP";
            this.Source_ip.Name = "Source_ip";
            this.Source_ip.ReadOnly = true;
            this.Source_ip.Width = 120;
            // 
            // Source_port
            // 
            this.Source_port.HeaderText = "源端口";
            this.Source_port.Name = "Source_port";
            this.Source_port.ReadOnly = true;
            this.Source_port.Width = 120;
            // 
            // Destination_ip
            // 
            this.Destination_ip.HeaderText = "目的IP";
            this.Destination_ip.Name = "Destination_ip";
            this.Destination_ip.ReadOnly = true;
            this.Destination_ip.Width = 120;
            // 
            // Destination_port
            // 
            this.Destination_port.HeaderText = "目的端口";
            this.Destination_port.Name = "Destination_port";
            this.Destination_port.ReadOnly = true;
            this.Destination_port.Width = 120;
            // 
            // Type
            // 
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // _Time
            // 
            this._Time.HeaderText = "时间";
            this._Time.Name = "_Time";
            this._Time.ReadOnly = true;
            this._Time.Width = 120;
            // 
            // _Length
            // 
            this._Length.HeaderText = "长度";
            this._Length.Name = "_Length";
            this._Length.ReadOnly = true;
            this._Length.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Info);
            this.panel1.Controls.Add(this.txt_Data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 172);
            this.panel1.TabIndex = 1;
            // 
            // txt_Info
            // 
            this.txt_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Info.Location = new System.Drawing.Point(585, 0);
            this.txt_Info.Multiline = true;
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ReadOnly = true;
            this.txt_Info.Size = new System.Drawing.Size(296, 172);
            this.txt_Info.TabIndex = 1;
            // 
            // txt_Data
            // 
            this.txt_Data.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_Data.Location = new System.Drawing.Point(0, 0);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(585, 172);
            this.txt_Data.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_TotalLength);
            this.panel2.Controls.Add(this.lbl_PackCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 17);
            this.panel2.TabIndex = 2;
            // 
            // lbl_TotalLength
            // 
            this.lbl_TotalLength.AutoSize = true;
            this.lbl_TotalLength.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TotalLength.Location = new System.Drawing.Point(89, 0);
            this.lbl_TotalLength.Name = "lbl_TotalLength";
            this.lbl_TotalLength.Size = new System.Drawing.Size(89, 12);
            this.lbl_TotalLength.TabIndex = 1;
            this.lbl_TotalLength.Text = "数据包总长度：";
            // 
            // lbl_PackCount
            // 
            this.lbl_PackCount.AutoSize = true;
            this.lbl_PackCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PackCount.Location = new System.Drawing.Point(0, 0);
            this.lbl_PackCount.Name = "lbl_PackCount";
            this.lbl_PackCount.Size = new System.Drawing.Size(89, 12);
            this.lbl_PackCount.TabIndex = 0;
            this.lbl_PackCount.Text = "收到的数据包：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PacketSniffer";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label lbl_TotalLength;
        private System.Windows.Forms.Label lbl_PackCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Length;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
    }
}

