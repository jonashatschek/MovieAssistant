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
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterDisplay_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.Location = new System.Drawing.Point(12, 12);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(319, 44);
            this.searchTxtbox.TabIndex = 0;
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // resultsListbox
            // 
            this.resultsListbox.FormattingEnabled = true;
            this.resultsListbox.ItemHeight = 16;
            this.resultsListbox.Location = new System.Drawing.Point(12, 62);
            this.resultsListbox.Name = "resultsListbox";
            this.resultsListbox.Size = new System.Drawing.Size(319, 372);
            this.resultsListbox.TabIndex = 1;
            // 
            // searchOmdbBtn
            // 
            this.searchOmdbBtn.Location = new System.Drawing.Point(12, 450);
            this.searchOmdbBtn.Name = "searchOmdbBtn";
            this.searchOmdbBtn.Size = new System.Drawing.Size(319, 51);
            this.searchOmdbBtn.TabIndex = 3;
            this.searchOmdbBtn.Text = "Search Omdb for more info";
            this.searchOmdbBtn.UseVisualStyleBackColor = true;
            this.searchOmdbBtn.Click += new System.EventHandler(this.searchOmdbBtn_Click);
            // 
            // movieTitleDisplay_textbox
            // 
            this.movieTitleDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.movieTitleDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleDisplay_textbox.Location = new System.Drawing.Point(349, 12);
            this.movieTitleDisplay_textbox.Multiline = true;
            this.movieTitleDisplay_textbox.Name = "movieTitleDisplay_textbox";
            this.movieTitleDisplay_textbox.Size = new System.Drawing.Size(263, 146);
            this.movieTitleDisplay_textbox.TabIndex = 4;
            // 
            // yearDisplay_textbox
            // 
            this.yearDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.yearDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearDisplay_textbox.Location = new System.Drawing.Point(349, 165);
            this.yearDisplay_textbox.Name = "yearDisplay_textbox";
            this.yearDisplay_textbox.Size = new System.Drawing.Size(93, 22);
            this.yearDisplay_textbox.TabIndex = 5;
            // 
            // runtimeDisplay_textbox
            // 
            this.runtimeDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.runtimeDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeDisplay_textbox.Location = new System.Drawing.Point(349, 191);
            this.runtimeDisplay_textbox.Name = "runtimeDisplay_textbox";
            this.runtimeDisplay_textbox.Size = new System.Drawing.Size(100, 22);
            this.runtimeDisplay_textbox.TabIndex = 6;
            // 
            // plotDisplay_textbox
            // 
            this.plotDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.plotDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotDisplay_textbox.Location = new System.Drawing.Point(348, 247);
            this.plotDisplay_textbox.Multiline = true;
            this.plotDisplay_textbox.Name = "plotDisplay_textbox";
            this.plotDisplay_textbox.Size = new System.Drawing.Size(455, 124);
            this.plotDisplay_textbox.TabIndex = 7;
            // 
            // imdbRating_textbox
            // 
            this.imdbRating_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.imdbRating_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRating_textbox.Location = new System.Drawing.Point(348, 377);
            this.imdbRating_textbox.Multiline = true;
            this.imdbRating_textbox.Name = "imdbRating_textbox";
            this.imdbRating_textbox.Size = new System.Drawing.Size(263, 33);
            this.imdbRating_textbox.TabIndex = 8;
            // 
            // boxOfficeDisplay_textbox
            // 
            this.boxOfficeDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.boxOfficeDisplay_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOfficeDisplay_textbox.Location = new System.Drawing.Point(349, 450);
            this.boxOfficeDisplay_textbox.Multiline = true;
            this.boxOfficeDisplay_textbox.Name = "boxOfficeDisplay_textbox";
            this.boxOfficeDisplay_textbox.Size = new System.Drawing.Size(263, 34);
            this.boxOfficeDisplay_textbox.TabIndex = 9;
            // 
            // moviePosterDisplay_picturebox
            // 
            this.moviePosterDisplay_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moviePosterDisplay_picturebox.Location = new System.Drawing.Point(618, 13);
            this.moviePosterDisplay_picturebox.Name = "moviePosterDisplay_picturebox";
            this.moviePosterDisplay_picturebox.Size = new System.Drawing.Size(185, 228);
            this.moviePosterDisplay_picturebox.TabIndex = 11;
            this.moviePosterDisplay_picturebox.TabStop = false;
            // 
            // genreDisplay_textbox
            // 
            this.genreDisplay_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.genreDisplay_textbox.Location = new System.Drawing.Point(349, 219);
            this.genreDisplay_textbox.Name = "genreDisplay_textbox";
            this.genreDisplay_textbox.Size = new System.Drawing.Size(263, 22);
            this.genreDisplay_textbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 513);
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
    }
}

