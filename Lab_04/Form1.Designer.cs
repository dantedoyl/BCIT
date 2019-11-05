namespace Lab_04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxReadTime = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.lableTimeRead = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTimeSearch = new System.Windows.Forms.Label();
            this.textBoxTimeSearch = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelDist = new System.Windows.Forms.Label();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чтение файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSearch.Location = new System.Drawing.Point(503, 64);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBoxReadTime
            // 
            this.textBoxReadTime.Location = new System.Drawing.Point(156, 93);
            this.textBoxReadTime.Name = "textBoxReadTime";
            this.textBoxReadTime.ReadOnly = true;
            this.textBoxReadTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxReadTime.TabIndex = 3;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(156, 126);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
            // 
            // lableTimeRead
            // 
            this.lableTimeRead.AutoSize = true;
            this.lableTimeRead.Location = new System.Drawing.Point(20, 93);
            this.lableTimeRead.Name = "lableTimeRead";
            this.lableTimeRead.Size = new System.Drawing.Size(77, 13);
            this.lableTimeRead.TabIndex = 5;
            this.lableTimeRead.Text = "Время чтения";
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(20, 126);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(93, 13);
            this.labelWords.TabIndex = 6;
            this.labelWords.Text = "Количество слов";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(629, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelTimeSearch
            // 
            this.labelTimeSearch.AutoSize = true;
            this.labelTimeSearch.Location = new System.Drawing.Point(411, 96);
            this.labelTimeSearch.Name = "labelTimeSearch";
            this.labelTimeSearch.Size = new System.Drawing.Size(88, 13);
            this.labelTimeSearch.TabIndex = 8;
            this.labelTimeSearch.Text = "Веремя поиска:";
            this.labelTimeSearch.Click += new System.EventHandler(this.LabelTimeSearch_Click);
            // 
            // textBoxTimeSearch
            // 
            this.textBoxTimeSearch.Location = new System.Drawing.Point(505, 93);
            this.textBoxTimeSearch.Name = "textBoxTimeSearch";
            this.textBoxTimeSearch.ReadOnly = true;
            this.textBoxTimeSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeSearch.TabIndex = 9;
            this.textBoxTimeSearch.TextChanged += new System.EventHandler(this.TextBoxTimeSearch_TextChanged);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(383, 143);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(220, 160);
            this.listBoxResult.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(502, 44);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(101, 13);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Слово для поиска:";
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Location = new System.Drawing.Point(347, 44);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(149, 13);
            this.labelDist.TabIndex = 12;
            this.labelDist.Text = "Максимальное расстояние:";
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(350, 63);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(146, 20);
            this.textBoxDist.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.labelDist);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxTimeSearch);
            this.Controls.Add(this.labelTimeSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.lableTimeRead);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxReadTime);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxReadTime;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label lableTimeRead;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTimeSearch;
        private System.Windows.Forms.TextBox textBoxTimeSearch;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.TextBox textBoxDist;
    }
}

