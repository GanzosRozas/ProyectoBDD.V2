namespace GestorDeRecibos
{
    partial class Form3
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
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.Bt_Nsocio = new MaterialSkin.Controls.MaterialButton();
            this.cmdBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(131, 112);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox21.TabIndex = 2;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "materialTextBox21";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // Bt_Nsocio
            // 
            this.Bt_Nsocio.AutoSize = false;
            this.Bt_Nsocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Nsocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Bt_Nsocio.Depth = 0;
            this.Bt_Nsocio.HighEmphasis = true;
            this.Bt_Nsocio.Icon = null;
            this.Bt_Nsocio.Location = new System.Drawing.Point(255, 246);
            this.Bt_Nsocio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bt_Nsocio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bt_Nsocio.Name = "Bt_Nsocio";
            this.Bt_Nsocio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Bt_Nsocio.Size = new System.Drawing.Size(157, 36);
            this.Bt_Nsocio.TabIndex = 18;
            this.Bt_Nsocio.Text = "Nuevo Socio";
            this.Bt_Nsocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Bt_Nsocio.UseAccentColor = false;
            this.Bt_Nsocio.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.AutoSize = false;
            this.cmdBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdBuscar.Depth = 0;
            this.cmdBuscar.HighEmphasis = true;
            this.cmdBuscar.Icon = null;
            this.cmdBuscar.Location = new System.Drawing.Point(67, 246);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdBuscar.Size = new System.Drawing.Size(167, 36);
            this.cmdBuscar.TabIndex = 17;
            this.cmdBuscar.Text = "Aceptar";
            this.cmdBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdBuscar.UseAccentColor = false;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(64, 127);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(30, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "RFC";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 383);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Bt_Nsocio);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.materialTextBox21);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton Bt_Nsocio;
        private MaterialSkin.Controls.MaterialButton cmdBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}