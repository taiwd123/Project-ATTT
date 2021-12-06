
namespace ATTT_CuoiKy
{
    partial class DangKy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRIPEMD = new System.Windows.Forms.RadioButton();
            this.rdSHA2 = new System.Windows.Forms.RadioButton();
            this.rdSHA1 = new System.Windows.Forms.RadioButton();
            this.rdMD5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textConf = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRIPEMD);
            this.groupBox1.Controls.Add(this.rdSHA2);
            this.groupBox1.Controls.Add(this.rdSHA1);
            this.groupBox1.Controls.Add(this.rdMD5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 534);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // textPass
            // 
            this.textPass.BorderRadius = 20;
            this.textPass.BorderThickness = 2;
            this.textPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPass.CustomizableEdges.BottomLeft = false;
            this.textPass.CustomizableEdges.BottomRight = false;
            this.textPass.CustomizableEdges.TopLeft = false;
            this.textPass.CustomizableEdges.TopRight = false;
            this.textPass.DefaultText = "";
            this.textPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.DisabledState.Parent = this.textPass;
            this.textPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.FocusedState.Parent = this.textPass;
            this.textPass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textPass.ForeColor = System.Drawing.Color.Black;
            this.textPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.textPass.HoverState.Parent = this.textPass;
            this.textPass.Location = new System.Drawing.Point(241, 385);
            this.textPass.Margin = new System.Windows.Forms.Padding(6);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.PlaceholderText = "";
            this.textPass.SelectedText = "";
            this.textPass.ShadowDecoration.Parent = this.textPass;
            this.textPass.Size = new System.Drawing.Size(300, 50);
            this.textPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // textUser
            // 
            this.textUser.BorderRadius = 20;
            this.textUser.BorderThickness = 2;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.CustomizableEdges.BottomLeft = false;
            this.textUser.CustomizableEdges.BottomRight = false;
            this.textUser.CustomizableEdges.TopLeft = false;
            this.textUser.CustomizableEdges.TopRight = false;
            this.textUser.DefaultText = "";
            this.textUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.DisabledState.Parent = this.textUser;
            this.textUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textUser.FocusedState.Parent = this.textUser;
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textUser.ForeColor = System.Drawing.Color.Black;
            this.textUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.textUser.HoverState.Parent = this.textUser;
            this.textUser.Location = new System.Drawing.Point(241, 315);
            this.textUser.Margin = new System.Windows.Forms.Padding(6);
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.PlaceholderText = "";
            this.textUser.SelectedText = "";
            this.textUser.ShadowDecoration.Parent = this.textUser;
            this.textUser.Size = new System.Drawing.Size(300, 50);
            this.textUser.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(14, 671);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have account? ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(202, 616);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(200, 50);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Đăng Ký";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm:";
            // 
            // textConf
            // 
            this.textConf.BorderRadius = 20;
            this.textConf.BorderThickness = 2;
            this.textConf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textConf.CustomizableEdges.BottomLeft = false;
            this.textConf.CustomizableEdges.BottomRight = false;
            this.textConf.CustomizableEdges.TopLeft = false;
            this.textConf.CustomizableEdges.TopRight = false;
            this.textConf.DefaultText = "";
            this.textConf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textConf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textConf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textConf.DisabledState.Parent = this.textConf;
            this.textConf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textConf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textConf.FocusedState.Parent = this.textConf;
            this.textConf.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textConf.ForeColor = System.Drawing.Color.Black;
            this.textConf.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.textConf.HoverState.Parent = this.textConf;
            this.textConf.Location = new System.Drawing.Point(241, 458);
            this.textConf.Margin = new System.Windows.Forms.Padding(6);
            this.textConf.Name = "textConf";
            this.textConf.PasswordChar = '*';
            this.textConf.PlaceholderText = "";
            this.textConf.SelectedText = "";
            this.textConf.ShadowDecoration.Parent = this.textConf;
            this.textConf.Size = new System.Drawing.Size(300, 50);
            this.textConf.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::ATTT_CuoiKy.Properties.Resources.default_DDLK_avatar;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(180, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textConf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2Button1);
            this.MaximizeBox = false;
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangKy_FormClosed);
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRIPEMD;
        private System.Windows.Forms.RadioButton rdSHA2;
        private System.Windows.Forms.RadioButton rdSHA1;
        private System.Windows.Forms.RadioButton rdMD5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textConf;
    }
}