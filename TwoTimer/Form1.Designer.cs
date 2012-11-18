namespace TwoTimer
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
          this.components = new System.ComponentModel.Container();
          this.timer1Text = new System.Windows.Forms.TextBox();
          this.timer2Text = new System.Windows.Forms.TextBox();
          this.startStopButton = new System.Windows.Forms.Button();
          this.resetButton = new System.Windows.Forms.Button();
          this.whichTimerButton = new System.Windows.Forms.Button();
          this.timer1Label = new System.Windows.Forms.Label();
          this.timer2Label = new System.Windows.Forms.Label();
          this.timer = new System.Windows.Forms.Timer(this.components);
          this.taskGrid = new System.Windows.Forms.DataGridView();
          this.TaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).BeginInit();
          this.SuspendLayout();
          // 
          // timer1Text
          // 
          this.timer1Text.Location = new System.Drawing.Point(12, 12);
          this.timer1Text.Name = "timer1Text";
          this.timer1Text.Size = new System.Drawing.Size(100, 20);
          this.timer1Text.TabIndex = 0;
          this.timer1Text.Text = "25";
          // 
          // timer2Text
          // 
          this.timer2Text.Location = new System.Drawing.Point(245, 12);
          this.timer2Text.Name = "timer2Text";
          this.timer2Text.Size = new System.Drawing.Size(100, 20);
          this.timer2Text.TabIndex = 1;
          this.timer2Text.Text = "5";
          // 
          // startStopButton
          // 
          this.startStopButton.Location = new System.Drawing.Point(12, 39);
          this.startStopButton.Name = "startStopButton";
          this.startStopButton.Size = new System.Drawing.Size(58, 23);
          this.startStopButton.TabIndex = 2;
          this.startStopButton.Text = "START";
          this.startStopButton.UseVisualStyleBackColor = true;
          this.startStopButton.Click += new System.EventHandler(this.startTopButton_Click);
          // 
          // resetButton
          // 
          this.resetButton.Location = new System.Drawing.Point(287, 39);
          this.resetButton.Name = "resetButton";
          this.resetButton.Size = new System.Drawing.Size(58, 23);
          this.resetButton.TabIndex = 3;
          this.resetButton.Text = "RESET";
          this.resetButton.UseVisualStyleBackColor = true;
          this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
          // 
          // whichTimerButton
          // 
          this.whichTimerButton.Location = new System.Drawing.Point(143, 39);
          this.whichTimerButton.Name = "whichTimerButton";
          this.whichTimerButton.Size = new System.Drawing.Size(75, 23);
          this.whichTimerButton.TabIndex = 4;
          this.whichTimerButton.Text = "<--";
          this.whichTimerButton.UseVisualStyleBackColor = true;
          this.whichTimerButton.Click += new System.EventHandler(this.whichTimerButton_Click);
          // 
          // timer1Label
          // 
          this.timer1Label.AutoSize = true;
          this.timer1Label.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.timer1Label.ForeColor = System.Drawing.Color.Red;
          this.timer1Label.Location = new System.Drawing.Point(3, 65);
          this.timer1Label.Name = "timer1Label";
          this.timer1Label.Size = new System.Drawing.Size(167, 50);
          this.timer1Label.TabIndex = 5;
          this.timer1Label.Text = "00:00";
          this.timer1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // timer2Label
          // 
          this.timer2Label.AutoSize = true;
          this.timer2Label.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.timer2Label.ForeColor = System.Drawing.Color.Green;
          this.timer2Label.Location = new System.Drawing.Point(178, 65);
          this.timer2Label.Name = "timer2Label";
          this.timer2Label.Size = new System.Drawing.Size(167, 50);
          this.timer2Label.TabIndex = 6;
          this.timer2Label.Text = "00:00";
          this.timer2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // timer
          // 
          this.timer.Interval = 1000;
          this.timer.Tick += new System.EventHandler(this.timer_Tick);
          // 
          // taskGrid
          // 
          this.taskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.taskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskColumn});
          this.taskGrid.Location = new System.Drawing.Point(12, 118);
          this.taskGrid.Name = "taskGrid";
          this.taskGrid.Size = new System.Drawing.Size(333, 279);
          this.taskGrid.TabIndex = 7;
          // 
          // TaskColumn
          // 
          this.TaskColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.TaskColumn.HeaderText = "Task";
          this.TaskColumn.Name = "TaskColumn";
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(357, 409);
          this.Controls.Add(this.taskGrid);
          this.Controls.Add(this.timer2Label);
          this.Controls.Add(this.timer1Label);
          this.Controls.Add(this.whichTimerButton);
          this.Controls.Add(this.resetButton);
          this.Controls.Add(this.startStopButton);
          this.Controls.Add(this.timer2Text);
          this.Controls.Add(this.timer1Text);
          this.Name = "Form1";
          this.Text = "Two Timer";
          ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timer1Text;
        private System.Windows.Forms.TextBox timer2Text;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button whichTimerButton;
        private System.Windows.Forms.Label timer1Label;
        private System.Windows.Forms.Label timer2Label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView taskGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskColumn;
    }
}

