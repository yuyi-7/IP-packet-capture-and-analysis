namespace PacketSniffer
{
    partial class PackInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_TOS = new System.Windows.Forms.Panel();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.panel_DATA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Version = new System.Windows.Forms.Button();
            this.lbl_HeadLength = new System.Windows.Forms.Button();
            this.lbl_TOS = new System.Windows.Forms.Button();
            this.lbl_TotalLength = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Button();
            this.lbl_Flag = new System.Windows.Forms.Button();
            this.lbl_FragOffset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_TTL = new System.Windows.Forms.Button();
            this.lbl_Protocol = new System.Windows.Forms.Button();
            this.lbl_HeadCheckSum = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Src_IP = new System.Windows.Forms.Button();
            this.lbl_Des_IP = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Options = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Button();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_Pri = new System.Windows.Forms.Button();
            this.lbl_D = new System.Windows.Forms.Button();
            this.lbl_T = new System.Windows.Forms.Button();
            this.lbl_R = new System.Windows.Forms.Button();
            this.lbl_C = new System.Windows.Forms.Button();
            this.lbl_NULL = new System.Windows.Forms.Button();
            this.panel_TOS.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.panel_DATA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TOS
            // 
            this.panel_TOS.Controls.Add(this.panel7);
            this.panel_TOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TOS.Location = new System.Drawing.Point(0, 0);
            this.panel_TOS.Name = "panel_TOS";
            this.panel_TOS.Size = new System.Drawing.Size(800, 108);
            this.panel_TOS.TabIndex = 0;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.panel6);
            this.panel_Info.Controls.Add(this.panel5);
            this.panel_Info.Controls.Add(this.panel4);
            this.panel_Info.Controls.Add(this.panel3);
            this.panel_Info.Controls.Add(this.panel2);
            this.panel_Info.Controls.Add(this.panel1);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(0, 108);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(800, 296);
            this.panel_Info.TabIndex = 1;
            // 
            // panel_DATA
            // 
            this.panel_DATA.Controls.Add(this.txt_Data);
            this.panel_DATA.Controls.Add(this.lbl_Data);
            this.panel_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DATA.Location = new System.Drawing.Point(0, 404);
            this.panel_DATA.Name = "panel_DATA";
            this.panel_DATA.Size = new System.Drawing.Size(800, 122);
            this.panel_DATA.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_TotalLength);
            this.panel1.Controls.Add(this.lbl_TOS);
            this.panel1.Controls.Add(this.lbl_HeadLength);
            this.panel1.Controls.Add(this.lbl_Version);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Version.Enabled = false;
            this.lbl_Version.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Version.Location = new System.Drawing.Point(0, 0);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(100, 40);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "版本号：";
            this.lbl_Version.UseVisualStyleBackColor = true;
            // 
            // lbl_HeadLength
            // 
            this.lbl_HeadLength.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_HeadLength.Enabled = false;
            this.lbl_HeadLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_HeadLength.Location = new System.Drawing.Point(100, 0);
            this.lbl_HeadLength.Name = "lbl_HeadLength";
            this.lbl_HeadLength.Size = new System.Drawing.Size(100, 40);
            this.lbl_HeadLength.TabIndex = 1;
            this.lbl_HeadLength.Text = "头部长度：";
            this.lbl_HeadLength.UseVisualStyleBackColor = true;
            // 
            // lbl_TOS
            // 
            this.lbl_TOS.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TOS.Enabled = false;
            this.lbl_TOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_TOS.Location = new System.Drawing.Point(200, 0);
            this.lbl_TOS.Name = "lbl_TOS";
            this.lbl_TOS.Size = new System.Drawing.Size(200, 40);
            this.lbl_TOS.TabIndex = 2;
            this.lbl_TOS.Text = "服务类型：";
            this.lbl_TOS.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalLength
            // 
            this.lbl_TotalLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TotalLength.Enabled = false;
            this.lbl_TotalLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_TotalLength.Location = new System.Drawing.Point(400, 0);
            this.lbl_TotalLength.Name = "lbl_TotalLength";
            this.lbl_TotalLength.Size = new System.Drawing.Size(400, 40);
            this.lbl_TotalLength.TabIndex = 3;
            this.lbl_TotalLength.Text = "总长度：";
            this.lbl_TotalLength.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_FragOffset);
            this.panel2.Controls.Add(this.lbl_Flag);
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Title.Enabled = false;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(400, 40);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "标识：";
            this.lbl_Title.UseVisualStyleBackColor = true;
            // 
            // lbl_Flag
            // 
            this.lbl_Flag.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Flag.Enabled = false;
            this.lbl_Flag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Flag.Location = new System.Drawing.Point(400, 0);
            this.lbl_Flag.Name = "lbl_Flag";
            this.lbl_Flag.Size = new System.Drawing.Size(100, 40);
            this.lbl_Flag.TabIndex = 4;
            this.lbl_Flag.Text = "标志：";
            this.lbl_Flag.UseVisualStyleBackColor = true;
            // 
            // lbl_FragOffset
            // 
            this.lbl_FragOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FragOffset.Enabled = false;
            this.lbl_FragOffset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_FragOffset.Location = new System.Drawing.Point(500, 0);
            this.lbl_FragOffset.Name = "lbl_FragOffset";
            this.lbl_FragOffset.Size = new System.Drawing.Size(300, 40);
            this.lbl_FragOffset.TabIndex = 5;
            this.lbl_FragOffset.Text = "片偏移：";
            this.lbl_FragOffset.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_HeadCheckSum);
            this.panel3.Controls.Add(this.lbl_Protocol);
            this.panel3.Controls.Add(this.lbl_TTL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 40);
            this.panel3.TabIndex = 2;
            // 
            // lbl_TTL
            // 
            this.lbl_TTL.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_TTL.Enabled = false;
            this.lbl_TTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_TTL.Location = new System.Drawing.Point(0, 0);
            this.lbl_TTL.Name = "lbl_TTL";
            this.lbl_TTL.Size = new System.Drawing.Size(200, 40);
            this.lbl_TTL.TabIndex = 3;
            this.lbl_TTL.Text = "生存时间(TTL)：";
            this.lbl_TTL.UseVisualStyleBackColor = true;
            // 
            // lbl_Protocol
            // 
            this.lbl_Protocol.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Protocol.Enabled = false;
            this.lbl_Protocol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Protocol.Location = new System.Drawing.Point(200, 0);
            this.lbl_Protocol.Name = "lbl_Protocol";
            this.lbl_Protocol.Size = new System.Drawing.Size(200, 40);
            this.lbl_Protocol.TabIndex = 4;
            this.lbl_Protocol.Text = "协议：";
            this.lbl_Protocol.UseVisualStyleBackColor = true;
            // 
            // lbl_HeadCheckSum
            // 
            this.lbl_HeadCheckSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_HeadCheckSum.Enabled = false;
            this.lbl_HeadCheckSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_HeadCheckSum.Location = new System.Drawing.Point(400, 0);
            this.lbl_HeadCheckSum.Name = "lbl_HeadCheckSum";
            this.lbl_HeadCheckSum.Size = new System.Drawing.Size(400, 40);
            this.lbl_HeadCheckSum.TabIndex = 5;
            this.lbl_HeadCheckSum.Text = "头部校验和：";
            this.lbl_HeadCheckSum.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_Src_IP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 40);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_Des_IP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 40);
            this.panel5.TabIndex = 4;
            // 
            // lbl_Src_IP
            // 
            this.lbl_Src_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Src_IP.Enabled = false;
            this.lbl_Src_IP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Src_IP.Location = new System.Drawing.Point(0, 0);
            this.lbl_Src_IP.Name = "lbl_Src_IP";
            this.lbl_Src_IP.Size = new System.Drawing.Size(800, 40);
            this.lbl_Src_IP.TabIndex = 0;
            this.lbl_Src_IP.Text = "源IP：";
            this.lbl_Src_IP.UseVisualStyleBackColor = true;
            // 
            // lbl_Des_IP
            // 
            this.lbl_Des_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Des_IP.Enabled = false;
            this.lbl_Des_IP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Des_IP.Location = new System.Drawing.Point(0, 0);
            this.lbl_Des_IP.Name = "lbl_Des_IP";
            this.lbl_Des_IP.Size = new System.Drawing.Size(800, 40);
            this.lbl_Des_IP.TabIndex = 1;
            this.lbl_Des_IP.Text = "目的IP：";
            this.lbl_Des_IP.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_Options);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 96);
            this.panel6.TabIndex = 5;
            // 
            // lbl_Options
            // 
            this.lbl_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Options.Enabled = false;
            this.lbl_Options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Options.Location = new System.Drawing.Point(0, 0);
            this.lbl_Options.Name = "lbl_Options";
            this.lbl_Options.Size = new System.Drawing.Size(800, 96);
            this.lbl_Options.TabIndex = 2;
            this.lbl_Options.Text = "选项：";
            this.lbl_Options.UseVisualStyleBackColor = true;
            // 
            // lbl_Data
            // 
            this.lbl_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Data.Enabled = false;
            this.lbl_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Data.Location = new System.Drawing.Point(0, 0);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(800, 23);
            this.lbl_Data.TabIndex = 0;
            this.lbl_Data.Text = "DATA：";
            this.lbl_Data.UseVisualStyleBackColor = true;
            // 
            // txt_Data
            // 
            this.txt_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Data.Location = new System.Drawing.Point(0, 23);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(800, 99);
            this.txt_Data.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_NULL);
            this.panel7.Controls.Add(this.lbl_C);
            this.panel7.Controls.Add(this.lbl_R);
            this.panel7.Controls.Add(this.lbl_T);
            this.panel7.Controls.Add(this.lbl_D);
            this.panel7.Controls.Add(this.lbl_Pri);
            this.panel7.Location = new System.Drawing.Point(200, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(439, 42);
            this.panel7.TabIndex = 0;
            // 
            // lbl_Pri
            // 
            this.lbl_Pri.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Pri.Enabled = false;
            this.lbl_Pri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Pri.Location = new System.Drawing.Point(0, 0);
            this.lbl_Pri.Name = "lbl_Pri";
            this.lbl_Pri.Size = new System.Drawing.Size(120, 42);
            this.lbl_Pri.TabIndex = 1;
            this.lbl_Pri.Text = "优先级(0->7)：";
            this.lbl_Pri.UseVisualStyleBackColor = true;
            // 
            // lbl_D
            // 
            this.lbl_D.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_D.Enabled = false;
            this.lbl_D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_D.Location = new System.Drawing.Point(120, 0);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(60, 42);
            this.lbl_D.TabIndex = 2;
            this.lbl_D.Text = "D：";
            this.lbl_D.UseVisualStyleBackColor = true;
            // 
            // lbl_T
            // 
            this.lbl_T.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_T.Enabled = false;
            this.lbl_T.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_T.Location = new System.Drawing.Point(180, 0);
            this.lbl_T.Name = "lbl_T";
            this.lbl_T.Size = new System.Drawing.Size(60, 42);
            this.lbl_T.TabIndex = 3;
            this.lbl_T.Text = "T：";
            this.lbl_T.UseVisualStyleBackColor = true;
            // 
            // lbl_R
            // 
            this.lbl_R.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_R.Enabled = false;
            this.lbl_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_R.Location = new System.Drawing.Point(240, 0);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(60, 42);
            this.lbl_R.TabIndex = 4;
            this.lbl_R.Text = "R：";
            this.lbl_R.UseVisualStyleBackColor = true;
            // 
            // lbl_C
            // 
            this.lbl_C.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_C.Enabled = false;
            this.lbl_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_C.Location = new System.Drawing.Point(300, 0);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(60, 42);
            this.lbl_C.TabIndex = 5;
            this.lbl_C.Text = "C：";
            this.lbl_C.UseVisualStyleBackColor = true;
            // 
            // lbl_NULL
            // 
            this.lbl_NULL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NULL.Enabled = false;
            this.lbl_NULL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_NULL.Location = new System.Drawing.Point(360, 0);
            this.lbl_NULL.Name = "lbl_NULL";
            this.lbl_NULL.Size = new System.Drawing.Size(79, 42);
            this.lbl_NULL.TabIndex = 6;
            this.lbl_NULL.Text = "未使用";
            this.lbl_NULL.UseVisualStyleBackColor = true;
            // 
            // PackInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.panel_DATA);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_TOS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackInfo";
            this.Text = "详细信息";
            this.panel_TOS.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.panel_DATA.ResumeLayout(false);
            this.panel_DATA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TOS;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel panel_DATA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lbl_Version;
        private System.Windows.Forms.Button lbl_TotalLength;
        private System.Windows.Forms.Button lbl_TOS;
        private System.Windows.Forms.Button lbl_HeadLength;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lbl_FragOffset;
        private System.Windows.Forms.Button lbl_Flag;
        private System.Windows.Forms.Button lbl_Title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button lbl_HeadCheckSum;
        private System.Windows.Forms.Button lbl_Protocol;
        private System.Windows.Forms.Button lbl_TTL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button lbl_Des_IP;
        private System.Windows.Forms.Button lbl_Src_IP;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button lbl_Options;
        private System.Windows.Forms.Button lbl_Data;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button lbl_NULL;
        private System.Windows.Forms.Button lbl_C;
        private System.Windows.Forms.Button lbl_R;
        private System.Windows.Forms.Button lbl_T;
        private System.Windows.Forms.Button lbl_D;
        private System.Windows.Forms.Button lbl_Pri;
    }
}