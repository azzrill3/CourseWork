namespace CourseWork
{
    partial class GameForm
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
            this.NewGame = new System.Windows.Forms.Button();
            this.rowsBox = new System.Windows.Forms.ComboBox();
            this.columnsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textureBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(13, 13);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(155, 57);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "Новая Игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // rowsBox
            // 
            this.rowsBox.FormattingEnabled = true;
            this.rowsBox.Items.AddRange(new object[] {
            "5",
            "7",
            "10",
            "13",
            "15",
            "17",
            "20"});
            this.rowsBox.Location = new System.Drawing.Point(275, 13);
            this.rowsBox.Name = "rowsBox";
            this.rowsBox.Size = new System.Drawing.Size(127, 21);
            this.rowsBox.TabIndex = 1;
            // 
            // columnsBox
            // 
            this.columnsBox.FormattingEnabled = true;
            this.columnsBox.Items.AddRange(new object[] {
            "5",
            "7",
            "10",
            "13",
            "15",
            "17",
            "20"});
            this.columnsBox.Location = new System.Drawing.Point(275, 48);
            this.columnsBox.Name = "columnsBox";
            this.columnsBox.Size = new System.Drawing.Size(127, 21);
            this.columnsBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ряды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Столбцы";
            // 
            // textureBox
            // 
            this.textureBox.FormattingEnabled = true;
            this.textureBox.Items.AddRange(new object[] {
            "Обычный",
            "Красивый",
            "Упрощенный"});
            this.textureBox.Location = new System.Drawing.Point(504, 13);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(121, 21);
            this.textureBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стиль";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnsBox);
            this.Controls.Add(this.rowsBox);
            this.Controls.Add(this.NewGame);
            this.Name = "GameForm";
            this.Text = "Головоломка";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.ComboBox rowsBox;
        private System.Windows.Forms.ComboBox columnsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox textureBox;
        private System.Windows.Forms.Label label3;
    }
}

