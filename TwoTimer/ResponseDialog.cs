using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwoTimer {
  public partial class ResponseDialog : Form {

    private int answer;
    private int hue;

    public delegate void DoneDelegate();
    private DoneDelegate doneDelegate;

    public ResponseDialog() {
      InitializeComponent();

      Timer colorFader = new Timer();
      colorFader.Tick += new EventHandler(colorFader_Tick);
      colorFader.Interval = 1000;
      colorFader.Start();
    }

    private void colorFader_Tick(Object myObject, EventArgs myEventArgs) {
      hue += 10;

      float s = 0.9f;
      float v = 0.9f;

      int H = (hue / 60) % 6;
      float C = v * s;
      float X = C * (1 - Math.Abs(H % 2 - 1));
      float m = v - C;

      float r1 = 0;
      float g1 = 0;
      float b1 = 0;

      switch (H) {
        case 0: {
            r1 = C;
            g1 = X;
            b1 = 0;
          } break;
        case 1: {
            r1 = X;
            g1 = C;
            b1 = 0;
          } break;
        case 2: {
            r1 = 0;
            g1 = C;
            b1 = X;
          } break;
        case 3: {
            r1 = 0;
            g1 = X;
            b1 = C;
          } break;
        case 4: {
            r1 = X;
            g1 = 0;
            b1 = C;
          } break;
        case 5: {
            r1 = C;
            g1 = 0;
            b1 = X;
          } break;
      }

      float R = r1 + m;
      float G = g1 + m;
      float B = b1 + m;

      this.BackColor = Color.FromArgb((int)Math.Round(255 * R), (int)Math.Round(255 * G), (int)Math.Round(255 * B));

      //this.BackColor = Color.FromArgb(hue % 256, hue % 256, hue % 256);
    }

    public void Setup(string message, string taskMessage, string problem, int answer, DoneDelegate onDone) {
      this.messageLabel.Text = message;
      this.problemLabel.Text = problem;
      this.problemTextBox.Text = "";
      this.answer = answer;
      this.taskLabel.Text = taskMessage;
      this.doneDelegate = onDone;
    }

    private void okButton_Click(object sender, EventArgs e) {
      try {
        if (answer == Int32.Parse(problemTextBox.Text)) {
          this.Close();
        }
      } catch (Exception ex) {
      }
    }

    private void doneButton_Click(object sender, EventArgs e) {
      try {
        if (answer == Int32.Parse(problemTextBox.Text)) {
          this.Close();
          if (doneDelegate != null) {
            this.doneDelegate();
          }
        }
        // delete top thing in the datagrid and move everything else up one
      } catch (Exception ex) {
      }
    }
  }
}
