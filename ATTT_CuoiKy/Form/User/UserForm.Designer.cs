
namespace ATTT_CuoiKy
{
    partial class UserForm
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textKT = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textHashGoc = new System.Windows.Forms.RichTextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdMD5KT = new System.Windows.Forms.RadioButton();
            this.rdSHA1KT = new System.Windows.Forms.RadioButton();
            this.rdSHA2KT = new System.Windows.Forms.RadioButton();
            this.rdRIPEMDKT = new System.Windows.Forms.RadioButton();
            this.textTB = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textFile = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKQ = new System.Windows.Forms.RichTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMD5 = new System.Windows.Forms.RadioButton();
            this.rdSHA1 = new System.Windows.Forms.RadioButton();
            this.rdSHA2 = new System.Windows.Forms.RadioButton();
            this.rdRIPEMD = new System.Windows.Forms.RadioButton();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textTB);
            this.tabPage2.Controls.Add(this.textHashGoc);
            this.tabPage2.Controls.Add(this.textKT);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.guna2Button3);
            this.tabPage2.Controls.Add(this.guna2Button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textKT
            // 
            this.textKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKT.Location = new System.Drawing.Point(209, 102);
            this.textKT.Name = "textKT";
            this.textKT.Size = new System.Drawing.Size(300, 79);
            this.textKT.TabIndex = 15;
            this.textKT.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "File cần kiểm tra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã hash file gốc:";
            // 
            // textHashGoc
            // 
            this.textHashGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHashGoc.Location = new System.Drawing.Point(209, 216);
            this.textHashGoc.Name = "textHashGoc";
            this.textHashGoc.Size = new System.Drawing.Size(300, 86);
            this.textHashGoc.TabIndex = 18;
            this.textHashGoc.Text = "";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(529, 124);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(121, 39);
            this.guna2Button4.TabIndex = 19;
            this.guna2Button4.Text = "Chọn File";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(529, 239);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(121, 39);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "Kiểm Tra";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.rdRIPEMDKT);
            this.groupBox2.Controls.Add(this.rdSHA2KT);
            this.groupBox2.Controls.Add(this.rdSHA1KT);
            this.groupBox2.Controls.Add(this.rdMD5KT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 56);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash";
            // 
            // rdMD5KT
            // 
            this.rdMD5KT.AutoSize = true;
            this.rdMD5KT.Location = new System.Drawing.Point(126, 22);
            this.rdMD5KT.Name = "rdMD5KT";
            this.rdMD5KT.Size = new System.Drawing.Size(58, 21);
            this.rdMD5KT.TabIndex = 3;
            this.rdMD5KT.TabStop = true;
            this.rdMD5KT.Text = "MD5";
            this.rdMD5KT.UseVisualStyleBackColor = true;
            // 
            // rdSHA1KT
            // 
            this.rdSHA1KT.AutoSize = true;
            this.rdSHA1KT.Location = new System.Drawing.Point(249, 22);
            this.rdSHA1KT.Name = "rdSHA1KT";
            this.rdSHA1KT.Size = new System.Drawing.Size(70, 21);
            this.rdSHA1KT.TabIndex = 4;
            this.rdSHA1KT.TabStop = true;
            this.rdSHA1KT.Text = "SHA-1";
            this.rdSHA1KT.UseVisualStyleBackColor = true;
            // 
            // rdSHA2KT
            // 
            this.rdSHA2KT.AutoSize = true;
            this.rdSHA2KT.Location = new System.Drawing.Point(367, 22);
            this.rdSHA2KT.Name = "rdSHA2KT";
            this.rdSHA2KT.Size = new System.Drawing.Size(70, 21);
            this.rdSHA2KT.TabIndex = 5;
            this.rdSHA2KT.TabStop = true;
            this.rdSHA2KT.Text = "SHA-2";
            this.rdSHA2KT.UseVisualStyleBackColor = true;
            // 
            // rdRIPEMDKT
            // 
            this.rdRIPEMDKT.AutoSize = true;
            this.rdRIPEMDKT.Location = new System.Drawing.Point(483, 22);
            this.rdRIPEMDKT.Name = "rdRIPEMDKT";
            this.rdRIPEMDKT.Size = new System.Drawing.Size(110, 21);
            this.rdRIPEMDKT.TabIndex = 6;
            this.rdRIPEMDKT.TabStop = true;
            this.rdRIPEMDKT.Text = "RIPEMD-160";
            this.rdRIPEMDKT.UseVisualStyleBackColor = true;
            // 
            // textTB
            // 
            this.textTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTB.Location = new System.Drawing.Point(3, 341);
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(770, 156);
            this.textTB.TabIndex = 22;
            this.textTB.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.guna2Button2);
            this.tabPage1.Controls.Add(this.guna2Button1);
            this.tabPage1.Controls.Add(this.textKQ);
            this.tabPage1.Controls.Add(this.textFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textFile
            // 
            this.textFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFile.Location = new System.Drawing.Point(181, 170);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(300, 79);
            this.textFile.TabIndex = 1;
            this.textFile.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "File nguồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả:";
            // 
            // textKQ
            // 
            this.textKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKQ.Location = new System.Drawing.Point(181, 284);
            this.textKQ.Name = "textKQ";
            this.textKQ.Size = new System.Drawing.Size(300, 86);
            this.textKQ.TabIndex = 4;
            this.textKQ.Text = "";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(501, 192);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(121, 39);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Chọn File";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(501, 307);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(121, 39);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Mã Hóa";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRIPEMD);
            this.groupBox1.Controls.Add(this.rdSHA2);
            this.groupBox1.Controls.Add(this.rdSHA1);
            this.groupBox1.Controls.Add(this.rdMD5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 56);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash";
            // 
            // rdMD5
            // 
            this.rdMD5.AutoSize = true;
            this.rdMD5.Location = new System.Drawing.Point(6, 21);
            this.rdMD5.Name = "rdMD5";
            this.rdMD5.Size = new System.Drawing.Size(58, 21);
            this.rdMD5.TabIndex = 3;
            this.rdMD5.TabStop = true;
            this.rdMD5.Text = "MD5";
            this.rdMD5.UseVisualStyleBackColor = true;
            // 
            // rdSHA1
            // 
            this.rdSHA1.AutoSize = true;
            this.rdSHA1.Location = new System.Drawing.Point(129, 21);
            this.rdSHA1.Name = "rdSHA1";
            this.rdSHA1.Size = new System.Drawing.Size(70, 21);
            this.rdSHA1.TabIndex = 4;
            this.rdSHA1.TabStop = true;
            this.rdSHA1.Text = "SHA-1";
            this.rdSHA1.UseVisualStyleBackColor = true;
            // 
            // rdSHA2
            // 
            this.rdSHA2.AutoSize = true;
            this.rdSHA2.Location = new System.Drawing.Point(247, 21);
            this.rdSHA2.Name = "rdSHA2";
            this.rdSHA2.Size = new System.Drawing.Size(70, 21);
            this.rdSHA2.TabIndex = 5;
            this.rdSHA2.TabStop = true;
            this.rdSHA2.Text = "SHA-2";
            this.rdSHA2.UseVisualStyleBackColor = true;
            // 
            // rdRIPEMD
            // 
            this.rdRIPEMD.AutoSize = true;
            this.rdRIPEMD.Location = new System.Drawing.Point(363, 21);
            this.rdRIPEMD.Name = "rdRIPEMD";
            this.rdRIPEMD.Size = new System.Drawing.Size(110, 21);
            this.rdRIPEMD.TabIndex = 6;
            this.rdRIPEMD.TabStop = true;
            this.rdRIPEMD.Text = "RIPEMD-160";
            this.rdRIPEMD.UseVisualStyleBackColor = true;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(964, 508);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(627, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(627, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 17);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Đăng xuất";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 508);
            this.Controls.Add(this.guna2TabControl1);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox textTB;
        private System.Windows.Forms.RichTextBox textHashGoc;
        private System.Windows.Forms.RichTextBox textKT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdRIPEMDKT;
        private System.Windows.Forms.RadioButton rdSHA2KT;
        private System.Windows.Forms.RadioButton rdSHA1KT;
        private System.Windows.Forms.RadioButton rdMD5KT;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRIPEMD;
        private System.Windows.Forms.RadioButton rdSHA2;
        private System.Windows.Forms.RadioButton rdSHA1;
        private System.Windows.Forms.RadioButton rdMD5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RichTextBox textKQ;
        private System.Windows.Forms.RichTextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}