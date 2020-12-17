namespace TayMark_Teams
{
    partial class bookupto1
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
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tayMarkTeamsDataSet = new TayMark_Teams.TayMarkTeamsDataSet();
            this.meetingRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.meetingRoomTableAdapter = new TayMark_Teams.TayMarkTeamsDataSetTableAdapters.meetingRoomTableAdapter();
            this.meetingTableAdapter = new TayMark_Teams.TayMarkTeamsDataSetTableAdapters.meetingTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMeetingDuration = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataMember = "meeting";
            this.meetingBindingSource.DataSource = this.tayMarkTeamsDataSet;
            // 
            // tayMarkTeamsDataSet
            // 
            this.tayMarkTeamsDataSet.DataSetName = "TayMarkTeamsDataSet";
            this.tayMarkTeamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingRoomBindingSource
            // 
            this.meetingRoomBindingSource.DataMember = "meetingRoom";
            this.meetingRoomBindingSource.DataSource = this.tayMarkTeamsDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 98);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book a Room For One";
            // 
            // meetingRoomTableAdapter
            // 
            this.meetingRoomTableAdapter.ClearBeforeFill = true;
            // 
            // meetingTableAdapter
            // 
            this.meetingTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btnBook);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 193);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.comboBoxRoom);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBoxMeetingDuration);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(897, 359);
            this.panel5.TabIndex = 15;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DisplayMember = "name";
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(468, 172);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRoom.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(146)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(518, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(146)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(259, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Meeting Duration";
            // 
            // comboBoxMeetingDuration
            // 
            this.comboBoxMeetingDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeetingDuration.FormattingEnabled = true;
            this.comboBoxMeetingDuration.Items.AddRange(new object[] {
            "15minutes",
            "30minutes",
            "45minutes",
            "1hour"});
            this.comboBoxMeetingDuration.Location = new System.Drawing.Point(253, 172);
            this.comboBoxMeetingDuration.Name = "comboBoxMeetingDuration";
            this.comboBoxMeetingDuration.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMeetingDuration.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.label7.Location = new System.Drawing.Point(352, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(132, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Room:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(146)))), ((int)(((byte)(186)))));
            this.textBox1.Location = new System.Drawing.Point(410, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 17);
            this.textBox1.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(146)))), ((int)(((byte)(186)))));
            this.txtEmail.Location = new System.Drawing.Point(190, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 17);
            this.txtEmail.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(351, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 1);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(131, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 1);
            this.panel2.TabIndex = 26;
            // 
            // btnBook
            // 
            this.btnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBook.Location = new System.Drawing.Point(655, 66);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(161, 33);
            this.btnBook.TabIndex = 25;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // bookupto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 650);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookupto1";
            this.Text = "bookupto1";

            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private TayMarkTeamsDataSet tayMarkTeamsDataSet;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource;
        private TayMarkTeamsDataSetTableAdapters.meetingRoomTableAdapter meetingRoomTableAdapter;
        private System.Windows.Forms.BindingSource meetingBindingSource;
        private TayMarkTeamsDataSetTableAdapters.meetingTableAdapter meetingTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMeetingDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBook;
    }
}