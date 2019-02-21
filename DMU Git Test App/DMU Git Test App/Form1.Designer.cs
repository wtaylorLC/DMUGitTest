namespace DMU_Git_Test_App
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
            this.pictureBoxMonkey = new System.Windows.Forms.PictureBox();
            this.buttonMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMonkey
            // 
            this.pictureBoxMonkey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonkey.Image = global::DMU_Git_Test_App.Properties.Resources._71wW4LkoLbL__SY450_;
            this.pictureBoxMonkey.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMonkey.Name = "pictureBoxMonkey";
            this.pictureBoxMonkey.Size = new System.Drawing.Size(200, 218);
            this.pictureBoxMonkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonkey.TabIndex = 0;
            this.pictureBoxMonkey.TabStop = false;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.Location = new System.Drawing.Point(12, 236);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(200, 39);
            this.buttonMessage.TabIndex = 1;
            this.buttonMessage.Text = "Click Here";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 284);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.pictureBoxMonkey);
            this.Name = "Form1";
            this.Text = "DMU Git Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMonkey;
        private System.Windows.Forms.Button buttonMessage;
    }
}

