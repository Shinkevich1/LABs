namespace View
{
    partial class FindForm
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
            this.radioButtonTh = new System.Windows.Forms.RadioButton();
            this.radioButtonCol = new System.Windows.Forms.RadioButton();
            this.radioButtonMag = new System.Windows.Forms.RadioButton();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.radioButtonFio = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonTh
            // 
            this.radioButtonTh.AutoSize = true;
            this.radioButtonTh.Location = new System.Drawing.Point(25, 104);
            this.radioButtonTh.Name = "radioButtonTh";
            this.radioButtonTh.Size = new System.Drawing.Size(117, 21);
            this.radioButtonTh.TabIndex = 17;
            this.radioButtonTh.TabStop = true;
            this.radioButtonTh.Text = "Диссертация";
            this.radioButtonTh.UseVisualStyleBackColor = true;
            this.radioButtonTh.CheckedChanged += new System.EventHandler(this.radioButtonTh_CheckedChanged);
            // 
            // radioButtonCol
            // 
            this.radioButtonCol.AutoSize = true;
            this.radioButtonCol.Location = new System.Drawing.Point(25, 77);
            this.radioButtonCol.Name = "radioButtonCol";
            this.radioButtonCol.Size = new System.Drawing.Size(85, 21);
            this.radioButtonCol.TabIndex = 16;
            this.radioButtonCol.TabStop = true;
            this.radioButtonCol.Text = "Сборник";
            this.radioButtonCol.UseVisualStyleBackColor = true;
            this.radioButtonCol.CheckedChanged += new System.EventHandler(this.radioButtonCol_CheckedChanged);
            // 
            // radioButtonMag
            // 
            this.radioButtonMag.AutoSize = true;
            this.radioButtonMag.Location = new System.Drawing.Point(25, 50);
            this.radioButtonMag.Name = "radioButtonMag";
            this.radioButtonMag.Size = new System.Drawing.Size(81, 21);
            this.radioButtonMag.TabIndex = 15;
            this.radioButtonMag.TabStop = true;
            this.radioButtonMag.Text = "Журнал";
            this.radioButtonMag.UseVisualStyleBackColor = true;
            this.radioButtonMag.CheckedChanged += new System.EventHandler(this.radioButtonMag_CheckedChanged);
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Location = new System.Drawing.Point(25, 23);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(67, 21);
            this.radioButtonBook.TabIndex = 14;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Книга";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            this.radioButtonBook.CheckedChanged += new System.EventHandler(this.radioButtonBook_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(294, 216);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 33);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // radioButtonFio
            // 
            this.radioButtonFio.AutoSize = true;
            this.radioButtonFio.Location = new System.Drawing.Point(25, 131);
            this.radioButtonFio.Name = "radioButtonFio";
            this.radioButtonFio.Size = new System.Drawing.Size(113, 21);
            this.radioButtonFio.TabIndex = 19;
            this.radioButtonFio.TabStop = true;
            this.radioButtonFio.Text = "ФИО автора";
            this.radioButtonFio.UseVisualStyleBackColor = true;
            this.radioButtonFio.CheckedChanged += new System.EventHandler(this.radioButtonFio_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(25, 158);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(166, 21);
            this.radioButtonName.TabIndex = 20;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название источника";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Location = new System.Drawing.Point(25, 185);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(112, 21);
            this.radioButtonYear.TabIndex = 21;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Год издания";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButtonYear_CheckedChanged);
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(209, 131);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(175, 22);
            this.textBoxFio.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(209, 159);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 22);
            this.textBoxName.TabIndex = 23;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(209, 187);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(175, 22);
            this.textBoxYear.TabIndex = 24;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.radioButtonYear);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonFio);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.radioButtonTh);
            this.Controls.Add(this.radioButtonCol);
            this.Controls.Add(this.radioButtonMag);
            this.Controls.Add(this.radioButtonBook);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonTh;
        private System.Windows.Forms.RadioButton radioButtonCol;
        private System.Windows.Forms.RadioButton radioButtonMag;
        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RadioButton radioButtonFio;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYear;
    }
}