namespace GestorDeRecibos
{
    partial class Form1
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAdminID = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmdAcceder = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(46, 185);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 135);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Admin_ID";
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(147, 171);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 48);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtAdminID
            // 
            this.txtAdminID.AnimateReadOnly = false;
            this.txtAdminID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdminID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdminID.Depth = 0;
            this.txtAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdminID.HideSelection = true;
            this.txtAdminID.LeadingIcon = null;
            this.txtAdminID.Location = new System.Drawing.Point(147, 117);
            this.txtAdminID.MaxLength = 32767;
            this.txtAdminID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.PasswordChar = '\0';
            this.txtAdminID.PrefixSuffixText = null;
            this.txtAdminID.ReadOnly = false;
            this.txtAdminID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdminID.SelectedText = "";
            this.txtAdminID.SelectionLength = 0;
            this.txtAdminID.SelectionStart = 0;
            this.txtAdminID.ShortcutsEnabled = true;
            this.txtAdminID.Size = new System.Drawing.Size(250, 48);
            this.txtAdminID.TabIndex = 7;
            this.txtAdminID.TabStop = false;
            this.txtAdminID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdminID.TrailingIcon = null;
            this.txtAdminID.UseSystemPasswordChar = false;
            // 
            // cmdAcceder
            // 
            this.cmdAcceder.AutoSize = false;
            this.cmdAcceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAcceder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdAcceder.Depth = 0;
            this.cmdAcceder.HighEmphasis = true;
            this.cmdAcceder.Icon = null;
            this.cmdAcceder.Location = new System.Drawing.Point(162, 250);
            this.cmdAcceder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdAcceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdAcceder.Name = "cmdAcceder";
            this.cmdAcceder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdAcceder.Size = new System.Drawing.Size(194, 37);
            this.cmdAcceder.TabIndex = 6;
            this.cmdAcceder.Text = "Acceder";
            this.cmdAcceder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdAcceder.UseAccentColor = false;
            this.cmdAcceder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 368);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.cmdAcceder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdminID;
        private MaterialSkin.Controls.MaterialButton cmdAcceder;
    }
}

