namespace Project_1
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
            this.Opperand1 = new System.Windows.Forms.TextBox();
            this.functionOperator = new System.Windows.Forms.TextBox();
            this.Opperand2 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Opperand1
            // 
            this.Opperand1.Location = new System.Drawing.Point(13, 26);
            this.Opperand1.Name = "Opperand1";
            this.Opperand1.Size = new System.Drawing.Size(100, 20);
            this.Opperand1.TabIndex = 0;
            this.Opperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // functionOperator
            // 
            this.functionOperator.Location = new System.Drawing.Point(119, 26);
            this.functionOperator.Name = "functionOperator";
            this.functionOperator.Size = new System.Drawing.Size(45, 20);
            this.functionOperator.TabIndex = 1;
            this.functionOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Opperand2
            // 
            this.Opperand2.Location = new System.Drawing.Point(170, 26);
            this.Opperand2.Name = "Opperand2";
            this.Opperand2.Size = new System.Drawing.Size(100, 20);
            this.Opperand2.TabIndex = 2;
            this.Opperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(194, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(54, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 264);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Opperand2);
            this.Controls.Add(this.functionOperator);
            this.Controls.Add(this.Opperand1);
            this.Name = "Form1";
            this.Text = "Calculator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Opperand1;
        private System.Windows.Forms.TextBox functionOperator;
        private System.Windows.Forms.TextBox Opperand2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

