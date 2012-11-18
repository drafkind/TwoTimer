namespace TwoTimer {
  partial class ResponseDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.messageLabel = new System.Windows.Forms.Label();
      this.problemLabel = new System.Windows.Forms.Label();
      this.okButton = new System.Windows.Forms.Button();
      this.problemTextBox = new System.Windows.Forms.TextBox();
      this.doneButton = new System.Windows.Forms.Button();
      this.taskLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // messageLabel
      // 
      this.messageLabel.AutoSize = true;
      this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.messageLabel.Location = new System.Drawing.Point(12, 9);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(74, 24);
      this.messageLabel.TabIndex = 0;
      this.messageLabel.Text = "Timer 1";
      // 
      // problemLabel
      // 
      this.problemLabel.AutoSize = true;
      this.problemLabel.Location = new System.Drawing.Point(12, 47);
      this.problemLabel.Name = "problemLabel";
      this.problemLabel.Size = new System.Drawing.Size(67, 13);
      this.problemLabel.TabIndex = 1;
      this.problemLabel.Text = "(1 + 1) + 1 = ";
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(131, 94);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 2;
      this.okButton.Text = "NOT DONE";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // problemTextBox
      // 
      this.problemTextBox.Location = new System.Drawing.Point(106, 44);
      this.problemTextBox.Name = "problemTextBox";
      this.problemTextBox.Size = new System.Drawing.Size(100, 20);
      this.problemTextBox.TabIndex = 3;
      // 
      // doneButton
      // 
      this.doneButton.Location = new System.Drawing.Point(15, 94);
      this.doneButton.Name = "doneButton";
      this.doneButton.Size = new System.Drawing.Size(75, 23);
      this.doneButton.TabIndex = 4;
      this.doneButton.Text = "DONE";
      this.doneButton.UseVisualStyleBackColor = true;
      this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
      // 
      // taskLabel
      // 
      this.taskLabel.AutoSize = true;
      this.taskLabel.Location = new System.Drawing.Point(12, 75);
      this.taskLabel.Name = "taskLabel";
      this.taskLabel.Size = new System.Drawing.Size(36, 13);
      this.taskLabel.TabIndex = 5;
      this.taskLabel.Text = "a task";
      // 
      // ResponseDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(218, 129);
      this.Controls.Add(this.taskLabel);
      this.Controls.Add(this.doneButton);
      this.Controls.Add(this.problemTextBox);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.problemLabel);
      this.Controls.Add(this.messageLabel);
      this.Name = "ResponseDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Time out!";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label messageLabel;
    private System.Windows.Forms.Label problemLabel;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.TextBox problemTextBox;
    private System.Windows.Forms.Button doneButton;
    private System.Windows.Forms.Label taskLabel;
  }
}