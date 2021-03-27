
namespace login_register
{
    partial class Giriş
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_Kayıt = new System.Windows.Forms.Button();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Giris.BackgroundImage")));
            this.btn_Giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Location = new System.Drawing.Point(395, 252);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(140, 45);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_Kayıt
            // 
            this.btn_Kayıt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kayıt.BackgroundImage")));
            this.btn_Kayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Kayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kayıt.Location = new System.Drawing.Point(256, 262);
            this.btn_Kayıt.Name = "btn_Kayıt";
            this.btn_Kayıt.Size = new System.Drawing.Size(133, 35);
            this.btn_Kayıt.TabIndex = 3;
            this.btn_Kayıt.UseVisualStyleBackColor = true;
            this.btn_Kayıt.Click += new System.EventHandler(this.btn_Kayıt_Click);
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Name.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Name.Location = new System.Drawing.Point(272, 129);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(183, 22);
            this.txtBox_Name.TabIndex = 0;
            this.txtBox_Name.Text = "Kullanıcı Adı";
            this.txtBox_Name.Click += new System.EventHandler(this.txtBox_Name_Click);
            this.txtBox_Name.Leave += new System.EventHandler(this.txtBox_Name_Leave);
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Pass.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Pass.Location = new System.Drawing.Point(272, 164);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.Size = new System.Drawing.Size(183, 22);
            this.txtBox_Pass.TabIndex = 1;
            this.txtBox_Pass.Text = "Şifre";
            this.txtBox_Pass.Click += new System.EventHandler(this.txtBox_Pass_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(210, 284);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.btn_Kayıt);
            this.Controls.Add(this.btn_Giris);
            this.MaximizeBox = false;
            this.Name = "Giriş";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_Kayıt;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

