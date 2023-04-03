namespace ComputerRegister_console
{
    partial class compRegistry
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
            this.components = new System.ComponentModel.Container();
            this.RegisteredComputers_database = new System.Windows.Forms.BindingSource(this.components);
            this.computerID = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.ownership = new System.Windows.Forms.Label();
            this.manufacturerTxtBox = new System.Windows.Forms.TextBox();
            this.modelTxtBox = new System.Windows.Forms.TextBox();
            this.ownershipTxtBox = new System.Windows.Forms.TextBox();
            this.compIdTxtBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.submitLbl = new System.Windows.Forms.Label();
            this.compRegGrp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredComputers_database)).BeginInit();
            this.compRegGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerID
            // 
            this.computerID.AutoSize = true;
            this.computerID.Location = new System.Drawing.Point(74, 42);
            this.computerID.Name = "computerID";
            this.computerID.Size = new System.Drawing.Size(66, 13);
            this.computerID.TabIndex = 1;
            this.computerID.Text = "Computer ID";
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Location = new System.Drawing.Point(74, 84);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(70, 13);
            this.manufacturer.TabIndex = 2;
            this.manufacturer.Text = "Manufacturer";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(74, 129);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 3;
            this.model.Text = "Model";
            // 
            // ownership
            // 
            this.ownership.AutoSize = true;
            this.ownership.Location = new System.Drawing.Point(74, 173);
            this.ownership.Name = "ownership";
            this.ownership.Size = new System.Drawing.Size(63, 13);
            this.ownership.TabIndex = 4;
            this.ownership.Text = "Own/Lease";
            // 
            // manufacturerTxtBox
            // 
            this.manufacturerTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.manufacturerTxtBox.Location = new System.Drawing.Point(165, 77);
            this.manufacturerTxtBox.Name = "manufacturerTxtBox";
            this.manufacturerTxtBox.Size = new System.Drawing.Size(245, 20);
            this.manufacturerTxtBox.TabIndex = 5;
            this.manufacturerTxtBox.Text = "Enter Manufacturer Name";
            this.manufacturerTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.modelTxtBox.Location = new System.Drawing.Point(165, 122);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(245, 20);
            this.modelTxtBox.TabIndex = 6;
            this.modelTxtBox.Text = "Enter as Model Name/Number";
            this.modelTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ownershipTxtBox
            // 
            this.ownershipTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ownershipTxtBox.Location = new System.Drawing.Point(165, 166);
            this.ownershipTxtBox.Name = "ownershipTxtBox";
            this.ownershipTxtBox.Size = new System.Drawing.Size(245, 20);
            this.ownershipTxtBox.TabIndex = 7;
            this.ownershipTxtBox.Text = "Enter as Name, Own/Lease";
            this.ownershipTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compIdTxtBox
            // 
            this.compIdTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.compIdTxtBox.Location = new System.Drawing.Point(165, 34);
            this.compIdTxtBox.Name = "compIdTxtBox";
            this.compIdTxtBox.Size = new System.Drawing.Size(245, 20);
            this.compIdTxtBox.TabIndex = 8;
            this.compIdTxtBox.Text = "Enter Computer ID";
            this.compIdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.compIdTxtBox.TextChanged += new System.EventHandler(this.compIdTxtBox_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(179, 249);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.submitBtn.Size = new System.Drawing.Size(178, 35);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit Data";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // submitLbl
            // 
            this.submitLbl.AutoSize = true;
            this.submitLbl.Location = new System.Drawing.Point(214, 287);
            this.submitLbl.Name = "submitLbl";
            this.submitLbl.Size = new System.Drawing.Size(117, 13);
            this.submitLbl.TabIndex = 10;
            this.submitLbl.Text = "Submit filled information";
            // 
            // compRegGrp
            // 
            this.compRegGrp.Controls.Add(this.submitLbl);
            this.compRegGrp.Controls.Add(this.submitBtn);
            this.compRegGrp.Controls.Add(this.compIdTxtBox);
            this.compRegGrp.Controls.Add(this.ownershipTxtBox);
            this.compRegGrp.Controls.Add(this.modelTxtBox);
            this.compRegGrp.Controls.Add(this.manufacturerTxtBox);
            this.compRegGrp.Controls.Add(this.ownership);
            this.compRegGrp.Controls.Add(this.model);
            this.compRegGrp.Controls.Add(this.manufacturer);
            this.compRegGrp.Controls.Add(this.computerID);
            this.compRegGrp.Location = new System.Drawing.Point(114, 65);
            this.compRegGrp.Name = "compRegGrp";
            this.compRegGrp.Size = new System.Drawing.Size(528, 327);
            this.compRegGrp.TabIndex = 11;
            this.compRegGrp.TabStop = false;
            this.compRegGrp.Text = "Computers Register Group";
            // 
            // compRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compRegGrp);
            this.Name = "compRegistry";
            this.Text = "Computers Allocation Database";
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredComputers_database)).EndInit();
            this.compRegGrp.ResumeLayout(false);
            this.compRegGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource RegisteredComputers_database;
        private System.Windows.Forms.Label computerID;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label ownership;
        private System.Windows.Forms.TextBox manufacturerTxtBox;
        private System.Windows.Forms.TextBox modelTxtBox;
        private System.Windows.Forms.TextBox ownershipTxtBox;
        private System.Windows.Forms.TextBox compIdTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label submitLbl;
        private System.Windows.Forms.GroupBox compRegGrp;
    }
}

