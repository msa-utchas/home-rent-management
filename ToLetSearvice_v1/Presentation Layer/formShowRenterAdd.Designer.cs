namespace ToLetSearvice_v1.Presentation_Layer
{
    partial class formShowRenterAdd
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGohome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 164);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(776, 274);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // buttonGohome
            // 
            this.buttonGohome.Depth = 0;
            this.buttonGohome.Location = new System.Drawing.Point(540, 92);
            this.buttonGohome.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGohome.Name = "buttonGohome";
            this.buttonGohome.Primary = true;
            this.buttonGohome.Size = new System.Drawing.Size(99, 41);
            this.buttonGohome.TabIndex = 17;
            this.buttonGohome.Text = "go back home";
            this.buttonGohome.UseVisualStyleBackColor = true;
            this.buttonGohome.Click += new System.EventHandler(this.buttonGohome_Click);
            // 
            // formShowRenterAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGohome);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "formShowRenterAdd";
            this.Text = "formShowRenterAdd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGohome;
    }
}