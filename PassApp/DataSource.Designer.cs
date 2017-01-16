namespace PassApp
{
    partial class DataSource
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
            this.list = new System.Windows.Forms.ListView();
            this.columPagina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columPass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columOther = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columPagina,
            this.columUser,
            this.columPass,
            this.columCorreo,
            this.columOther});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(898, 333);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columPagina
            // 
            this.columPagina.Text = "Pagina";
            this.columPagina.Width = 134;
            // 
            // columUser
            // 
            this.columUser.Text = "User";
            this.columUser.Width = 125;
            // 
            // columPass
            // 
            this.columPass.Text = "Password";
            this.columPass.Width = 184;
            // 
            // columCorreo
            // 
            this.columCorreo.Text = "Correo";
            this.columCorreo.Width = 227;
            // 
            // columOther
            // 
            this.columOther.Text = "Other";
            this.columOther.Width = 222;
            // 
            // DataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 333);
            this.Controls.Add(this.list);
            this.Name = "DataSource";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSource_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columPagina;
        private System.Windows.Forms.ColumnHeader columUser;
        private System.Windows.Forms.ColumnHeader columPass;
        private System.Windows.Forms.ColumnHeader columCorreo;
        private System.Windows.Forms.ColumnHeader columOther;
    }
}