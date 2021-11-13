
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
            this.txtCantAletas = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoBranquias = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.Controls.Add(this.cbTipoBranquias);
            this.bunifuGroupBox3.Controls.Add(this.label6);
            this.bunifuGroupBox3.Controls.Add(this.txtCantAletas);
            this.bunifuGroupBox3.Controls.Add(this.label7);
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
            this.txtCantAletas.Location = new System.Drawing.Point(29, 77);
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
            this.txtCantAletas.TabIndex = 11;
            this.txtCantAletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantAletas.TextMarginBottom = 0;
            this.txtCantAletas.TextMarginLeft = 3;
            this.txtCantAletas.TextMarginTop = 1;
            this.txtCantAletas.TextPlaceholder = "";
            this.txtCantAletas.UseSystemPasswordChar = false;
            this.txtCantAletas.WordWrap = true;
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
            // cbTipoBranquias
            // 
            this.cbTipoBranquias.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoBranquias.BaseColor = System.Drawing.Color.White;
            this.cbTipoBranquias.BorderColor = System.Drawing.Color.Silver;
            this.cbTipoBranquias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoBranquias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBranquias.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoBranquias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBranquias.ForeColor = System.Drawing.Color.Black;
            this.cbTipoBranquias.FormattingEnabled = true;
            this.cbTipoBranquias.Location = new System.Drawing.Point(348, 77);
            this.cbTipoBranquias.Name = "cbTipoBranquias";
            this.cbTipoBranquias.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTipoBranquias.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTipoBranquias.Radius = 10;
            this.cbTipoBranquias.Size = new System.Drawing.Size(260, 32);
            this.cbTipoBranquias.TabIndex = 19;
            // 
            // FrmPez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.ClientSize = new System.Drawing.Size(679, 607);
            this.Name = "FrmPez";
            this.bunifuGroupBox3.ResumeLayout(false);
            this.bunifuGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuTextBox txtCantAletas;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cbTipoBranquias;
    }
}
