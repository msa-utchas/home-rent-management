namespace ToLetSearvice_v1.Presentation_Layer
{
    partial class formSignUpEmailVerify
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tVerificationcode = new System.Windows.Forms.TextBox();
            this.buttonVerify = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(175, 203);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "verifcation code";
            // 
            // tVerificationcode
            // 
            this.tVerificationcode.Location = new System.Drawing.Point(349, 204);
            this.tVerificationcode.Name = "tVerificationcode";
            this.tVerificationcode.Size = new System.Drawing.Size(100, 20);
            this.tVerificationcode.TabIndex = 1;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Depth = 0;
            this.buttonVerify.Location = new System.Drawing.Point(359, 290);
            this.buttonVerify.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Primary = true;
            this.buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // formSignUpEmailVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.tVerificationcode);
            this.Controls.Add(this.materialLabel1);
            this.Name = "formSignUpEmailVerify";
            this.Text = "signUpEmailVerify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox tVerificationcode;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVerify;
    }
}