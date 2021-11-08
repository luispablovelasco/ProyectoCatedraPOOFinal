namespace ProyectoDeCatedraPOOFinal
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.frmElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ingresoElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnIngreso = new Bunifu.Framework.UI.BunifuTileButton();
            this.registroElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRegistro = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmElipse
            // 
            this.frmElipse.ElipseRadius = 20;
            this.frmElipse.TargetControl = this;
            // 
            // ingresoElipse
            // 
            this.ingresoElipse.ElipseRadius = 25;
            this.ingresoElipse.TargetControl = this.btnIngreso;
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(156)))), ((int)(((byte)(29)))));
            this.btnIngreso.color = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(156)))), ((int)(((byte)(29)))));
            this.btnIngreso.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngreso.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreso.Image")));
            this.btnIngreso.ImagePosition = 20;
            this.btnIngreso.ImageZoom = 70;
            this.btnIngreso.LabelPosition = 41;
            this.btnIngreso.LabelText = "Ingresar animales";
            this.btnIngreso.Location = new System.Drawing.Point(49, 95);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(40);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(189, 193);
            this.btnIngreso.TabIndex = 0;
            // 
            // registroElipse
            // 
            this.registroElipse.ElipseRadius = 25;
            this.registroElipse.TargetControl = this.btnRegistro;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(156)))), ((int)(((byte)(29)))));
            this.btnRegistro.color = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(156)))), ((int)(((byte)(29)))));
            this.btnRegistro.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImagePosition = 20;
            this.btnRegistro.ImageZoom = 70;
            this.btnRegistro.LabelPosition = 41;
            this.btnRegistro.LabelText = "Ver registros";
            this.btnRegistro.Location = new System.Drawing.Point(318, 95);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(40);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(189, 193);
            this.btnRegistro.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(234)))), ((int)(((byte)(98)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(566, 40);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú de inicio";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(566, 334);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btnIngreso);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse frmElipse;
        private Bunifu.Framework.UI.BunifuElipse ingresoElipse;
        private Bunifu.Framework.UI.BunifuElipse registroElipse;
        private Bunifu.Framework.UI.BunifuTileButton btnRegistro;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnIngreso;
        private System.Windows.Forms.Label label1;
    }
}

