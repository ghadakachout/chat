
namespace ProjetChatBot
{
    partial class DashbordAdmin
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
            this.button_add_user = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(707, 83);
            this.button_add_user.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(656, 176);
            this.button_add_user.TabIndex = 0;
            this.button_add_user.Text = "ADD_User";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(656, 176);
            this.button2.TabIndex = 1;
            this.button2.Text = "ADD Question";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 596);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(656, 176);
            this.button3.TabIndex = 2;
            this.button3.Text = "ADD Answer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DashbordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_add_user);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DashbordAdmin";
            this.Text = "DashbordAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}