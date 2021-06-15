namespace New_project_LIB
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.LOG_IN_TIME = new System.Windows.Forms.Timer(this.components);
            this.Tittlebar = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.Button();
            this.LOGOOFButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Tittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LOG_IN_TIME
            // 
            this.LOG_IN_TIME.Interval = 50;
            this.LOG_IN_TIME.Tick += new System.EventHandler(this.LOG_IN_TIME_Tick);
            // 
            // Tittlebar
            // 
            this.Tittlebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tittlebar.Controls.Add(this.LOGOOFButton);
            this.Tittlebar.Controls.Add(this.MinimizeButton);
            this.Tittlebar.Controls.Add(this.Closebutton);
            this.Tittlebar.Location = new System.Drawing.Point(-2, 1);
            this.Tittlebar.Name = "Tittlebar";
            this.Tittlebar.Size = new System.Drawing.Size(717, 35);
            this.Tittlebar.TabIndex = 0;
            this.Tittlebar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tittlebar_MouseClick);
            // 
            // Closebutton
            // 
            this.Closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Closebutton.BackgroundImage")));
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Closebutton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Closebutton.Location = new System.Drawing.Point(671, 2);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(34, 30);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // LOGOOFButton
            // 
            this.LOGOOFButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LOGOOFButton.BackgroundImage")));
            this.LOGOOFButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOGOOFButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LOGOOFButton.Location = new System.Drawing.Point(600, 2);
            this.LOGOOFButton.Name = "LOGOOFButton";
            this.LOGOOFButton.Size = new System.Drawing.Size(29, 31);
            this.LOGOOFButton.TabIndex = 2;
            this.LOGOOFButton.UseVisualStyleBackColor = true;
            this.LOGOOFButton.Click += new System.EventHandler(this.LOGOOFButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinimizeButton.Location = new System.Drawing.Point(636, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 31);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.Tittlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.Tittlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer LOG_IN_TIME;
        private System.Windows.Forms.Panel Tittlebar;
        private System.Windows.Forms.Button LOGOOFButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button Closebutton;
    }
}