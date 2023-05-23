namespace Pract16_1_Forms
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.infoInput = new System.Windows.Forms.Label();
            this.btnProcces = new System.Windows.Forms.Button();
            this.lblResultB = new System.Windows.Forms.Label();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblResultC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInput.Location = new System.Drawing.Point(60, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(199, 29);
            this.txtInput.TabIndex = 0;
            // 
            // infoInput
            // 
            this.infoInput.AutoSize = true;
            this.infoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoInput.Location = new System.Drawing.Point(77, 16);
            this.infoInput.Name = "infoInput";
            this.infoInput.Size = new System.Drawing.Size(163, 24);
            this.infoInput.TabIndex = 1;
            this.infoInput.Text = "Введите строчку";
            // 
            // btnProcces
            // 
            this.btnProcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcces.Location = new System.Drawing.Point(60, 99);
            this.btnProcces.Name = "btnProcces";
            this.btnProcces.Size = new System.Drawing.Size(199, 59);
            this.btnProcces.TabIndex = 2;
            this.btnProcces.Text = "Поиск";
            this.btnProcces.UseVisualStyleBackColor = true;
            this.btnProcces.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultB
            // 
            this.lblResultB.AutoSize = true;
            this.lblResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultB.Location = new System.Drawing.Point(60, 242);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(0, 24);
            this.lblResultB.TabIndex = 3;
            // 
            // lblResultA
            // 
            this.lblResultA.AutoSize = true;
            this.lblResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultA.Location = new System.Drawing.Point(60, 193);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(0, 24);
            this.lblResultA.TabIndex = 4;
            // 
            // lblResultC
            // 
            this.lblResultC.AutoSize = true;
            this.lblResultC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultC.Location = new System.Drawing.Point(60, 286);
            this.lblResultC.Name = "lblResultC";
            this.lblResultC.Size = new System.Drawing.Size(0, 24);
            this.lblResultC.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 387);
            this.Controls.Add(this.lblResultC);
            this.Controls.Add(this.lblResultA);
            this.Controls.Add(this.lblResultB);
            this.Controls.Add(this.btnProcces);
            this.Controls.Add(this.infoInput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Поиск слов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblResultA;
        private System.Windows.Forms.Label lblResultC;

        private System.Windows.Forms.Button btnProcces;
        private System.Windows.Forms.Label lblResultB;

        private System.Windows.Forms.Label infoInput;

        private System.Windows.Forms.TextBox txtInput;

        #endregion
    }
}