namespace Project_2
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
            this.lstFoods = new System.Windows.Forms.ListBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFoods
            // 
            this.lstFoods.FormattingEnabled = true;
            this.lstFoods.Location = new System.Drawing.Point(12, 12);
            this.lstFoods.Name = "lstFoods";
            this.lstFoods.Size = new System.Drawing.Size(192, 186);
            this.lstFoods.TabIndex = 0;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(12, 241);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(192, 20);
            this.txtFood.TabIndex = 1;
            this.txtFood.TextChanged += new System.EventHandler(this.txtFood_TextChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(224, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(101, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(224, 42);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(101, 23);
            this.btnSaveData.TabIndex = 3;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(224, 238);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(101, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(12, 204);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(192, 23);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Selected Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 285);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.lstFoods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFoods;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

