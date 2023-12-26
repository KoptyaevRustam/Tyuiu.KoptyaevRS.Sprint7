
namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.labelGuide_KRS = new System.Windows.Forms.Label();
            this.buttonOkey_KRS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGuide_KRS
            // 
            this.labelGuide_KRS.AutoSize = true;
            this.labelGuide_KRS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuide_KRS.Location = new System.Drawing.Point(15, 15);
            this.labelGuide_KRS.Name = "labelGuide_KRS";
            this.labelGuide_KRS.Size = new System.Drawing.Size(710, 153);
            this.labelGuide_KRS.TabIndex = 0;
            this.labelGuide_KRS.Text = resources.GetString("labelGuide_KRS.Text");
            // 
            // buttonOkey_KRS
            // 
            this.buttonOkey_KRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOkey_KRS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOkey_KRS.Location = new System.Drawing.Point(651, 171);
            this.buttonOkey_KRS.Name = "buttonOkey_KRS";
            this.buttonOkey_KRS.Size = new System.Drawing.Size(63, 33);
            this.buttonOkey_KRS.TabIndex = 1;
            this.buttonOkey_KRS.Text = "Ок";
            this.buttonOkey_KRS.UseVisualStyleBackColor = false;
            this.buttonOkey_KRS.Click += new System.EventHandler(this.buttonOkey_KRS_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(726, 216);
            this.Controls.Add(this.buttonOkey_KRS);
            this.Controls.Add(this.labelGuide_KRS);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGuide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuide_KRS;
        private System.Windows.Forms.Button buttonOkey_KRS;
    }
}