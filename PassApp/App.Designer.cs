namespace PassApp
{
    partial class App
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
            this.btNew = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPagApp = new System.Windows.Forms.Label();
            this.txtPagApp = new System.Windows.Forms.TextBox();
            this.btSavePass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(12, 12);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(85, 27);
            this.btNew.TabIndex = 0;
            this.btNew.Text = " Crear Pass";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(103, 12);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(85, 27);
            this.btView.TabIndex = 1;
            this.btView.Text = "Ver Pass";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(495, 43);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(76, 13);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "Otros Campos ";
            this.lblOther.Visible = false;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(489, 59);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 20);
            this.txtOther.TabIndex = 14;
            this.txtOther.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(376, 43);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password";
            this.lblPass.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(370, 59);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 12;
            this.txtPass.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(260, 43);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(254, 59);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(140, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuario";
            this.lblUser.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(134, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.Visible = false;
            // 
            // lblPagApp
            // 
            this.lblPagApp.AutoSize = true;
            this.lblPagApp.Location = new System.Drawing.Point(18, 43);
            this.lblPagApp.Name = "lblPagApp";
            this.lblPagApp.Size = new System.Drawing.Size(94, 13);
            this.lblPagApp.TabIndex = 17;
            this.lblPagApp.Text = "Pagina/Aplicacion";
            this.lblPagApp.Visible = false;
            // 
            // txtPagApp
            // 
            this.txtPagApp.Location = new System.Drawing.Point(12, 59);
            this.txtPagApp.Name = "txtPagApp";
            this.txtPagApp.Size = new System.Drawing.Size(100, 20);
            this.txtPagApp.TabIndex = 16;
            this.txtPagApp.Visible = false;
            // 
            // btSavePass
            // 
            this.btSavePass.Location = new System.Drawing.Point(603, 57);
            this.btSavePass.Name = "btSavePass";
            this.btSavePass.Size = new System.Drawing.Size(86, 23);
            this.btSavePass.TabIndex = 18;
            this.btSavePass.Text = "Guardar!";
            this.btSavePass.UseVisualStyleBackColor = true;
            this.btSavePass.Visible = false;
            this.btSavePass.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Exit!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 94);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSavePass);
            this.Controls.Add(this.lblPagApp);
            this.Controls.Add(this.txtPagApp);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btNew);
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btView;
        public System.Windows.Forms.Label lblOther;
        public System.Windows.Forms.TextBox txtOther;
        public System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Label lblPagApp;
        public System.Windows.Forms.TextBox txtPagApp;
        private System.Windows.Forms.Button btSavePass;
        private System.Windows.Forms.Button button1;
    }
}