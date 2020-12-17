namespace TayMark_Teams
{
    partial class roomInformation
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
            this.dataGridViewRoomInfo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingRoomBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tayMarkTeamsDataSetRoomInformation = new TayMark_Teams.TayMarkTeamsDataSetRoomInformation();
            this.meetingRoomDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.meetingRoomBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.meetingRoomTableAdapter = new TayMark_Teams.TayMarkTeamsDataSetRoomInformationTableAdapters.meetingRoomTableAdapter();
            this.tayMarkTeamsDataSetRoomInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSetRoomInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSetRoomInformationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRoomInfo
            // 
            this.dataGridViewRoomInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoomInfo.AutoGenerateColumns = false;
            this.dataGridViewRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridViewRoomInfo.DataSource = this.meetingRoomBindingSource3;
            this.dataGridViewRoomInfo.Location = new System.Drawing.Point(64, 104);
            this.dataGridViewRoomInfo.Name = "dataGridViewRoomInfo";
            this.dataGridViewRoomInfo.Size = new System.Drawing.Size(647, 546);
            this.dataGridViewRoomInfo.TabIndex = 0;
            this.dataGridViewRoomInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoomInfo_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // meetingRoomBindingSource3
            // 
            this.meetingRoomBindingSource3.DataMember = "meetingRoom";
            this.meetingRoomBindingSource3.DataSource = this.tayMarkTeamsDataSetRoomInformation;
            // 
            // tayMarkTeamsDataSetRoomInformation
            // 
            this.tayMarkTeamsDataSetRoomInformation.DataSetName = "TayMarkTeamsDataSetRoomInformation";
            this.tayMarkTeamsDataSetRoomInformation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingRoomDataTableBindingSource
            // 
            this.meetingRoomDataTableBindingSource.DataSource = typeof(TayMark_Teams.TayMarkTeamsDataSet.meetingRoomDataTable);
            // 
            // meetingTableAdapterBindingSource
            // 
            this.meetingTableAdapterBindingSource.DataSource = typeof(TayMark_Teams.TayMarkTeamsDataSetTableAdapters.meetingTableAdapter);
            // 
            // meetingRoomBindingSource
            // 
            this.meetingRoomBindingSource.DataMember = "meetingRoom";
            // 
            // meetingRoomBindingSource1
            // 
            this.meetingRoomBindingSource1.DataMember = "meetingRoom";
            // 
            // meetingRoomBindingSource2
            // 
            this.meetingRoomBindingSource2.DataMember = "meetingRoom";
            this.meetingRoomBindingSource2.DataSource = this.tayMarkTeamsDataSetRoomInformation;
            // 
            // meetingRoomTableAdapter
            // 
            this.meetingRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tayMarkTeamsDataSetRoomInformationBindingSource
            // 
            this.tayMarkTeamsDataSetRoomInformationBindingSource.DataSource = this.tayMarkTeamsDataSetRoomInformation;
            this.tayMarkTeamsDataSetRoomInformationBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 98);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Information";
            // 
            // roomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRoomInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "roomInformation";
            this.Load += new System.EventHandler(this.roomInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSetRoomInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tayMarkTeamsDataSetRoomInformationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoomInfo;
        private System.Windows.Forms.BindingSource meetingRoomDataTableBindingSource;
        private System.Windows.Forms.BindingSource meetingTableAdapterBindingSource;
         private System.Windows.Forms.BindingSource meetingRoomBindingSource;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource1;
        private TayMarkTeamsDataSetRoomInformation tayMarkTeamsDataSetRoomInformation;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource2;
        private TayMarkTeamsDataSetRoomInformationTableAdapters.meetingRoomTableAdapter meetingRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource3;
        private System.Windows.Forms.BindingSource tayMarkTeamsDataSetRoomInformationBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}