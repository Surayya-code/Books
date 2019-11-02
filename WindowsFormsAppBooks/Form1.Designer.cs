namespace WindowsFormsAppBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJanr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLangue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAppendBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxRating = new System.Windows.Forms.CheckBox();
            this.listBoxBookList = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(123, 88);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müəllif:";
            // 
            // textBoxJanr
            // 
            this.textBoxJanr.Location = new System.Drawing.Point(123, 128);
            this.textBoxJanr.Name = "textBoxJanr";
            this.textBoxJanr.Size = new System.Drawing.Size(100, 20);
            this.textBoxJanr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Janr:";
            // 
            // textBoxLangue
            // 
            this.textBoxLangue.Location = new System.Drawing.Point(123, 168);
            this.textBoxLangue.Name = "textBoxLangue";
            this.textBoxLangue.Size = new System.Drawing.Size(100, 20);
            this.textBoxLangue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dil:";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(123, 252);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ölçüsü:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(123, 212);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Çap ili:";
            // 
            // btnAppendBook
            // 
            this.btnAppendBook.Location = new System.Drawing.Point(27, 353);
            this.btnAppendBook.Name = "btnAppendBook";
            this.btnAppendBook.Size = new System.Drawing.Size(75, 23);
            this.btnAppendBook.TabIndex = 12;
            this.btnAppendBook.Text = "Əlavə et:";
            this.btnAppendBook.UseVisualStyleBackColor = true;
            this.btnAppendBook.Click += new System.EventHandler(this.btnAppendBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reytinq:";
            // 
            // checkBoxRating
            // 
            this.checkBoxRating.AutoSize = true;
            this.checkBoxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRating.Location = new System.Drawing.Point(207, 294);
            this.checkBoxRating.Name = "checkBoxRating";
            this.checkBoxRating.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRating.TabIndex = 14;
            this.checkBoxRating.UseVisualStyleBackColor = true;
            // 
            // listBoxBookList
            // 
            this.listBoxBookList.FormattingEnabled = true;
            this.listBoxBookList.Location = new System.Drawing.Point(346, 53);
            this.listBoxBookList.Name = "listBoxBookList";
            this.listBoxBookList.Size = new System.Drawing.Size(442, 368);
            this.listBoxBookList.TabIndex = 15;
            this.listBoxBookList.SelectedIndexChanged += new System.EventHandler(this.listBoxBookList_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Yadda Saxla:";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(253, 353);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 23);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Məlumatı Oxu";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxBookList);
            this.Controls.Add(this.checkBoxRating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAppendBook);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLangue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxJanr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLangue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAppendBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxRating;
        private System.Windows.Forms.ListBox listBoxBookList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
    }
}

