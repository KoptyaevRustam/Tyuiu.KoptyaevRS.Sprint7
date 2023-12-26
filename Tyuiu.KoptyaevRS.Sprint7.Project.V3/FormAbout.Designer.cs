
namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout_KRS = new System.Windows.Forms.PictureBox();
            this.labelABOUT_KRS = new System.Windows.Forms.Label();
            this.buttonOK_KRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_KRS
            // 
            this.pictureBoxAbout_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_KRS.Image")));
            this.pictureBoxAbout_KRS.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxAbout_KRS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAbout_KRS.Name = "pictureBoxAbout_KRS";
            this.pictureBoxAbout_KRS.Size = new System.Drawing.Size(208, 212);
            this.pictureBoxAbout_KRS.TabIndex = 0;
            this.pictureBoxAbout_KRS.TabStop = false;
            // 
            // labelABOUT_KRS
            // 
            this.labelABOUT_KRS.AutoSize = true;
            this.labelABOUT_KRS.Location = new System.Drawing.Point(264, 15);
            this.labelABOUT_KRS.Name = "labelABOUT_KRS";
            this.labelABOUT_KRS.Size = new System.Drawing.Size(303, 225);
            this.labelABOUT_KRS.TabIndex = 1;
            this.labelABOUT_KRS.Text = resources.GetString("labelABOUT_KRS.Text");
            // 
            // buttonOK_KRS
            // 
            this.buttonOK_KRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOK_KRS.Location = new System.Drawing.Point(500, 200);
            this.buttonOK_KRS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK_KRS.Name = "buttonOK_KRS";
            this.buttonOK_KRS.Size = new System.Drawing.Size(87, 26);
            this.buttonOK_KRS.TabIndex = 2;
            this.buttonOK_KRS.Text = "Ок";
            this.buttonOK_KRS.UseVisualStyleBackColor = false;
            this.buttonOK_KRS.Click += new System.EventHandler(this.buttonOK_KRS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(612, 240);
            this.Controls.Add(this.buttonOK_KRS);
            this.Controls.Add(this.labelABOUT_KRS);
            this.Controls.Add(this.pictureBoxAbout_KRS);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_KRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_KRS;
        private System.Windows.Forms.Label labelABOUT_KRS;
        private System.Windows.Forms.Button buttonOK_KRS;
    }
}