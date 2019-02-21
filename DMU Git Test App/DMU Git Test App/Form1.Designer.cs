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
            this.pictureBoxMonkey1 = new System.Windows.Forms.PictureBox();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.pictureBoxMonkey2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMonkey1
            // 
            this.pictureBoxMonkey1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonkey1.Image = global::DMU_Git_Test_App.Properties.Resources._71wW4LkoLbL__SY450_;
            this.pictureBoxMonkey1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMonkey1.Name = "pictureBoxMonkey1";
            this.pictureBoxMonkey1.Size = new System.Drawing.Size(200, 218);
            this.pictureBoxMonkey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonkey1.TabIndex = 0;
            this.pictureBoxMonkey1.TabStop = false;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.Location = new System.Drawing.Point(12, 236);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(406, 39);
            this.buttonMessage.TabIndex = 1;
            this.buttonMessage.Text = "Click Here";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // pictureBoxMonkey2
            // 
            this.pictureBoxMonkey2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonkey2.Image = global::DMU_Git_Test_App.Properties.Resources._10b4a3741f78eabb90b705eaf3b5328f;
            this.pictureBoxMonkey2.Location = new System.Drawing.Point(218, 12);
            this.pictureBoxMonkey2.Name = "pictureBoxMonkey2";
            this.pictureBoxMonkey2.Size = new System.Drawing.Size(200, 218);
            this.pictureBoxMonkey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonkey2.TabIndex = 2;
            this.pictureBoxMonkey2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 284);
            this.Controls.Add(this.pictureBoxMonkey2);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.pictureBoxMonkey1);
            this.Name = "Form1";
            this.Text = "DMU Git Test - Monkeys";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonkey2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMonkey1;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.PictureBox pictureBoxMonkey2;
    }
}

