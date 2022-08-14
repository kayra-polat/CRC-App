namespace CRC_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.msg_box = new System.Windows.Forms.TextBox();
            this.btn_crc16 = new System.Windows.Forms.Button();
            this.btn_crc32 = new System.Windows.Forms.Button();
            this.output_box = new System.Windows.Forms.ListBox();
            this.radiobtn_SimpleCrc = new System.Windows.Forms.RadioButton();
            this.radiobtn_LookupTable = new System.Windows.Forms.RadioButton();
            this.comboBox_inpver = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.choose_box = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel1.Controls.Add(this.choose_box);
            this.splitContainer1.Panel1.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_back);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_inpver);
            this.splitContainer1.Panel1.Controls.Add(this.radiobtn_LookupTable);
            this.splitContainer1.Panel1.Controls.Add(this.radiobtn_SimpleCrc);
            this.splitContainer1.Panel1.Controls.Add(this.btn_crc32);
            this.splitContainer1.Panel1.Controls.Add(this.btn_crc16);
            this.splitContainer1.Panel1.Controls.Add(this.msg_box);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_msg);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.output_box);
            this.splitContainer1.Size = new System.Drawing.Size(675, 442);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(12, 45);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(135, 17);
            this.lbl_msg.TabIndex = 0;
            this.lbl_msg.Text = "Write your Message:";
            // 
            // msg_box
            // 
            this.msg_box.Location = new System.Drawing.Point(15, 71);
            this.msg_box.Name = "msg_box";
            this.msg_box.Size = new System.Drawing.Size(427, 20);
            this.msg_box.TabIndex = 1;
            // 
            // btn_crc16
            // 
            this.btn_crc16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_crc16.Location = new System.Drawing.Point(15, 107);
            this.btn_crc16.Name = "btn_crc16";
            this.btn_crc16.Size = new System.Drawing.Size(75, 23);
            this.btn_crc16.TabIndex = 2;
            this.btn_crc16.Text = "CRC-16";
            this.btn_crc16.UseVisualStyleBackColor = true;
            this.btn_crc16.Click += new System.EventHandler(this.btn_crc16_Click);
            // 
            // btn_crc32
            // 
            this.btn_crc32.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_crc32.Location = new System.Drawing.Point(116, 107);
            this.btn_crc32.Name = "btn_crc32";
            this.btn_crc32.Size = new System.Drawing.Size(75, 23);
            this.btn_crc32.TabIndex = 3;
            this.btn_crc32.Text = "CRC-32";
            this.btn_crc32.UseVisualStyleBackColor = true;
            this.btn_crc32.Click += new System.EventHandler(this.btn_crc32_Click_1);
            // 
            // output_box
            // 
            this.output_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.output_box.FormattingEnabled = true;
            this.output_box.ItemHeight = 15;
            this.output_box.Location = new System.Drawing.Point(0, 3);
            this.output_box.Name = "output_box";
            this.output_box.ScrollAlwaysVisible = true;
            this.output_box.Size = new System.Drawing.Size(675, 259);
            this.output_box.TabIndex = 0;
            // 
            // radiobtn_SimpleCrc
            // 
            this.radiobtn_SimpleCrc.AutoSize = true;
            this.radiobtn_SimpleCrc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtn_SimpleCrc.ForeColor = System.Drawing.Color.White;
            this.radiobtn_SimpleCrc.Location = new System.Drawing.Point(238, 106);
            this.radiobtn_SimpleCrc.Name = "radiobtn_SimpleCrc";
            this.radiobtn_SimpleCrc.Size = new System.Drawing.Size(82, 19);
            this.radiobtn_SimpleCrc.TabIndex = 4;
            this.radiobtn_SimpleCrc.TabStop = true;
            this.radiobtn_SimpleCrc.Text = "Simple Crc";
            this.radiobtn_SimpleCrc.UseVisualStyleBackColor = true;
            // 
            // radiobtn_LookupTable
            // 
            this.radiobtn_LookupTable.AutoSize = true;
            this.radiobtn_LookupTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtn_LookupTable.ForeColor = System.Drawing.Color.White;
            this.radiobtn_LookupTable.Location = new System.Drawing.Point(238, 131);
            this.radiobtn_LookupTable.Name = "radiobtn_LookupTable";
            this.radiobtn_LookupTable.Size = new System.Drawing.Size(95, 19);
            this.radiobtn_LookupTable.TabIndex = 5;
            this.radiobtn_LookupTable.TabStop = true;
            this.radiobtn_LookupTable.Text = "Lookup Table";
            this.radiobtn_LookupTable.UseVisualStyleBackColor = true;
            // 
            // comboBox_inpver
            // 
            this.comboBox_inpver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_inpver.FormattingEnabled = true;
            this.comboBox_inpver.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.comboBox_inpver.Location = new System.Drawing.Point(519, 70);
            this.comboBox_inpver.Name = "comboBox_inpver";
            this.comboBox_inpver.Size = new System.Drawing.Size(121, 23);
            this.comboBox_inpver.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(15, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(48, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "<Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(625, 148);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // choose_box
            // 
            this.choose_box.AutoSize = true;
            this.choose_box.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choose_box.ForeColor = System.Drawing.Color.White;
            this.choose_box.Location = new System.Drawing.Point(516, 47);
            this.choose_box.Name = "choose_box";
            this.choose_box.Size = new System.Drawing.Size(127, 17);
            this.choose_box.TabIndex = 9;
            this.choose_box.Text = "Choose Input Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 442);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CRC-16/CRC-32";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox msg_box;
        private System.Windows.Forms.Button btn_crc16;
        private System.Windows.Forms.Button btn_crc32;
        private System.Windows.Forms.ListBox output_box;
        private System.Windows.Forms.RadioButton radiobtn_LookupTable;
        private System.Windows.Forms.RadioButton radiobtn_SimpleCrc;
        private System.Windows.Forms.ComboBox comboBox_inpver;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label choose_box;
    }
}

