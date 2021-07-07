namespace Pharmacie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(180, 53);
            this.user_text.Name = "user_text";
            this.user_text.PasswordChar = '*';
            this.user_text.Size = new System.Drawing.Size(156, 20);
            this.user_text.TabIndex = 2;
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(180, 100);
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '*';
            this.pass_text.Size = new System.Drawing.Size(156, 20);
            this.pass_text.TabIndex = 3;
            // 
            // btn_connecter
            // 
            this.btn_connecter.Location = new System.Drawing.Point(180, 146);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(101, 28);
            this.btn_connecter.TabIndex = 4;
            this.btn_connecter.Text = "Connecter";
            this.btn_connecter.UseVisualStyleBackColor = true;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 271);
            this.Controls.Add(this.btn_connecter);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Button btn_connecter;
    }
}

