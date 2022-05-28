namespace ToLetSearvice_v1.Presentation_Layer
{
    partial class formHome
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
            this.lName = new MaterialSkin.Controls.MaterialLabel();
            this.bPostAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bPostedAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bSearchRent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bUserSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Depth = 0;
            this.lName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lName.Location = new System.Drawing.Point(83, 87);
            this.lName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(108, 19);
            this.lName.TabIndex = 0;
            this.lName.Text = "materialLabel1";
            // 
            // bPostAdd
            // 
            this.bPostAdd.Depth = 0;
            this.bPostAdd.Location = new System.Drawing.Point(284, 83);
            this.bPostAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.bPostAdd.Name = "bPostAdd";
            this.bPostAdd.Primary = true;
            this.bPostAdd.Size = new System.Drawing.Size(139, 43);
            this.bPostAdd.TabIndex = 1;
            this.bPostAdd.Text = "post new add";
            this.bPostAdd.UseVisualStyleBackColor = true;
            this.bPostAdd.Click += new System.EventHandler(this.bPostAdd_Click);
            // 
            // bPostedAdd
            // 
            this.bPostedAdd.Depth = 0;
            this.bPostedAdd.Location = new System.Drawing.Point(284, 162);
            this.bPostedAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.bPostedAdd.Name = "bPostedAdd";
            this.bPostedAdd.Primary = true;
            this.bPostedAdd.Size = new System.Drawing.Size(139, 47);
            this.bPostedAdd.TabIndex = 2;
            this.bPostedAdd.Text = "show posted add";
            this.bPostedAdd.UseVisualStyleBackColor = true;
            this.bPostedAdd.Click += new System.EventHandler(this.bPostedAdd_Click);
            // 
            // bSearchRent
            // 
            this.bSearchRent.Depth = 0;
            this.bSearchRent.Location = new System.Drawing.Point(284, 259);
            this.bSearchRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.bSearchRent.Name = "bSearchRent";
            this.bSearchRent.Primary = true;
            this.bSearchRent.Size = new System.Drawing.Size(139, 51);
            this.bSearchRent.TabIndex = 3;
            this.bSearchRent.Text = "search for rent";
            this.bSearchRent.UseVisualStyleBackColor = true;
            this.bSearchRent.Click += new System.EventHandler(this.bSearchRent_Click);
            // 
            // bUserSettings
            // 
            this.bUserSettings.Depth = 0;
            this.bUserSettings.Location = new System.Drawing.Point(284, 347);
            this.bUserSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.bUserSettings.Name = "bUserSettings";
            this.bUserSettings.Primary = true;
            this.bUserSettings.Size = new System.Drawing.Size(139, 54);
            this.bUserSettings.TabIndex = 4;
            this.bUserSettings.Text = "settings";
            this.bUserSettings.UseVisualStyleBackColor = true;
            this.bUserSettings.Click += new System.EventHandler(this.bUserSettings_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bUserSettings);
            this.Controls.Add(this.bSearchRent);
            this.Controls.Add(this.bPostedAdd);
            this.Controls.Add(this.bPostAdd);
            this.Controls.Add(this.lName);
            this.Name = "formHome";
            this.Text = "formHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lName;
        private MaterialSkin.Controls.MaterialRaisedButton bPostAdd;
        private MaterialSkin.Controls.MaterialRaisedButton bPostedAdd;
        private MaterialSkin.Controls.MaterialRaisedButton bSearchRent;
        private MaterialSkin.Controls.MaterialRaisedButton bUserSettings;
    }
}