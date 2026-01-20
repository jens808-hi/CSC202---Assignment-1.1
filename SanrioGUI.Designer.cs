namespace WinFormsApp1
{
    partial class SanrioGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanrioGUI));
            Quest1 = new Label();
            QuestBtn1 = new Button();
            QuestBtn2 = new Button();
            QuestBtn3 = new Button();
            Quest2 = new Label();
            Yr_label = new Label();
            NumBox = new TextBox();
            CheckInt_btn = new Button();
            Quest3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            Quest4 = new Label();
            NumUpDown = new NumericUpDown();
            NumUpDownBox = new Label();
            WeightBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)NumUpDown).BeginInit();
            SuspendLayout();
            // 
            // Quest1
            // 
            Quest1.AutoSize = true;
            Quest1.Location = new Point(232, 21);
            Quest1.Name = "Quest1";
            Quest1.Size = new Size(324, 20);
            Quest1.TabIndex = 0;
            Quest1.Text = "Who is the most recognizable Sanrio character?";
            // 
            // QuestBtn1
            // 
            QuestBtn1.Location = new Point(137, 55);
            QuestBtn1.Name = "QuestBtn1";
            QuestBtn1.Size = new Size(120, 37);
            QuestBtn1.TabIndex = 1;
            QuestBtn1.Text = "Hello Kitty";
            QuestBtn1.UseVisualStyleBackColor = true;
            QuestBtn1.Click += PushMe_Click;
            // 
            // QuestBtn2
            // 
            QuestBtn2.Location = new Point(297, 55);
            QuestBtn2.Name = "QuestBtn2";
            QuestBtn2.Size = new Size(147, 35);
            QuestBtn2.TabIndex = 2;
            QuestBtn2.Text = "Pompompurin";
            QuestBtn2.UseVisualStyleBackColor = true;
            QuestBtn2.Click += PushMe_Click2;
            // 
            // QuestBtn3
            // 
            QuestBtn3.Location = new Point(489, 54);
            QuestBtn3.Name = "QuestBtn3";
            QuestBtn3.Size = new Size(159, 36);
            QuestBtn3.TabIndex = 3;
            QuestBtn3.Text = "Cinnamonroll";
            QuestBtn3.UseVisualStyleBackColor = true;
            QuestBtn3.Click += PushMe_Click3;
            // 
            // Quest2
            // 
            Quest2.AutoSize = true;
            Quest2.Location = new Point(148, 120);
            Quest2.Name = "Quest2";
            Quest2.Size = new Size(512, 20);
            Quest2.TabIndex = 4;
            Quest2.Text = "What year was Hello Kitty created if she is celebrating her 51st year in 2026?";
            // 
            // Yr_label
            // 
            Yr_label.AutoSize = true;
            Yr_label.Location = new Point(220, 165);
            Yr_label.Name = "Yr_label";
            Yr_label.Size = new Size(37, 20);
            Yr_label.TabIndex = 5;
            Yr_label.Text = "Year";
            // 
            // NumBox
            // 
            NumBox.Location = new Point(269, 165);
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(59, 27);
            NumBox.TabIndex = 6;
            // 
            // CheckInt_btn
            // 
            CheckInt_btn.Location = new Point(360, 165);
            CheckInt_btn.Name = "CheckInt_btn";
            CheckInt_btn.Size = new Size(142, 27);
            CheckInt_btn.TabIndex = 7;
            CheckInt_btn.Text = "Check Year";
            CheckInt_btn.UseVisualStyleBackColor = true;
            CheckInt_btn.Click += CheckInt_Click;
            // 
            // Quest3
            // 
            Quest3.AutoSize = true;
            Quest3.Location = new Point(148, 223);
            Quest3.Name = "Quest3";
            Quest3.Size = new Size(164, 20);
            Quest3.TabIndex = 8;
            Quest3.Text = "How tall is Hello Kitty? ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(318, 223);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "4 Bananas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += Check1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(422, 223);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "5 Apples";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += Check2;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(517, 223);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "7 Oranges";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Click += Check3;
            // 
            // Quest4
            // 
            Quest4.AutoSize = true;
            Quest4.Location = new Point(148, 297);
            Quest4.Name = "Quest4";
            Quest4.Size = new Size(241, 20);
            Quest4.TabIndex = 12;
            Quest4.Text = "How much does Hello Kitty weigh?";
            // 
            // NumUpDown
            // 
            NumUpDown.Location = new Point(395, 295);
            NumUpDown.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            NumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumUpDown.Name = "NumUpDown";
            NumUpDown.Size = new Size(49, 27);
            NumUpDown.TabIndex = 13;
            NumUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // NumUpDownBox
            // 
            NumUpDownBox.AutoSize = true;
            NumUpDownBox.Location = new Point(450, 297);
            NumUpDownBox.Name = "NumUpDownBox";
            NumUpDownBox.Size = new Size(52, 25);
            NumUpDownBox.TabIndex = 14;
            NumUpDownBox.Text = "Apples";
            NumUpDownBox.UseCompatibleTextRendering = true;
            // 
            // WeightBtn
            // 
            WeightBtn.Location = new Point(297, 347);
            WeightBtn.Name = "WeightBtn";
            WeightBtn.Size = new Size(129, 31);
            WeightBtn.TabIndex = 15;
            WeightBtn.Text = "Check Weight";
            WeightBtn.UseVisualStyleBackColor = true;
            WeightBtn.Click += CheckInt_Click2;
            // 
            // SanrioGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(WeightBtn);
            Controls.Add(NumUpDownBox);
            Controls.Add(NumUpDown);
            Controls.Add(Quest4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Quest3);
            Controls.Add(CheckInt_btn);
            Controls.Add(NumBox);
            Controls.Add(Yr_label);
            Controls.Add(Quest2);
            Controls.Add(QuestBtn3);
            Controls.Add(QuestBtn2);
            Controls.Add(QuestBtn1);
            Controls.Add(Quest1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SanrioGUI";
            Text = "Sanrio GUI";
            Load += SanrioGUI_Load;
            ((System.ComponentModel.ISupportInitialize)NumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Quest1;
        private Button QuestBtn1;
        private Button QuestBtn2;
        private Button QuestBtn3;
        private Label Quest2;
        private Label Yr_label;
        private TextBox NumBox;
        private Button CheckInt_btn;
        private Label Quest3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label Quest4;
        private NumericUpDown NumUpDown;
        private Label NumUpDownBox;
        private Button WeightBtn;
    }
}
