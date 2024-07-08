namespace InventoryManagmentSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DragPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.BtnKezeles = new System.Windows.Forms.Button();
            this.BtnRend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.Gold;
            this.DragPanel.Controls.Add(this.btnExit);
            this.DragPanel.Controls.Add(this.BtnKezeles);
            this.DragPanel.Controls.Add(this.BtnRend);
            this.DragPanel.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.DragPanel, "DragPanel");
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnKezeles
            // 
            resources.ApplyResources(this.BtnKezeles, "BtnKezeles");
            this.BtnKezeles.Name = "BtnKezeles";
            this.BtnKezeles.UseVisualStyleBackColor = true;
            // 
            // BtnRend
            // 
            resources.ApplyResources(this.BtnRend, "BtnRend");
            this.BtnRend.Name = "BtnRend";
            this.BtnRend.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnKezeles;
        private System.Windows.Forms.Button BtnRend;
        private System.Windows.Forms.PictureBox btnExit;
    }
}