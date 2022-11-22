namespace MovieManagerApplication
{
	partial class AddMovie
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtMovieTitle = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.cmbBoxGenre = new System.Windows.Forms.ComboBox();
			this.txtRottenScore = new System.Windows.Forms.TextBox();
			this.txtEarnings = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Movie Screen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Movie Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Year:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(116, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Director:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(127, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Genre:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(412, 314);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Box Office Earnings:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(192, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Rotten Tomatoes Score:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Thistle;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Location = new System.Drawing.Point(29, 378);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(729, 59);
			this.panel1.TabIndex = 7;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(616, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(148, 16);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(34, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtMovieTitle
			// 
			this.txtMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMovieTitle.Location = new System.Drawing.Point(192, 80);
			this.txtMovieTitle.Name = "txtMovieTitle";
			this.txtMovieTitle.Size = new System.Drawing.Size(330, 23);
			this.txtMovieTitle.TabIndex = 0;
			// 
			// txtYear
			// 
			this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtYear.Location = new System.Drawing.Point(192, 138);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(100, 23);
			this.txtYear.TabIndex = 1;
			// 
			// txtDirector
			// 
			this.txtDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDirector.Location = new System.Drawing.Point(192, 194);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(204, 23);
			this.txtDirector.TabIndex = 2;
			// 
			// cmbBoxGenre
			// 
			this.cmbBoxGenre.FormattingEnabled = true;
			this.cmbBoxGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
			this.cmbBoxGenre.Location = new System.Drawing.Point(192, 253);
			this.cmbBoxGenre.Name = "cmbBoxGenre";
			this.cmbBoxGenre.Size = new System.Drawing.Size(204, 23);
			this.cmbBoxGenre.TabIndex = 3;
			// 
			// txtRottenScore
			// 
			this.txtRottenScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRottenScore.Location = new System.Drawing.Point(329, 311);
			this.txtRottenScore.Name = "txtRottenScore";
			this.txtRottenScore.Size = new System.Drawing.Size(67, 23);
			this.txtRottenScore.TabIndex = 4;
			// 
			// txtEarnings
			// 
			this.txtEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEarnings.Location = new System.Drawing.Point(531, 311);
			this.txtEarnings.Name = "txtEarnings";
			this.txtEarnings.Size = new System.Drawing.Size(146, 23);
			this.txtEarnings.TabIndex = 5;
			// 
			// AddMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(788, 450);
			this.Controls.Add(this.txtEarnings);
			this.Controls.Add(this.txtRottenScore);
			this.Controls.Add(this.cmbBoxGenre);
			this.Controls.Add(this.txtDirector);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtMovieTitle);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddMovie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Movie";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Panel panel1;
		private Button btnClose;
		private Button btnClear;
		private Button btnAdd;
		private TextBox txtMovieTitle;
		private TextBox txtYear;
		private TextBox txtDirector;
		private ComboBox cmbBoxGenre;
		private TextBox txtRottenScore;
		private TextBox txtEarnings;
	}
}