
namespace ATTT_CuoiKy
{
    partial class DangNhap
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
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
            this.groupBox1.Location = new System.Drawing.Point(61, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 56);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash";
            // 
            // rdRIPEMD
            // 
            this.rdRIPEMD.AutoSize = true;
            this.rdRIPEMD.Location = new System.Drawing.Point(363, 21);
            this.rdRIPEMD.Name = "rdRIPEMD";
            this.rdRIPEMD.Size = new System.Drawing.Size(110, 21);
            this.rdRIPEMD.TabIndex = 5;
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
            this.rdSHA2.TabIndex = 4;
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
            this.rdSHA1.TabIndex = 3;
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
            this.rdMD5.TabIndex = 2;
            this.rdMD5.TabStop = true;
            this.rdMD5.Text = "MD5";
            this.rdMD5.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::ATTT_CuoiKy.Properties.Resources.default_DDLK_avatar;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(189, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            // 
            // TextPass
            // 
            this.TextPass.BorderRadius = 20;
            this.TextPass.BorderThickness = 2;
            this.TextPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPass.CustomizableEdges.BottomLeft = false;
            this.TextPass.CustomizableEdges.BottomRight = false;
            this.TextPass.CustomizableEdges.TopLeft = false;
            this.TextPass.CustomizableEdges.TopRight = false;
            this.TextPass.DefaultText = "";
            this.TextPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPass.DisabledState.Parent = this.TextPass;
            this.TextPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPass.FocusedState.Parent = this.TextPass;
            this.TextPass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TextPass.ForeColor = System.Drawing.Color.Black;
            this.TextPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TextPass.HoverState.Parent = this.TextPass;
            this.TextPass.Location = new System.Drawing.Point(250, 388);
            this.TextPass.Margin = new System.Windows.Forms.Padding(6);
            this.TextPass.Name = "TextPass";
            this.TextPass.PasswordChar = '*';
            this.TextPass.PlaceholderText = "";
            this.TextPass.SelectedText = "";
            this.TextPass.ShadowDecoration.Parent = this.TextPass;
            this.TextPass.Size = new System.Drawing.Size(300, 50);
            this.TextPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username:";
            // 
            // TextUser
            // 
            this.TextUser.BorderRadius = 20;
            this.TextUser.BorderThickness = 2;
            this.TextUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextUser.CustomizableEdges.BottomLeft = false;
            this.TextUser.CustomizableEdges.BottomRight = false;
            this.TextUser.CustomizableEdges.TopLeft = false;
            this.TextUser.CustomizableEdges.TopRight = false;
            this.TextUser.DefaultText = "";
            this.TextUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUser.DisabledState.Parent = this.TextUser;
            this.TextUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextUser.FocusedState.Parent = this.TextUser;
            this.TextUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TextUser.ForeColor = System.Drawing.Color.Black;
            this.TextUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TextUser.HoverState.Parent = this.TextUser;
            this.TextUser.Location = new System.Drawing.Point(250, 318);
            this.TextUser.Margin = new System.Windows.Forms.Padding(6);
            this.TextUser.Name = "TextUser";
            this.TextUser.PasswordChar = '\0';
            this.TextUser.PlaceholderText = "";
            this.TextUser.SelectedText = "";
            this.TextUser.ShadowDecoration.Parent = this.TextUser;
            this.TextUser.Size = new System.Drawing.Size(300, 50);
            this.TextUser.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(25, 606);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 10;
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.DisabledState.Parent = this.btnDangNhap;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(213, 551);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(200, 50);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDangNhap);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
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
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextUser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
    }
}