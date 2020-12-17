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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn1hr = new System.Windows.Forms.Button();
            this.btn45mins = new System.Windows.Forms.Button();
            this.btn30mins = new System.Windows.Forms.Button();
            this.btn15mins = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.meetingRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tayMarkTeamsDataSet = new TayMark_Teams.TayMarkTeamsDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPickRoom = new System.Windows.Forms.Button();
            this.meetingRoomTableAdapter = new TayMark_Teams.TayMarkTeamsDataSetTableAdapters.meetingRoomTableAdapter();
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingTableAdapter = new TayMark_Teams.TayMarkTeamsDataSetTableAdapters.meetingTableAdapter();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(400, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(497, 359);
            this.panel6.TabIndex = 16;
            // 
            // btn1hr
            // 
            this.btn1hr.BackColor = System.Drawing.Color.DimGray;
            this.btn1hr.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.meetingBindingSource, "duration", true));
            this.btn1hr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1hr.FlatAppearance.BorderSize = 0;
            this.btn1hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1hr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1hr.Location = new System.Drawing.Point(0, 196);
            this.btn1hr.Name = "btn1hr";
            this.btn1hr.Size = new System.Drawing.Size(200, 45);
            this.btn1hr.TabIndex = 22;
            this.btn1hr.Text = "1hr";
            this.btn1hr.UseVisualStyleBackColor = false;
            // 
            // btn45mins
            // 
            this.btn45mins.BackColor = System.Drawing.Color.DimGray;
            this.btn45mins.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.meetingBindingSource, "duration", true));
            this.btn45mins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn45mins.FlatAppearance.BorderSize = 0;
            this.btn45mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn45mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn45mins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn45mins.Location = new System.Drawing.Point(0, 151);
            this.btn45mins.Name = "btn45mins";
            this.btn45mins.Size = new System.Drawing.Size(200, 45);
            this.btn45mins.TabIndex = 21;
            this.btn45mins.Text = "45mins";
            this.btn45mins.UseVisualStyleBackColor = false;
            // 
            // btn30mins
            // 
            this.btn30mins.BackColor = System.Drawing.Color.DimGray;
            this.btn30mins.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.meetingBindingSource, "duration", true));
            this.btn30mins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn30mins.FlatAppearance.BorderSize = 0;
            this.btn30mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30mins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn30mins.Location = new System.Drawing.Point(0, 106);
            this.btn30mins.Name = "btn30mins";
            this.btn30mins.Size = new System.Drawing.Size(200, 45);
            this.btn30mins.TabIndex = 20;
            this.btn30mins.Text = "30mins";
            this.btn30mins.UseVisualStyleBackColor = false;
            // 
            // btn15mins
            // 
            this.btn15mins.BackColor = System.Drawing.Color.DimGray;
            this.btn15mins.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.meetingBindingSource, "duration", true));
            this.btn15mins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn15mins.FlatAppearance.BorderSize = 0;
            this.btn15mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15mins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn15mins.Location = new System.Drawing.Point(0, 61);
            this.btn15mins.Name = "btn15mins";
            this.btn15mins.Size = new System.Drawing.Size(200, 45);
            this.btn15mins.TabIndex = 19;
            this.btn15mins.Text = "15mins";
            this.btn15mins.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.btn1hr);
            this.panel5.Controls.Add(this.btn45mins);
            this.panel5.Controls.Add(this.btn30mins);
            this.panel5.Controls.Add(this.btn15mins);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(200, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 359);
            this.panel5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 61);
            this.label3.TabIndex = 18;
            this.label3.Text = "Duration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 61);
            this.label2.TabIndex = 18;
            this.label2.Text = "ROOMS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.listBoxRooms);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 359);
            this.panel3.TabIndex = 14;
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxRooms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.meetingRoomBindingSource, "name", true));
            this.listBoxRooms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.meetingRoomBindingSource, "name", true));
            this.listBoxRooms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.meetingRoomBindingSource, "capacity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "2"));
            this.listBoxRooms.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.meetingRoomBindingSource, "capacity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "2"));
            this.listBoxRooms.DataSource = this.meetingRoomBindingSource;
            this.listBoxRooms.DisplayMember = "name";
            this.listBoxRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 24;
            this.listBoxRooms.Location = new System.Drawing.Point(0, 61);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(200, 298);
            this.listBoxRooms.TabIndex = 22;
            this.listBoxRooms.ValueMember = "capacity";
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // meetingRoomBindingSource
            // 
            this.meetingRoomBindingSource.DataMember = "meetingRoom";
            this.meetingRoomBindingSource.DataSource = this.tayMarkTeamsDataSet;
            // 
            // tayMarkTeamsDataSet
            // 
            this.tayMarkTeamsDataSet.DataSetName = "TayMarkTeamsDataSet";
            this.tayMarkTeamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnPickRoom);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 193);
            this.panel4.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(239, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(560, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPickRoom
            // 
            this.btnPickRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.btnPickRoom.FlatAppearance.BorderSize = 0;
            this.btnPickRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickRoom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPickRoom.Location = new System.Drawing.Point(32, 6);
            this.btnPickRoom.Name = "btnPickRoom";
            this.btnPickRoom.Size = new System.Drawing.Size(123, 33);
            this.btnPickRoom.TabIndex = 20;
            this.btnPickRoom.Text = "▼";
            this.btnPickRoom.UseVisualStyleBackColor = false;
            // 
            // meetingRoomTableAdapter
            // 
            this.meetingRoomTableAdapter.ClearBeforeFill = true;
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataMember = "meeting";
            this.meetingBindingSource.DataSource = this.tayMarkTeamsDataSet;
            // 
            // meetingTableAdapter
            // 
            this.meetingTableAdapter.ClearBeforeFill = true;
            // 
            // bookupto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 650);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookupto1";
            this.Text = "bookupto1";
            this.Load += new System.EventHandler(this.bookupto1_Load);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn1hr;
        private System.Windows.Forms.Button btn45mins;
        private System.Windows.Forms.Button btn30mins;
        private System.Windows.Forms.Button btn15mins;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPickRoom;
        private TayMarkTeamsDataSet tayMarkTeamsDataSet;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource;
        private TayMarkTeamsDataSetTableAdapters.meetingRoomTableAdapter meetingRoomTableAdapter;
        private System.Windows.Forms.BindingSource meetingBindingSource;
        private TayMarkTeamsDataSetTableAdapters.meetingTableAdapter meetingTableAdapter;
    }
}