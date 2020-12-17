namespace TayMark_Teams
{
    partial class yourMeeting
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
            this.dataGridViewYourMeetings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewYourMeetings
            // 
            this.dataGridViewYourMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYourMeetings.Location = new System.Drawing.Point(176, 126);
            this.dataGridViewYourMeetings.Name = "dataGridViewYourMeetings";
            this.dataGridViewYourMeetings.Size = new System.Drawing.Size(545, 398);
            this.dataGridViewYourMeetings.TabIndex = 1;
            // 
            // yourMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 650);
            this.Controls.Add(this.dataGridViewYourMeetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yourMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yourMeeting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourMeetings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewYourMeetings;
    }
}