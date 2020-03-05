namespace Temperature_Converter
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
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.btnFah = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCel.Location = new System.Drawing.Point(49, 57);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 23);
            this.txtCel.TabIndex = 0;
            // 
            // txtFah
            // 
            this.txtFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFah.Location = new System.Drawing.Point(49, 107);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(100, 23);
            this.txtFah.TabIndex = 1;
            // 
            // btnFah
            // 
            this.btnFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFah.Location = new System.Drawing.Point(177, 57);
            this.btnFah.Name = "btnFah";
            this.btnFah.Size = new System.Drawing.Size(75, 23);
            this.btnFah.TabIndex = 2;
            this.btnFah.Text = "Calc Fah";
            this.btnFah.UseVisualStyleBackColor = true;
            this.btnFah.Click += new System.EventHandler(this.btnFah_Click);
            // 
            // btnCel
            // 
            this.btnCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCel.Location = new System.Drawing.Point(177, 107);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(75, 23);
            this.btnCel.TabIndex = 3;
            this.btnCel.Text = "Calc Cel";
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(44, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Temperature Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 198);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.btnFah);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.txtCel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.Button btnFah;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Label lblTitle;
    }
}

