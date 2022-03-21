namespace Friends_list
{
    partial class frmOne
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
            this.lstbxDisplayNames = new System.Windows.Forms.ListBox();
            this.txtInputNames = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumberInList = new System.Windows.Forms.Label();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnAdd5 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxDisplayNames
            // 
            this.lstbxDisplayNames.FormattingEnabled = true;
            this.lstbxDisplayNames.ItemHeight = 20;
            this.lstbxDisplayNames.Location = new System.Drawing.Point(12, 12);
            this.lstbxDisplayNames.Name = "lstbxDisplayNames";
            this.lstbxDisplayNames.Size = new System.Drawing.Size(315, 424);
            this.lstbxDisplayNames.TabIndex = 0;
            this.lstbxDisplayNames.SelectedIndexChanged += new System.EventHandler(this.lstbxDisplayNames_SelectedIndexChanged);
            // 
            // txtInputNames
            // 
            this.txtInputNames.Location = new System.Drawing.Point(356, 77);
            this.txtInputNames.Name = "txtInputNames";
            this.txtInputNames.Size = new System.Drawing.Size(248, 26);
            this.txtInputNames.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(356, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumberInList
            // 
            this.lblNumberInList.AutoSize = true;
            this.lblNumberInList.Location = new System.Drawing.Point(482, 119);
            this.lblNumberInList.Name = "lblNumberInList";
            this.lblNumberInList.Size = new System.Drawing.Size(24, 20);
            this.lblNumberInList.TabIndex = 3;
            this.lblNumberInList.Text = "---";
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(333, 398);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(117, 38);
            this.btnSortZA.TabIndex = 4;
            this.btnSortZA.Text = "Sort Z-A";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(486, 398);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(118, 38);
            this.btnSortAZ.TabIndex = 5;
            this.btnSortAZ.Text = "Sort A-Z";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnAdd5
            // 
            this.btnAdd5.Location = new System.Drawing.Point(356, 160);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(120, 37);
            this.btnAdd5.TabIndex = 6;
            this.btnAdd5.Text = "Add 5";
            this.btnAdd5.UseVisualStyleBackColor = true;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(356, 204);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(120, 39);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(499, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd5);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.btnSortZA);
            this.Controls.Add(this.lblNumberInList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInputNames);
            this.Controls.Add(this.lstbxDisplayNames);
            this.Name = "frmOne";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxDisplayNames;
        private System.Windows.Forms.TextBox txtInputNames;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumberInList;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

