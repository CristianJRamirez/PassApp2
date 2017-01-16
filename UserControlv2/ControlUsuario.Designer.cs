namespace UserControlv2
{
    partial class ControlUsuario
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
            this.txtUserControl = new System.Windows.Forms.TextBox();
            this.lvlUserControl = new System.Windows.Forms.Label();
            this.lblPassControl = new System.Windows.Forms.Label();
            this.txtPassControl = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserControl
            // 
            this.txtUserControl.Location = new System.Drawing.Point(93, 26);
            this.txtUserControl.Name = "txtUserControl";
            this.txtUserControl.Size = new System.Drawing.Size(100, 20);
            this.txtUserControl.TabIndex = 0;
            // 
            // lvlUserControl
            // 
            this.lvlUserControl.AutoSize = true;
            this.lvlUserControl.Location = new System.Drawing.Point(28, 26);
            this.lvlUserControl.Name = "lvlUserControl";
            this.lvlUserControl.Size = new System.Drawing.Size(43, 13);
            this.lvlUserControl.TabIndex = 4;
            this.lvlUserControl.Text = "Usuario";
            // 
            // lblPassControl
            // 
            this.lblPassControl.AutoSize = true;
            this.lblPassControl.Location = new System.Drawing.Point(18, 68);
            this.lblPassControl.Name = "lblPassControl";
            this.lblPassControl.Size = new System.Drawing.Size(53, 13);
            this.lblPassControl.TabIndex = 5;
            this.lblPassControl.Text = "Password";
            // 
            // txtPassControl
            // 
            this.txtPassControl.Location = new System.Drawing.Point(93, 61);
            this.txtPassControl.Name = "txtPassControl";
            this.txtPassControl.Size = new System.Drawing.Size(100, 20);
            this.txtPassControl.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(213, 40);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(35, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK!";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 108);
            this.ControlBox = false;
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lblPassControl);
            this.Controls.Add(this.txtPassControl);
            this.Controls.Add(this.lvlUserControl);
            this.Controls.Add(this.txtUserControl);
            this.Name = "ControlUsuario";
            this.Text = "ControlUsuario";
            this.Load += new System.EventHandler(this.ControlUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserControl;
        private System.Windows.Forms.Label lvlUserControl;
        private System.Windows.Forms.Label lblPassControl;
        private System.Windows.Forms.TextBox txtPassControl;
        private System.Windows.Forms.Button btOK;
    }
}