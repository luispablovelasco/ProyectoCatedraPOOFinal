
namespace ProyectoDeCatedraPOOFinal
{
    partial class FrmPez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPez));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantAletas = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cbTipoBranquias = new System.Windows.Forms.ComboBox();
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
            this.bunifuGroupBox3.Controls.Add(this.cbTipoBranquias);
            this.bunifuGroupBox3.Controls.Add(this.txtCantAletas);
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
            "ciclóstomos",
            "condrictios",
            "osteictios",
            "actinopterígios"});
            // 
            // lbCategoria
            // 
            this.lbCategoria.Size = new System.Drawing.Size(69, 21);
            this.lbCategoria.Text = "(peces)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de aletas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de branquias";
            // 
            // txtCantAletas
            // 
            this.txtCantAletas.AcceptsReturn = false;
            this.txtCantAletas.AcceptsTab = false;
            this.txtCantAletas.AnimationSpeed = 200;
            this.txtCantAletas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantAletas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantAletas.AutoSizeHeight = true;
            this.txtCantAletas.BackColor = System.Drawing.Color.Transparent;
            this.txtCantAletas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCantAletas.BackgroundImage")));
            this.txtCantAletas.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCantAletas.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCantAletas.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCantAletas.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCantAletas.BorderRadius = 20;
            this.txtCantAletas.BorderThickness = 1;
            this.txtCantAletas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantAletas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantAletas.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantAletas.DefaultText = "";
            this.txtCantAletas.FillColor = System.Drawing.Color.White;
            this.txtCantAletas.HideSelection = true;
            this.txtCantAletas.IconLeft = null;
            this.txtCantAletas.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantAletas.IconPadding = 10;
            this.txtCantAletas.IconRight = null;
            this.txtCantAletas.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantAletas.Lines = new string[0];
            this.txtCantAletas.Location = new System.Drawing.Point(29, 74);
            this.txtCantAletas.MaxLength = 32767;
            this.txtCantAletas.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCantAletas.Modified = false;
            this.txtCantAletas.Multiline = false;
            this.txtCantAletas.Name = "txtCantAletas";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantAletas.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantAletas.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantAletas.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantAletas.OnIdleState = stateProperties4;
            this.txtCantAletas.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtCantAletas.PasswordChar = '\0';
            this.txtCantAletas.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCantAletas.PlaceholderText = "";
            this.txtCantAletas.ReadOnly = false;
            this.txtCantAletas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantAletas.SelectedText = "";
            this.txtCantAletas.SelectionLength = 0;
            this.txtCantAletas.SelectionStart = 0;
            this.txtCantAletas.ShortcutsEnabled = true;
            this.txtCantAletas.Size = new System.Drawing.Size(260, 35);
            this.txtCantAletas.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCantAletas.TabIndex = 20;
            this.txtCantAletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantAletas.TextMarginBottom = 0;
            this.txtCantAletas.TextMarginLeft = 3;
            this.txtCantAletas.TextMarginTop = 1;
            this.txtCantAletas.TextPlaceholder = "";
            this.txtCantAletas.UseSystemPasswordChar = false;
            this.txtCantAletas.WordWrap = true;
            this.txtCantAletas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantAletas_KeyPress);
            // 
            // cbTipoBranquias
            // 
            this.cbTipoBranquias.DropDownHeight = 120;
            this.cbTipoBranquias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBranquias.FormattingEnabled = true;
            this.cbTipoBranquias.IntegralHeight = false;
            this.cbTipoBranquias.Items.AddRange(new object[] {
            "externas",
            "internas"});
            this.cbTipoBranquias.Location = new System.Drawing.Point(339, 74);
            this.cbTipoBranquias.Name = "cbTipoBranquias";
            this.cbTipoBranquias.Size = new System.Drawing.Size(260, 29);
            this.cbTipoBranquias.TabIndex = 22;
            // 
            // FrmPez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Name = "FrmPez";
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
        private Bunifu.UI.WinForms.BunifuTextBox txtCantAletas;
        protected System.Windows.Forms.ComboBox cbTipoBranquias;
    }
}
