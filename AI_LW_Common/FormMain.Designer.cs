namespace AI_LW3
{
    partial class FormMain
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
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.ButtonSelectImage = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonLearning = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ComboBoxSelectLetter = new System.Windows.Forms.ComboBox();
            this.ButtonRecognize = new System.Windows.Forms.Button();
            this.LabelIterationsCount = new System.Windows.Forms.Label();
            this.NumericUpDownIterationsCount = new System.Windows.Forms.NumericUpDown();
            this.ProgressBarProgress = new System.Windows.Forms.ProgressBar();
            this.RichTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.TextBoxSaveImageAs = new System.Windows.Forms.TextBox();
            this.ButtonClearChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterationsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxImage.Location = new System.Drawing.Point(16, 16);
            this.PictureBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 0;
            this.PictureBoxImage.TabStop = false;
            this.PictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImage_MouseDown);
            this.PictureBoxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImage_MouseMove);
            this.PictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImage_MouseUp);
            // 
            // ButtonSelectImage
            // 
            this.ButtonSelectImage.AutoSize = true;
            this.ButtonSelectImage.BackColor = System.Drawing.Color.White;
            this.ButtonSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSelectImage.Location = new System.Drawing.Point(348, 119);
            this.ButtonSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSelectImage.Name = "ButtonSelectImage";
            this.ButtonSelectImage.Size = new System.Drawing.Size(322, 44);
            this.ButtonSelectImage.TabIndex = 1;
            this.ButtonSelectImage.Text = "Выбрать образ";
            this.ButtonSelectImage.UseVisualStyleBackColor = false;
            this.ButtonSelectImage.Click += new System.EventHandler(this.ButtonSelectImage_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.AutoSize = true;
            this.ButtonExit.BackColor = System.Drawing.Color.White;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(349, 424);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(322, 44);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonLearning
            // 
            this.ButtonLearning.AutoSize = true;
            this.ButtonLearning.BackColor = System.Drawing.Color.White;
            this.ButtonLearning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLearning.Location = new System.Drawing.Point(348, 259);
            this.ButtonLearning.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLearning.Name = "ButtonLearning";
            this.ButtonLearning.Size = new System.Drawing.Size(321, 44);
            this.ButtonLearning.TabIndex = 3;
            this.ButtonLearning.Text = "Обучиться";
            this.ButtonLearning.UseVisualStyleBackColor = false;
            this.ButtonLearning.Click += new System.EventHandler(this.ButtonLearning_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.AutoSize = true;
            this.ButtonClear.BackColor = System.Drawing.Color.White;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.Location = new System.Drawing.Point(348, 16);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(322, 44);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "Очистить поле";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(348, 68);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(322, 44);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Сохранить образ";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ComboBoxSelectLetter
            // 
            this.ComboBoxSelectLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxSelectLetter.DisplayMember = "0";
            this.ComboBoxSelectLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectLetter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSelectLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxSelectLetter.FormattingEnabled = true;
            this.ComboBoxSelectLetter.Items.AddRange(new object[] {
            "П",
            "Е",
            "Т",
            "Л",
            "И",
            "Н",
            "М"});
            this.ComboBoxSelectLetter.Location = new System.Drawing.Point(173, 137);
            this.ComboBoxSelectLetter.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxSelectLetter.Name = "ComboBoxSelectLetter";
            this.ComboBoxSelectLetter.Size = new System.Drawing.Size(169, 33);
            this.ComboBoxSelectLetter.TabIndex = 9;
            this.ComboBoxSelectLetter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectLetter_SelectedIndexChanged);
            // 
            // ButtonRecognize
            // 
            this.ButtonRecognize.BackColor = System.Drawing.Color.White;
            this.ButtonRecognize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRecognize.Location = new System.Drawing.Point(348, 171);
            this.ButtonRecognize.Name = "ButtonRecognize";
            this.ButtonRecognize.Size = new System.Drawing.Size(321, 44);
            this.ButtonRecognize.TabIndex = 10;
            this.ButtonRecognize.Text = "Опознать образ";
            this.ButtonRecognize.UseVisualStyleBackColor = false;
            this.ButtonRecognize.Click += new System.EventHandler(this.ButtonRecognize_Click);
            // 
            // LabelIterationsCount
            // 
            this.LabelIterationsCount.AutoSize = true;
            this.LabelIterationsCount.Location = new System.Drawing.Point(348, 228);
            this.LabelIterationsCount.Name = "LabelIterationsCount";
            this.LabelIterationsCount.Size = new System.Drawing.Size(308, 25);
            this.LabelIterationsCount.TabIndex = 12;
            this.LabelIterationsCount.Text = "Количество итераций обучения";
            // 
            // NumericUpDownIterationsCount
            // 
            this.NumericUpDownIterationsCount.Location = new System.Drawing.Point(616, 226);
            this.NumericUpDownIterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIterationsCount.Name = "NumericUpDownIterationsCount";
            this.NumericUpDownIterationsCount.Size = new System.Drawing.Size(53, 30);
            this.NumericUpDownIterationsCount.TabIndex = 13;
            this.NumericUpDownIterationsCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ProgressBarProgress
            // 
            this.ProgressBarProgress.Location = new System.Drawing.Point(348, 310);
            this.ProgressBarProgress.Name = "ProgressBarProgress";
            this.ProgressBarProgress.Size = new System.Drawing.Size(321, 34);
            this.ProgressBarProgress.TabIndex = 14;
            // 
            // RichTextBoxChat
            // 
            this.RichTextBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBoxChat.Location = new System.Drawing.Point(16, 225);
            this.RichTextBoxChat.Name = "RichTextBoxChat";
            this.RichTextBoxChat.ReadOnly = true;
            this.RichTextBoxChat.Size = new System.Drawing.Size(326, 243);
            this.RichTextBoxChat.TabIndex = 15;
            this.RichTextBoxChat.Text = "";
            // 
            // TextBoxSaveImageAs
            // 
            this.TextBoxSaveImageAs.BackColor = System.Drawing.Color.White;
            this.TextBoxSaveImageAs.Location = new System.Drawing.Point(173, 16);
            this.TextBoxSaveImageAs.Multiline = true;
            this.TextBoxSaveImageAs.Name = "TextBoxSaveImageAs";
            this.TextBoxSaveImageAs.ReadOnly = true;
            this.TextBoxSaveImageAs.Size = new System.Drawing.Size(169, 114);
            this.TextBoxSaveImageAs.TabIndex = 16;
            this.TextBoxSaveImageAs.Text = "Если будете сохранять образ, то укажите для какой буквы он сохраняется";
            // 
            // ButtonClearChat
            // 
            this.ButtonClearChat.BackColor = System.Drawing.Color.White;
            this.ButtonClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClearChat.Location = new System.Drawing.Point(349, 373);
            this.ButtonClearChat.Name = "ButtonClearChat";
            this.ButtonClearChat.Size = new System.Drawing.Size(322, 44);
            this.ButtonClearChat.TabIndex = 17;
            this.ButtonClearChat.Text = "Очистить чат";
            this.ButtonClearChat.UseVisualStyleBackColor = false;
            this.ButtonClearChat.Click += new System.EventHandler(this.ButtonClearChat_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 485);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonClearChat);
            this.Controls.Add(this.TextBoxSaveImageAs);
            this.Controls.Add(this.RichTextBoxChat);
            this.Controls.Add(this.ProgressBarProgress);
            this.Controls.Add(this.NumericUpDownIterationsCount);
            this.Controls.Add(this.LabelIterationsCount);
            this.Controls.Add(this.ButtonRecognize);
            this.Controls.Add(this.ComboBoxSelectLetter);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonLearning);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSelectImage);
            this.Controls.Add(this.PictureBoxImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Опознание буков";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIterationsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PictureBoxImage;
        private Button ButtonSelectImage;
        private Button ButtonExit;
        private Button ButtonLearning;
        private Button ButtonClear;
        private Button ButtonSave;
        private ComboBox ComboBoxSelectLetter;
        private Button ButtonRecognize;
        private Label LabelIterationsCount;
        private NumericUpDown NumericUpDownIterationsCount;
        private ProgressBar ProgressBarProgress;
        private RichTextBox RichTextBoxChat;
        private TextBox TextBoxSaveImageAs;
        private Button ButtonClearChat;
    }
}