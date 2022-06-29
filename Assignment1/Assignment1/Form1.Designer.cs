namespace Assignment1
{
    partial class RevealNameProgram
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
            this.buttonRevealName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRevealName
            // 
            this.buttonRevealName.Location = new System.Drawing.Point(31, 70);
            this.buttonRevealName.Name = "buttonRevealName";
            this.buttonRevealName.Size = new System.Drawing.Size(190, 49);
            this.buttonRevealName.TabIndex = 0;
            this.buttonRevealName.Text = "Reveal my Name";
            this.buttonRevealName.UseVisualStyleBackColor = true;
            this.buttonRevealName.Click += new System.EventHandler(this.buttonRevealName_Click);
            // 
            // RevealNameProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 192);
            this.Controls.Add(this.buttonRevealName);
            this.Name = "RevealNameProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reveal Name Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRevealName;
    }
}

