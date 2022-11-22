namespace MovieManagerApplication
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAddMovie = new System.Windows.Forms.ToolStripMenuItem();
			this.updateMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvMovies = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.btnAbout});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(990, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(134, 22);
			this.btnRefresh.Text = "Refresh List";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(134, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// maintenanceToolStripMenuItem
			// 
			this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMovie,
            this.updateMovieToolStripMenuItem,
            this.deleteMovieToolStripMenuItem});
			this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
			this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.maintenanceToolStripMenuItem.Text = "Maintenance";
			// 
			// btnAddMovie
			// 
			this.btnAddMovie.Name = "btnAddMovie";
			this.btnAddMovie.Size = new System.Drawing.Size(180, 22);
			this.btnAddMovie.Text = "Add Movie";
			this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
			// 
			// updateMovieToolStripMenuItem
			// 
			this.updateMovieToolStripMenuItem.Name = "updateMovieToolStripMenuItem";
			this.updateMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.updateMovieToolStripMenuItem.Text = "Update Movie";
			// 
			// deleteMovieToolStripMenuItem
			// 
			this.deleteMovieToolStripMenuItem.Name = "deleteMovieToolStripMenuItem";
			this.deleteMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteMovieToolStripMenuItem.Text = "Delete Movie";
			// 
			// btnAbout
			// 
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(52, 20);
			this.btnAbout.Text = "About";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// dgvMovies
			// 
			this.dgvMovies.AllowUserToOrderColumns = true;
			this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMovies.Location = new System.Drawing.Point(12, 70);
			this.dgvMovies.Name = "dgvMovies";
			this.dgvMovies.RowTemplate.Height = 25;
			this.dgvMovies.Size = new System.Drawing.Size(966, 439);
			this.dgvMovies.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Movie Master List";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(990, 521);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvMovies);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Movie Manager Application";
			this.Load += new System.EventHandler(this.Main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem maintenanceToolStripMenuItem;
		private ToolStripMenuItem btnAbout;
		private ToolStripMenuItem btnRefresh;
		private ToolStripMenuItem mnuExit;
		private ToolStripMenuItem btnAddMovie;
		private ToolStripMenuItem updateMovieToolStripMenuItem;
		private ToolStripMenuItem deleteMovieToolStripMenuItem;
		private DataGridView dgvMovies;
		private Label label1;
	}
}