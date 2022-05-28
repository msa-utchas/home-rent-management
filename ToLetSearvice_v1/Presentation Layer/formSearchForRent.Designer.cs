namespace ToLetSearvice_v1.Presentation_Layer
{
    partial class formSearchForRent
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
            this.cBLocation = new System.Windows.Forms.ComboBox();
            this.cBAvailableFor = new System.Windows.Forms.ComboBox();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.area = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGohome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(337, 86);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(767, 339);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // cBLocation
            // 
            this.cBLocation.FormattingEnabled = true;
            this.cBLocation.Items.AddRange(new object[] {
            "Bashundhara",
            "Uttora",
            "Nikunja",
            "taltola",
            "banani",
            "kakoli",
            "mirpur",
            "gulshan"});
            this.cBLocation.Location = new System.Drawing.Point(195, 213);
            this.cBLocation.Name = "cBLocation";
            this.cBLocation.Size = new System.Drawing.Size(121, 21);
            this.cBLocation.TabIndex = 14;
            // 
            // cBAvailableFor
            // 
            this.cBAvailableFor.FormattingEnabled = true;
            this.cBAvailableFor.Items.AddRange(new object[] {
            "Family",
            "Bachalor"});
            this.cBAvailableFor.Location = new System.Drawing.Point(195, 157);
            this.cBAvailableFor.Name = "cBAvailableFor";
            this.cBAvailableFor.Size = new System.Drawing.Size(121, 21);
            this.cBAvailableFor.TabIndex = 13;
            // 
            // cBType
            // 
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "Apartment",
            "Single Room",
            "Shared Room"});
            this.cBType.Location = new System.Drawing.Point(195, 96);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(121, 21);
            this.cBType.TabIndex = 12;
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Depth = 0;
            this.area.Font = new System.Drawing.Font("Roboto", 11F);
            this.area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.area.Location = new System.Drawing.Point(41, 215);
            this.area.MouseState = MaterialSkin.MouseState.HOVER;
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(64, 19);
            this.area.TabIndex = 11;
            this.area.Text = "location";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(41, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Available for :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Type :";
            // 
            // bSearch
            // 
            this.bSearch.Depth = 0;
            this.bSearch.Location = new System.Drawing.Point(105, 289);
            this.bSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSearch.Name = "bSearch";
            this.bSearch.Primary = true;
            this.bSearch.Size = new System.Drawing.Size(93, 41);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // buttonGohome
            // 
            this.buttonGohome.Depth = 0;
            this.buttonGohome.Location = new System.Drawing.Point(217, 289);
            this.buttonGohome.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGohome.Name = "buttonGohome";
            this.buttonGohome.Primary = true;
            this.buttonGohome.Size = new System.Drawing.Size(99, 41);
            this.buttonGohome.TabIndex = 16;
            this.buttonGohome.Text = "go back home";
            this.buttonGohome.UseVisualStyleBackColor = true;
            this.buttonGohome.Click += new System.EventHandler(this.buttonGohome_Click);
            // 
            // formSearchForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.buttonGohome);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBLocation);
            this.Controls.Add(this.cBAvailableFor);
            this.Controls.Add(this.cBType);
            this.Controls.Add(this.area);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "formSearchForRent";
            this.Text = "formSearchForRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox cBLocation;
        private System.Windows.Forms.ComboBox cBAvailableFor;
        private System.Windows.Forms.ComboBox cBType;
        private MaterialSkin.Controls.MaterialLabel area;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton bSearch;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGohome;
    }
}