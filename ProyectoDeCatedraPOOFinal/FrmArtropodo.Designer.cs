
namespace ProyectoDeCatedraPOOFinal
{
    partial class FrmArtropodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtropodo));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantApendices = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cbTipoApendices = new System.Windows.Forms.ComboBox();
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
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(925, 37);
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
            this.bunifuGroupBox3.Controls.Add(this.cbTipoApendices);
            this.bunifuGroupBox3.Controls.Add(this.txtCantApendices);
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
            "insectos",
            "arácnidos",
            "crustáceos",
            "miriápodos"});
            // 
            // lbCategoria
            // 
            this.lbCategoria.Size = new System.Drawing.Size(108, 21);
            this.lbCategoria.Text = "(artrópodos)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cantidad de apéndices";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tipo de apéndices";
            // 
            // txtCantApendices
            // 
            this.txtCantApendices.AcceptsReturn = false;
            this.txtCantApendices.AcceptsTab = false;
            this.txtCantApendices.AnimationSpeed = 200;
            this.txtCantApendices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantApendices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantApendices.AutoSizeHeight = true;
            this.txtCantApendices.BackColor = System.Drawing.Color.Transparent;
            this.txtCantApendices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCantApendices.BackgroundImage")));
            this.txtCantApendices.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCantApendices.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCantApendices.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCantApendices.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCantApendices.BorderRadius = 20;
            this.txtCantApendices.BorderThickness = 1;
            this.txtCantApendices.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantApendices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantApendices.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantApendices.DefaultText = "";
            this.txtCantApendices.FillColor = System.Drawing.Color.White;
            this.txtCantApendices.HideSelection = true;
            this.txtCantApendices.IconLeft = null;
            this.txtCantApendices.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantApendices.IconPadding = 10;
            this.txtCantApendices.IconRight = null;
            this.txtCantApendices.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantApendices.Lines = new string[0];
            this.txtCantApendices.Location = new System.Drawing.Point(29, 77);
            this.txtCantApendices.MaxLength = 32767;
            this.txtCantApendices.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCantApendices.Modified = false;
            this.txtCantApendices.Multiline = false;
            this.txtCantApendices.Name = "txtCantApendices";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantApendices.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantApendices.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantApendices.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantApendices.OnIdleState = stateProperties4;
            this.txtCantApendices.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtCantApendices.PasswordChar = '\0';
            this.txtCantApendices.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCantApendices.PlaceholderText = "";
            this.txtCantApendices.ReadOnly = false;
            this.txtCantApendices.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantApendices.SelectedText = "";
            this.txtCantApendices.SelectionLength = 0;
            this.txtCantApendices.SelectionStart = 0;
            this.txtCantApendices.ShortcutsEnabled = true;
            this.txtCantApendices.Size = new System.Drawing.Size(260, 35);
            this.txtCantApendices.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCantApendices.TabIndex = 25;
            this.txtCantApendices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantApendices.TextMarginBottom = 0;
            this.txtCantApendices.TextMarginLeft = 3;
            this.txtCantApendices.TextMarginTop = 1;
            this.txtCantApendices.TextPlaceholder = "";
            this.txtCantApendices.UseSystemPasswordChar = false;
            this.txtCantApendices.WordWrap = true;
            this.txtCantApendices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantApendices_KeyPress);
            // 
            // cbTipoApendices
            // 
            this.cbTipoApendices.DropDownHeight = 120;
            this.cbTipoApendices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoApendices.FormattingEnabled = true;
            this.cbTipoApendices.IntegralHeight = false;
            this.cbTipoApendices.Items.AddRange(new object[] {
            "antenas",
            "antenulas",
            "gnatopodios",
            "hileras",
            "peines",
            "labio",
            "mandíbulas",
            "maxilas",
            "maxilípedos",
            "masillas",
            "ovejeros",
            "patas",
            "pedipalpos",
            "periópodos",
            "leopoldos",
            "quelíceros",
            "quilíferos",
            "toracópodos",
            "uro podios",
            "abdómenes"});
            this.cbTipoApendices.Location = new System.Drawing.Point(339, 83);
            this.cbTipoApendices.Name = "cbTipoApendices";
            this.cbTipoApendices.Size = new System.Drawing.Size(260, 29);
            this.cbTipoApendices.TabIndex = 26;
            // 
            // FrmArtropodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Name = "FrmArtropodo";
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
        private Bunifu.UI.WinForms.BunifuTextBox txtCantApendices;
        private System.Windows.Forms.ComboBox cbTipoApendices;
    }
}
