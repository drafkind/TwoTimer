using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwoTimer {
  public enum WhichTimer {
    Timer1,
    Timer2
  }

  public partial class Form1 : Form {
    public WhichTimer whichTimer;
    private int seconds1;
    private int seconds2;

    private Random random;
    private ResponseDialog rdlg;

    public Form1() {
      InitializeComponent();
      whichTimer = WhichTimer.Timer1;

      readSeconds(WhichTimer.Timer1);
      readSeconds(WhichTimer.Timer2);
      showSeconds(WhichTimer.Timer1);
      showSeconds(WhichTimer.Timer2);

      rdlg = new ResponseDialog();
      random = new Random();
    }

    private int getSeconds(WhichTimer w) {
      string source = timer1Text.Text;
      if (w == WhichTimer.Timer2) {
        source = timer2Text.Text;
      }
      try {
        return Int32.Parse(source) * 60;
      } catch (Exception ex) {
        return 0;
      }
    }

    private void readSeconds(WhichTimer w) {
      if (w == WhichTimer.Timer1) {
        seconds1 = getSeconds(w);
      } else {
        seconds2 = getSeconds(w);
      }
    }

    private void showSeconds(WhichTimer w) {
      if (w == WhichTimer.Timer1) {
        string t = string.Format("{0:00}:{1:00}", seconds1 / 60, seconds1 % 60);
        timer1Label.Text = t;
        this.Text = "TwoTimer - " + t;
      } else {
        string t = string.Format("{0:00}:{1:00}", seconds2 / 60, seconds2 % 60);
        timer2Label.Text = t;
        this.Text = "TwoTimer - " + t;
      }
    }

    private void startTopButton_Click(object sender, EventArgs e) {
      if (timer.Enabled) {
        timer.Stop();
        startStopButton.Text = "START";        
      } else {
        timer.Start();
        startStopButton.Text = "PAUSE";
      }
    }

    private void resetButton_Click(object sender, EventArgs e) {
      if (timer.Enabled) {
        timer.Stop();
        startStopButton.Text = "START";        
      }

      readSeconds(WhichTimer.Timer1);
      readSeconds(WhichTimer.Timer2);
      showSeconds(WhichTimer.Timer1);
      showSeconds(WhichTimer.Timer2);
    }

    private void whichTimerButton_Click(object sender, EventArgs e) {
      if (whichTimer == WhichTimer.Timer1) {
        whichTimer = WhichTimer.Timer2;
        whichTimerButton.Text = "-->";
      } else {
        whichTimer = WhichTimer.Timer1;
        whichTimerButton.Text = "<--";
      }
    }

    private void DoTimeoutDialog(string message) {
      string problemText = "";
      int answer = 0;

      int n1 = random.Next(0, 10) + 1;
      int n2 = random.Next(0, 10) + 1;
      int n3 = random.Next(0, 10) + 1;

      switch (random.Next(0, 3)) {
        case 0: {
            problemText = "(" + n1 + " + " + n2 + ")";
            answer = n1 + n2;
          } break;
        case 1: {
            problemText = "(" + n1 + " - " + n2 + ")";
            answer = n1 - n2;
          }
          break;
        case 2: {
            problemText = "(" + n1 + " * " + n2 + ")";
            answer = n1 * n2;
          }
          break;
      }

      switch (random.Next(0, 3)) {
        case 0: {
            problemText += " + " + n3 + " = ";
            answer += n3;
          }
          break;
        case 1: {
            problemText += " - " + n3 + " = ";
            answer -= n3;
          }
          break;
        case 2: {
            problemText += " * " + n3 + " = ";
            answer *= n3;
          }
          break;
      }

      rdlg.Setup(
        message,
        taskGrid.Rows.Count == 0 ?
          ""
          :
          (string)taskGrid.Rows[0].Cells[0].Value,
        problemText,
        answer,
        delegate() {
          if (taskGrid.Rows.Count > 0) {
            taskGrid.Rows.RemoveAt(0);
          }
        });

      if (!rdlg.Visible) {
        rdlg.ShowDialog();
      }
    }

    private void timer_Tick(object sender, EventArgs e) {
      if (whichTimer == WhichTimer.Timer1) {
        seconds1 -= 1;
        if (seconds1 <= 0) {
          readSeconds(WhichTimer.Timer1);
          whichTimer = WhichTimer.Timer2;
          whichTimerButton.Text = "-->";
          this.WindowState = FormWindowState.Normal;
          //MessageBox.Show("Timer1");
          DoTimeoutDialog("Timer 1");
        }        
        showSeconds(WhichTimer.Timer1);
      } else {
        seconds2 -= 1;
        if (seconds2 <= 0) {
          readSeconds(WhichTimer.Timer2);
          whichTimer = WhichTimer.Timer1;
          whichTimerButton.Text = "<--";
          this.WindowState = FormWindowState.Normal;
          //MessageBox.Show("Timer2");
          DoTimeoutDialog("Timer 2");
        }
        showSeconds(WhichTimer.Timer2);
      }
    }
  }
}