
namespace ProyectoDeCatedraPOOFinal
{
    partial class FrmReptil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReptil));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoResp = new System.Windows.Forms.ComboBox();
            this.cbFosasCraneales = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).BeginInit();
            this.bunifuGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            // 
            // txtNomComun
            // 
            this.txtNomComun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNomComun.BackgroundImage")));
            this.txtNomComun.Lines = new string[0];
            // 
            // txtNomCientifico
            // 
            this.txtNomCientifico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNomCientifico.BackgroundImage")));
            this.txtNomCientifico.Lines = new string[0];
            // 
            // btnIngresar
            // 
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.Controls.Add(this.cbFosasCraneales);
            this.bunifuGroupBox3.Controls.Add(this.cbTipoResp);
            this.bunifuGroupBox3.Controls.Add(this.label6);
            this.bunifuGroupBox3.Controls.Add(this.label7);
            // 
            // txtRutaFoto
            // 
            this.txtRutaFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRutaFoto.BackgroundImage")));
            this.txtRutaFoto.Lines = new string[0];
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.Items.AddRange(new object[] {
            "esfenodontos",
            "quelonios",
            "crocodilidos",
            "ofidios",
            "saurios"});
            // 
            // lbCategoria
            // 
            this.lbCategoria.Size = new System.Drawing.Size(77, 21);
            this.lbCategoria.Text = "(reptiles)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(349, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fosas temporales en el cráneo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tipo de respiración";
            // 
            // cbTipoResp
            // 
            this.cbTipoResp.DropDownHeight = 120;
            this.cbTipoResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoResp.FormattingEnabled = true;
            this.cbTipoResp.IntegralHeight = false;
            this.cbTipoResp.Items.AddRange(new object[] {
            "pulmonar",
            "cutánea"});
            this.cbTipoResp.Location = new System.Drawing.Point(29, 91);
            this.cbTipoResp.Name = "cbTipoResp";
            this.cbTipoResp.Size = new System.Drawing.Size(260, 29);
            this.cbTipoResp.TabIndex = 25;
            // 
            // cbFosasCraneales
            // 
            this.cbFosasCraneales.DropDownHeight = 120;
            this.cbFosasCraneales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFosasCraneales.FormattingEnabled = true;
            this.cbFosasCraneales.IntegralHeight = false;
            this.cbFosasCraneales.Items.AddRange(new object[] {
            "anápsidos",
            "sinápsidos",
            "diápsidos"});
            this.cbFosasCraneales.Location = new System.Drawing.Point(353, 91);
            this.cbFosasCraneales.Name = "cbFosasCraneales";
            this.cbFosasCraneales.Size = new System.Drawing.Size(260, 29);
            this.cbFosasCraneales.TabIndex = 26;
            // 
            // FrmReptil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Name = "FrmReptil";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).EndInit();
            this.bunifuGroupBox3.ResumeLayout(false);
            this.bunifuGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.ComboBox cbFosasCraneales;
        protected System.Windows.Forms.ComboBox cbTipoResp;
    }
}
