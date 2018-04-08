namespace WindowsFormsApplication4
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
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.resultsListbox = new System.Windows.Forms.ListBox();
            this.searchOmdbBtn = new System.Windows.Forms.Button();
            this.movieTitleDisplay_textbox = new System.Windows.Forms.TextBox();
            this.yearDisplay_textbox = new System.Windows.Forms.TextBox();
            this.runtimeDisplay_textbox = new System.Windows.Forms.TextBox();
            this.plotDisplay_textbox = new System.Windows.Forms.TextBox();
            this.imdbRating_textbox = new System.Windows.Forms.TextBox();
            this.boxOfficeDisplay_textbox = new System.Windows.Forms.TextBox();
            this.moviePosterDisplay_picturebox = new System.Windows.Forms.PictureBox();
            this.genreDisplay_textbox = new System.Windows.Forms.TextBox();
            this.searchOnTextboxInput_radioButton = new System.Windows.Forms.RadioButton();
            this.searchSelectedMovieFromList_radioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToWatchlist_button = new System.Windows.Forms.Button();
            this.imdbIdDisplay_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterDisplay_picturebox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.Location = new System.Drawing.Point(12, 12);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(469, 42);
            this.searchTxtbox.TabIndex = 0;
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // resultsListbox
            // 
            this.resultsListbox.FormattingEnabled = true;
            this.resultsListbox.ItemHeight = 16;
            this.resultsListbox.Location = new System.Drawing.Point(12, 142);
            this.resultsListbox.Name = "resultsListbox";
            this.resultsListbox.Size = new System.Drawing.Size(469, 436);
            this.resultsListbox.TabIndex = 1;
            // 
            // searchOmdbBtn
            // 
            this.searchOmdbBtn.Location = new System.Drawing.Point(270, 60);
            this.searchOmdbBtn.Name = "searchOmdbBtn";
            this.searchOmdbBtn.Size = new System.Drawing.Size(211, 73);
            this.searchOmdbBtn.TabIndex = 3;
            this.searchOmdbBtn.Text = "Search Omdb for more info";
            this.searchOmdbBtn.UseVisualStyleBackColor = true;
            this.searchOmdbBtn.Click += new System.EventHandler(this.searchOmdbBtn_Click);
            // 
            // movieTitleDisplay_textbox
            // 
            this.movieTitleDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.movieTitleDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleDisplay_textbox.Location = new System.Drawing.Point(507, 12);
            this.movieTitleDisplay_textbox.Multiline = true;
            this.movieTitleDisplay_textbox.Name = "movieTitleDisplay_textbox";
            this.movieTitleDisplay_textbox.Size = new System.Drawing.Size(480, 321);
            this.movieTitleDisplay_textbox.TabIndex = 4;
            // 
            // yearDisplay_textbox
            // 
            this.yearDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.yearDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearDisplay_textbox.Location = new System.Drawing.Point(883, 339);
            this.yearDisplay_textbox.Name = "yearDisplay_textbox";
            this.yearDisplay_textbox.Size = new System.Drawing.Size(93, 22);
            this.yearDisplay_textbox.TabIndex = 5;
            // 
            // runtimeDisplay_textbox
            // 
            this.runtimeDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.runtimeDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeDisplay_textbox.Location = new System.Drawing.Point(777, 339);
            this.runtimeDisplay_textbox.Name = "runtimeDisplay_textbox";
            this.runtimeDisplay_textbox.Size = new System.Drawing.Size(100, 22);
            this.runtimeDisplay_textbox.TabIndex = 6;
            // 
            // plotDisplay_textbox
            // 
            this.plotDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.plotDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotDisplay_textbox.Location = new System.Drawing.Point(507, 367);
            this.plotDisplay_textbox.Multiline = true;
            this.plotDisplay_textbox.Name = "plotDisplay_textbox";
            this.plotDisplay_textbox.Size = new System.Drawing.Size(455, 124);
            this.plotDisplay_textbox.TabIndex = 7;
            // 
            // imdbRating_textbox
            // 
            this.imdbRating_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.imdbRating_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRating_textbox.Location = new System.Drawing.Point(508, 506);
            this.imdbRating_textbox.Multiline = true;
            this.imdbRating_textbox.Name = "imdbRating_textbox";
            this.imdbRating_textbox.Size = new System.Drawing.Size(263, 33);
            this.imdbRating_textbox.TabIndex = 8;
            // 
            // boxOfficeDisplay_textbox
            // 
            this.boxOfficeDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.boxOfficeDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOfficeDisplay_textbox.Location = new System.Drawing.Point(508, 545);
            this.boxOfficeDisplay_textbox.Multiline = true;
            this.boxOfficeDisplay_textbox.Name = "boxOfficeDisplay_textbox";
            this.boxOfficeDisplay_textbox.Size = new System.Drawing.Size(263, 34);
            this.boxOfficeDisplay_textbox.TabIndex = 9;
            // 
            // moviePosterDisplay_picturebox
            // 
            this.moviePosterDisplay_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moviePosterDisplay_picturebox.Location = new System.Drawing.Point(1008, 12);
            this.moviePosterDisplay_picturebox.Name = "moviePosterDisplay_picturebox";
            this.moviePosterDisplay_picturebox.Size = new System.Drawing.Size(234, 321);
            this.moviePosterDisplay_picturebox.TabIndex = 11;
            this.moviePosterDisplay_picturebox.TabStop = false;
            // 
            // genreDisplay_textbox
            // 
            this.genreDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.genreDisplay_textbox.Location = new System.Drawing.Point(507, 339);
            this.genreDisplay_textbox.Name = "genreDisplay_textbox";
            this.genreDisplay_textbox.Size = new System.Drawing.Size(263, 22);
            this.genreDisplay_textbox.TabIndex = 12;
            // 
            // searchOnTextboxInput_radioButton
            // 
            this.searchOnTextboxInput_radioButton.AutoSize = true;
            this.searchOnTextboxInput_radioButton.Location = new System.Drawing.Point(6, 35);
            this.searchOnTextboxInput_radioButton.Name = "searchOnTextboxInput_radioButton";
            this.searchOnTextboxInput_radioButton.Size = new System.Drawing.Size(91, 21);
            this.searchOnTextboxInput_radioButton.TabIndex = 13;
            this.searchOnTextboxInput_radioButton.TabStop = true;
            this.searchOnTextboxInput_radioButton.Text = "Text input";
            this.searchOnTextboxInput_radioButton.UseVisualStyleBackColor = true;
            // 
            // searchSelectedMovieFromList_radioButton
            // 
            this.searchSelectedMovieFromList_radioButton.AutoSize = true;
            this.searchSelectedMovieFromList_radioButton.Location = new System.Drawing.Point(103, 35);
            this.searchSelectedMovieFromList_radioButton.Name = "searchSelectedMovieFromList_radioButton";
            this.searchSelectedMovieFromList_radioButton.Size = new System.Drawing.Size(135, 21);
            this.searchSelectedMovieFromList_radioButton.TabIndex = 14;
            this.searchSelectedMovieFromList_radioButton.TabStop = true;
            this.searchSelectedMovieFromList_radioButton.Text = "Selected list item";
            this.searchSelectedMovieFromList_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchOnTextboxInput_radioButton);
            this.groupBox1.Controls.Add(this.searchSelectedMovieFromList_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 78);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose search method";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1254, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(19, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // saveToWatchlist_button
            // 
            this.saveToWatchlist_button.Location = new System.Drawing.Point(778, 506);
            this.saveToWatchlist_button.Name = "saveToWatchlist_button";
            this.saveToWatchlist_button.Size = new System.Drawing.Size(184, 33);
            this.saveToWatchlist_button.TabIndex = 17;
            this.saveToWatchlist_button.Text = "Save to watch list";
            this.saveToWatchlist_button.UseVisualStyleBackColor = true;
            this.saveToWatchlist_button.Click += new System.EventHandler(this.saveToWatchlist_button_Click);
            // 
            // imdbIdDisplay_textbox
            // 
            this.imdbIdDisplay_textbox.Location = new System.Drawing.Point(982, 339);
            this.imdbIdDisplay_textbox.Name = "imdbIdDisplay_textbox";
            this.imdbIdDisplay_textbox.Size = new System.Drawing.Size(10, 22);
            this.imdbIdDisplay_textbox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 593);
            this.Controls.Add(this.imdbIdDisplay_textbox);
            this.Controls.Add(this.saveToWatchlist_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.genreDisplay_textbox);
            this.Controls.Add(this.moviePosterDisplay_picturebox);
            this.Controls.Add(this.boxOfficeDisplay_textbox);
            this.Controls.Add(this.imdbRating_textbox);
            this.Controls.Add(this.plotDisplay_textbox);
            this.Controls.Add(this.runtimeDisplay_textbox);
            this.Controls.Add(this.yearDisplay_textbox);
            this.Controls.Add(this.movieTitleDisplay_textbox);
            this.Controls.Add(this.searchOmdbBtn);
            this.Controls.Add(this.resultsListbox);
            this.Controls.Add(this.searchTxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterDisplay_picturebox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.ListBox resultsListbox;
        private System.Windows.Forms.Button searchOmdbBtn;
        private System.Windows.Forms.TextBox movieTitleDisplay_textbox;
        private System.Windows.Forms.TextBox yearDisplay_textbox;
        private System.Windows.Forms.TextBox runtimeDisplay_textbox;
        private System.Windows.Forms.TextBox plotDisplay_textbox;
        private System.Windows.Forms.TextBox imdbRating_textbox;
        private System.Windows.Forms.TextBox boxOfficeDisplay_textbox;
        private System.Windows.Forms.PictureBox moviePosterDisplay_picturebox;
        private System.Windows.Forms.TextBox genreDisplay_textbox;
        private System.Windows.Forms.RadioButton searchOnTextboxInput_radioButton;
        private System.Windows.Forms.RadioButton searchSelectedMovieFromList_radioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Button saveToWatchlist_button;
        private System.Windows.Forms.TextBox imdbIdDisplay_textbox;
    }
}

