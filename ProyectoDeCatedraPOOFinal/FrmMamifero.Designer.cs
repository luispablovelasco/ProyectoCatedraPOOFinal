
namespace ProyectoDeCatedraPOOFinal
{
    partial class FrmMamifero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMamifero));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantMamas = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtColorPelo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.bunifuGroupBox3.Controls.Add(this.label6);
            this.bunifuGroupBox3.Controls.Add(this.txtCantMamas);
            this.bunifuGroupBox3.Controls.Add(this.txtColorPelo);
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
            "carnívoro",
            "ungulados",
            "primates",
            "cetáceos"});
            // 
            // lbCategoria
            // 
            this.lbCategoria.Size = new System.Drawing.Size(102, 21);
            this.lbCategoria.Text = "(mamíferos)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de mamas";
            // 
            // txtCantMamas
            // 
            this.txtCantMamas.AcceptsReturn = false;
            this.txtCantMamas.AcceptsTab = false;
            this.txtCantMamas.AnimationSpeed = 200;
            this.txtCantMamas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCantMamas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCantMamas.AutoSizeHeight = true;
            this.txtCantMamas.BackColor = System.Drawing.Color.Transparent;
            this.txtCantMamas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCantMamas.BackgroundImage")));
            this.txtCantMamas.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCantMamas.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCantMamas.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCantMamas.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCantMamas.BorderRadius = 20;
            this.txtCantMamas.BorderThickness = 1;
            this.txtCantMamas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantMamas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantMamas.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMamas.DefaultText = "";
            this.txtCantMamas.FillColor = System.Drawing.Color.White;
            this.txtCantMamas.HideSelection = true;
            this.txtCantMamas.IconLeft = null;
            this.txtCantMamas.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantMamas.IconPadding = 10;
            this.txtCantMamas.IconRight = null;
            this.txtCantMamas.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantMamas.Lines = new string[0];
            this.txtCantMamas.Location = new System.Drawing.Point(29, 77);
            this.txtCantMamas.MaxLength = 32767;
            this.txtCantMamas.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCantMamas.Modified = false;
            this.txtCantMamas.Multiline = false;
            this.txtCantMamas.Name = "txtCantMamas";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantMamas.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCantMamas.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantMamas.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCantMamas.OnIdleState = stateProperties4;
            this.txtCantMamas.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtCantMamas.PasswordChar = '\0';
            this.txtCantMamas.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCantMamas.PlaceholderText = "";
            this.txtCantMamas.ReadOnly = false;
            this.txtCantMamas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantMamas.SelectedText = "";
            this.txtCantMamas.SelectionLength = 0;
            this.txtCantMamas.SelectionStart = 0;
            this.txtCantMamas.ShortcutsEnabled = true;
            this.txtCantMamas.Size = new System.Drawing.Size(260, 35);
            this.txtCantMamas.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCantMamas.TabIndex = 11;
            this.txtCantMamas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantMamas.TextMarginBottom = 0;
            this.txtCantMamas.TextMarginLeft = 3;
            this.txtCantMamas.TextMarginTop = 1;
            this.txtCantMamas.TextPlaceholder = "";
            this.txtCantMamas.UseSystemPasswordChar = false;
            this.txtCantMamas.WordWrap = true;
            this.txtCantMamas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMamas_KeyPress);
            // 
            // txtColorPelo
            // 
            this.txtColorPelo.AcceptsReturn = false;
            this.txtColorPelo.AcceptsTab = false;
            this.txtColorPelo.AnimationSpeed = 200;
            this.txtColorPelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtColorPelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtColorPelo.AutoSizeHeight = true;
            this.txtColorPelo.BackColor = System.Drawing.Color.Transparent;
            this.txtColorPelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtColorPelo.BackgroundImage")));
            this.txtColorPelo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtColorPelo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtColorPelo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtColorPelo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtColorPelo.BorderRadius = 20;
            this.txtColorPelo.BorderThickness = 1;
            this.txtColorPelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColorPelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColorPelo.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorPelo.DefaultText = "";
            this.txtColorPelo.FillColor = System.Drawing.Color.White;
            this.txtColorPelo.HideSelection = true;
            this.txtColorPelo.IconLeft = null;
            this.txtColorPelo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColorPelo.IconPadding = 10;
            this.txtColorPelo.IconRight = null;
            this.txtColorPelo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColorPelo.Lines = new string[0];
            this.txtColorPelo.Location = new System.Drawing.Point(348, 77);
            this.txtColorPelo.MaxLength = 32767;
            this.txtColorPelo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtColorPelo.Modified = false;
            this.txtColorPelo.Multiline = false;
            this.txtColorPelo.Name = "txtColorPelo";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtColorPelo.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtColorPelo.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtColorPelo.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtColorPelo.OnIdleState = stateProperties8;
            this.txtColorPelo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtColorPelo.PasswordChar = '\0';
            this.txtColorPelo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtColorPelo.PlaceholderText = "";
            this.txtColorPelo.ReadOnly = false;
            this.txtColorPelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColorPelo.SelectedText = "";
            this.txtColorPelo.SelectionLength = 0;
            this.txtColorPelo.SelectionStart = 0;
            this.txtColorPelo.ShortcutsEnabled = true;
            this.txtColorPelo.Size = new System.Drawing.Size(260, 35);
            this.txtColorPelo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtColorPelo.TabIndex = 13;
            this.txtColorPelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColorPelo.TextMarginBottom = 0;
            this.txtColorPelo.TextMarginLeft = 3;
            this.txtColorPelo.TextMarginTop = 1;
            this.txtColorPelo.TextPlaceholder = "";
            this.txtColorPelo.UseSystemPasswordChar = false;
            this.txtColorPelo.WordWrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color de pelo";
            // 
            // FrmMamifero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Name = "FrmMamifero";
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
        private Bunifu.UI.WinForms.BunifuTextBox txtCantMamas;
        private Bunifu.UI.WinForms.BunifuTextBox txtColorPelo;
        private System.Windows.Forms.Label label7;
    }
}
