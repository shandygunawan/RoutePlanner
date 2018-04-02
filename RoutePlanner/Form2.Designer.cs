namespace RoutePlanner
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.StartMarkerRadio = new System.Windows.Forms.RadioButton();
            this.StopMarkerRadio = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add this marker as :";
            // 
            // StartMarkerRadio
            // 
            this.StartMarkerRadio.AutoSize = true;
            this.StartMarkerRadio.Location = new System.Drawing.Point(18, 49);
            this.StartMarkerRadio.Name = "StartMarkerRadio";
            this.StartMarkerRadio.Size = new System.Drawing.Size(122, 24);
            this.StartMarkerRadio.TabIndex = 1;
            this.StartMarkerRadio.TabStop = true;
            this.StartMarkerRadio.Text = "Start Marker";
            this.StartMarkerRadio.UseVisualStyleBackColor = true;
            this.StartMarkerRadio.CheckedChanged += new System.EventHandler(this.StartMarkerRadio_CheckedChanged);
            // 
            // StopMarkerRadio
            // 
            this.StopMarkerRadio.AutoSize = true;
            this.StopMarkerRadio.Location = new System.Drawing.Point(18, 80);
            this.StopMarkerRadio.Name = "StopMarkerRadio";
            this.StopMarkerRadio.Size = new System.Drawing.Size(121, 24);
            this.StopMarkerRadio.TabIndex = 2;
            this.StopMarkerRadio.TabStop = true;
            this.StopMarkerRadio.Text = "Stop Marker";
            this.StopMarkerRadio.UseVisualStyleBackColor = true;
            this.StopMarkerRadio.CheckedChanged += new System.EventHandler(this.StopMarkerRadio_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(18, 119);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(135, 46);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(202, 119);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 46);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 177);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.StopMarkerRadio);
            this.Controls.Add(this.StartMarkerRadio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Start/Stop Marker?";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton StartMarkerRadio;
        private System.Windows.Forms.RadioButton StopMarkerRadio;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
    }
}