namespace numbers_to_words
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConvert = new MaterialSkin.Controls.MaterialButton();
            this.tbWords = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbNumbers = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.AutoSize = false;
            this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConvert.Depth = 0;
            this.btnConvert.HighEmphasis = true;
            this.btnConvert.Icon = null;
            this.btnConvert.Location = new System.Drawing.Point(33, 145);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConvert.Size = new System.Drawing.Size(501, 36);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConvert.UseAccentColor = false;
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // tbWords
            // 
            this.tbWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWords.Depth = 0;
            this.tbWords.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbWords.Location = new System.Drawing.Point(33, 190);
            this.tbWords.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(501, 165);
            this.tbWords.TabIndex = 9;
            this.tbWords.Text = "";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumbers.AnimateReadOnly = false;
            this.tbNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumbers.Depth = 0;
            this.tbNumbers.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNumbers.Hint = "Numbers";
            this.tbNumbers.LeadingIcon = null;
            this.tbNumbers.Location = new System.Drawing.Point(33, 77);
            this.tbNumbers.MaxLength = 50;
            this.tbNumbers.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNumbers.Multiline = false;
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(501, 50);
            this.tbNumbers.TabIndex = 10;
            this.tbNumbers.Text = "";
            this.tbNumbers.TrailingIcon = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 387);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.tbWords);
            this.Controls.Add(this.btnConvert);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(573, 387);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numbers to Words Converter";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnConvert;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbWords;
        private MaterialSkin.Controls.MaterialTextBox tbNumbers;
    }
}

