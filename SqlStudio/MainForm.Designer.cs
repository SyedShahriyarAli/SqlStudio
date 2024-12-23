namespace SqlStudio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TxtQuery = new System.Windows.Forms.RichTextBox();
            this.QueryPanel = new System.Windows.Forms.Panel();
            this.BtnConnect = new System.Windows.Forms.PictureBox();
            this.CboDatabase = new System.Windows.Forms.ComboBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.ResultPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.QueryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 44);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.TxtQuery);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Panel2.Controls.Add(this.DgvData);
            this.SplitContainer.Size = new System.Drawing.Size(933, 544);
            this.SplitContainer.SplitterDistance = 321;
            this.SplitContainer.SplitterWidth = 5;
            this.SplitContainer.TabIndex = 0;
            // 
            // TxtQuery
            // 
            this.TxtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuery.Location = new System.Drawing.Point(0, 0);
            this.TxtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(933, 321);
            this.TxtQuery.TabIndex = 0;
            this.TxtQuery.Text = "";
            this.TxtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuery_KeyDown);
            // 
            // QueryPanel
            // 
            this.QueryPanel.BackColor = System.Drawing.Color.White;
            this.QueryPanel.Controls.Add(this.ResultPanel);
            this.QueryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QueryPanel.Location = new System.Drawing.Point(0, 0);
            this.QueryPanel.Name = "QueryPanel";
            this.QueryPanel.Size = new System.Drawing.Size(933, 44);
            this.QueryPanel.TabIndex = 1;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnConnect.Image")));
            this.BtnConnect.Location = new System.Drawing.Point(204, 8);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(29, 29);
            this.BtnConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.TabStop = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CboDatabase
            // 
            this.CboDatabase.FormattingEnabled = true;
            this.CboDatabase.Location = new System.Drawing.Point(14, 10);
            this.CboDatabase.Name = "CboDatabase";
            this.CboDatabase.Size = new System.Drawing.Size(183, 25);
            this.CboDatabase.TabIndex = 1;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.Size = new System.Drawing.Size(933, 218);
            this.DgvData.TabIndex = 0;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.CboDatabase);
            this.ResultPanel.Controls.Add(this.BtnConnect);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResultPanel.Location = new System.Drawing.Point(691, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(242, 44);
            this.ResultPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.QueryPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "SQL Management Studio Lite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.QueryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResultPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.RichTextBox TxtQuery;
        private System.Windows.Forms.Panel QueryPanel;
        private System.Windows.Forms.PictureBox BtnConnect;
        private System.Windows.Forms.ComboBox CboDatabase;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Panel ResultPanel;
    }
}

