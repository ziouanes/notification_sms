
namespace notification_whatsapp
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
            this.textto = new System.Windows.Forms.TextBox();
            this.textMesssage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textto
            // 
            this.textto.Enabled = false;
            this.textto.Location = new System.Drawing.Point(87, 51);
            this.textto.Name = "textto";
            this.textto.Size = new System.Drawing.Size(362, 20);
            this.textto.TabIndex = 0;
            // 
            // textMesssage
            // 
            this.textMesssage.Location = new System.Drawing.Point(87, 77);
            this.textMesssage.Multiline = true;
            this.textMesssage.Name = "textMesssage";
            this.textMesssage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMesssage.Size = new System.Drawing.Size(618, 81);
            this.textMesssage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message : ";
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(343, 164);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(106, 23);
            this.buttonsend.TabIndex = 2;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 332);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMesssage);
            this.Controls.Add(this.textto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textto;
        private System.Windows.Forms.TextBox textMesssage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonsend;
    }
}

