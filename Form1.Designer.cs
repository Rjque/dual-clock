namespace Clock
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LABsec1 = new System.Windows.Forms.Label();
            this.PBOXclock = new System.Windows.Forms.PictureBox();
            this.Tseg = new System.Windows.Forms.Timer(this.components);
            this.LABtime = new System.Windows.Forms.Label();
            this.LABsec2 = new System.Windows.Forms.Label();
            this.LABsec3 = new System.Windows.Forms.Label();
            this.LABsec4 = new System.Windows.Forms.Label();
            this.LABsec5 = new System.Windows.Forms.Label();
            this.LABsec6 = new System.Windows.Forms.Label();
            this.LABmin1 = new System.Windows.Forms.Label();
            this.LABmin2 = new System.Windows.Forms.Label();
            this.LABmin3 = new System.Windows.Forms.Label();
            this.LABmin4 = new System.Windows.Forms.Label();
            this.LABmin5 = new System.Windows.Forms.Label();
            this.LABhor3 = new System.Windows.Forms.Label();
            this.LABhor2 = new System.Windows.Forms.Label();
            this.LABhor1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBOXclock)).BeginInit();
            this.SuspendLayout();
            // 
            // LABsec1
            // 
            this.LABsec1.AutoSize = true;
            this.LABsec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec1.Location = new System.Drawing.Point(258, 70);
            this.LABsec1.Name = "LABsec1";
            this.LABsec1.Size = new System.Drawing.Size(21, 16);
            this.LABsec1.TabIndex = 0;
            this.LABsec1.Text = "01";
            // 
            // PBOXclock
            // 
            this.PBOXclock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBOXclock.Image = ((System.Drawing.Image)(resources.GetObject("PBOXclock.Image")));
            this.PBOXclock.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBOXclock.InitialImage")));
            this.PBOXclock.Location = new System.Drawing.Point(12, 12);
            this.PBOXclock.Name = "PBOXclock";
            this.PBOXclock.Size = new System.Drawing.Size(512, 512);
            this.PBOXclock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBOXclock.TabIndex = 1;
            this.PBOXclock.TabStop = false;
            // 
            // Tseg
            // 
            this.Tseg.Interval = 1000;
            this.Tseg.Tick += new System.EventHandler(this.Tseg_Tick);
            // 
            // LABtime
            // 
            this.LABtime.AutoSize = true;
            this.LABtime.Location = new System.Drawing.Point(593, 114);
            this.LABtime.Name = "LABtime";
            this.LABtime.Size = new System.Drawing.Size(19, 13);
            this.LABtime.TabIndex = 0;
            this.LABtime.Text = "01";
            // 
            // LABsec2
            // 
            this.LABsec2.AutoSize = true;
            this.LABsec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec2.Location = new System.Drawing.Point(258, 100);
            this.LABsec2.Name = "LABsec2";
            this.LABsec2.Size = new System.Drawing.Size(21, 16);
            this.LABsec2.TabIndex = 0;
            this.LABsec2.Text = "01";
            // 
            // LABsec3
            // 
            this.LABsec3.AutoSize = true;
            this.LABsec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec3.Location = new System.Drawing.Point(258, 130);
            this.LABsec3.Name = "LABsec3";
            this.LABsec3.Size = new System.Drawing.Size(21, 16);
            this.LABsec3.TabIndex = 0;
            this.LABsec3.Text = "01";
            // 
            // LABsec4
            // 
            this.LABsec4.AutoSize = true;
            this.LABsec4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec4.Location = new System.Drawing.Point(258, 160);
            this.LABsec4.Name = "LABsec4";
            this.LABsec4.Size = new System.Drawing.Size(21, 16);
            this.LABsec4.TabIndex = 0;
            this.LABsec4.Text = "01";
            // 
            // LABsec5
            // 
            this.LABsec5.AutoSize = true;
            this.LABsec5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec5.Location = new System.Drawing.Point(258, 190);
            this.LABsec5.Name = "LABsec5";
            this.LABsec5.Size = new System.Drawing.Size(21, 16);
            this.LABsec5.TabIndex = 0;
            this.LABsec5.Text = "01";
            // 
            // LABsec6
            // 
            this.LABsec6.AutoSize = true;
            this.LABsec6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABsec6.Location = new System.Drawing.Point(258, 220);
            this.LABsec6.Name = "LABsec6";
            this.LABsec6.Size = new System.Drawing.Size(21, 16);
            this.LABsec6.TabIndex = 0;
            this.LABsec6.Text = "01";
            // 
            // LABmin1
            // 
            this.LABmin1.AutoSize = true;
            this.LABmin1.Location = new System.Drawing.Point(387, 262);
            this.LABmin1.Name = "LABmin1";
            this.LABmin1.Size = new System.Drawing.Size(19, 13);
            this.LABmin1.TabIndex = 0;
            this.LABmin1.Text = "01";
            // 
            // LABmin2
            // 
            this.LABmin2.AutoSize = true;
            this.LABmin2.Location = new System.Drawing.Point(362, 262);
            this.LABmin2.Name = "LABmin2";
            this.LABmin2.Size = new System.Drawing.Size(19, 13);
            this.LABmin2.TabIndex = 0;
            this.LABmin2.Text = "01";
            // 
            // LABmin3
            // 
            this.LABmin3.AutoSize = true;
            this.LABmin3.Location = new System.Drawing.Point(337, 262);
            this.LABmin3.Name = "LABmin3";
            this.LABmin3.Size = new System.Drawing.Size(19, 13);
            this.LABmin3.TabIndex = 0;
            this.LABmin3.Text = "01";
            // 
            // LABmin4
            // 
            this.LABmin4.AutoSize = true;
            this.LABmin4.Location = new System.Drawing.Point(312, 262);
            this.LABmin4.Name = "LABmin4";
            this.LABmin4.Size = new System.Drawing.Size(19, 13);
            this.LABmin4.TabIndex = 0;
            this.LABmin4.Text = "01";
            // 
            // LABmin5
            // 
            this.LABmin5.AutoSize = true;
            this.LABmin5.Location = new System.Drawing.Point(287, 262);
            this.LABmin5.Name = "LABmin5";
            this.LABmin5.Size = new System.Drawing.Size(19, 13);
            this.LABmin5.TabIndex = 0;
            this.LABmin5.Text = "01";
            // 
            // LABhor3
            // 
            this.LABhor3.AutoSize = true;
            this.LABhor3.Location = new System.Drawing.Point(225, 262);
            this.LABhor3.Name = "LABhor3";
            this.LABhor3.Size = new System.Drawing.Size(19, 13);
            this.LABhor3.TabIndex = 0;
            this.LABhor3.Text = "01";
            // 
            // LABhor2
            // 
            this.LABhor2.AutoSize = true;
            this.LABhor2.Location = new System.Drawing.Point(200, 262);
            this.LABhor2.Name = "LABhor2";
            this.LABhor2.Size = new System.Drawing.Size(19, 13);
            this.LABhor2.TabIndex = 0;
            this.LABhor2.Text = "01";
            // 
            // LABhor1
            // 
            this.LABhor1.AutoSize = true;
            this.LABhor1.Location = new System.Drawing.Point(175, 262);
            this.LABhor1.Name = "LABhor1";
            this.LABhor1.Size = new System.Drawing.Size(19, 13);
            this.LABhor1.TabIndex = 0;
            this.LABhor1.Text = "01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 575);
            this.Controls.Add(this.LABhor1);
            this.Controls.Add(this.LABhor2);
            this.Controls.Add(this.LABhor3);
            this.Controls.Add(this.LABmin5);
            this.Controls.Add(this.LABmin4);
            this.Controls.Add(this.LABmin3);
            this.Controls.Add(this.LABmin2);
            this.Controls.Add(this.LABmin1);
            this.Controls.Add(this.LABtime);
            this.Controls.Add(this.LABsec6);
            this.Controls.Add(this.LABsec5);
            this.Controls.Add(this.LABsec4);
            this.Controls.Add(this.LABsec3);
            this.Controls.Add(this.LABsec2);
            this.Controls.Add(this.LABsec1);
            this.Controls.Add(this.PBOXclock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBOXclock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABsec1;
        private System.Windows.Forms.PictureBox PBOXclock;
        private System.Windows.Forms.Timer Tseg;
        private System.Windows.Forms.Label LABtime;
        private System.Windows.Forms.Label LABsec2;
        private System.Windows.Forms.Label LABsec3;
        private System.Windows.Forms.Label LABsec4;
        private System.Windows.Forms.Label LABsec5;
        private System.Windows.Forms.Label LABsec6;
        private System.Windows.Forms.Label LABmin1;
        private System.Windows.Forms.Label LABmin2;
        private System.Windows.Forms.Label LABmin3;
        private System.Windows.Forms.Label LABmin4;
        private System.Windows.Forms.Label LABmin5;
        private System.Windows.Forms.Label LABhor3;
        private System.Windows.Forms.Label LABhor2;
        private System.Windows.Forms.Label LABhor1;
    }
}

