using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace GPT_B2
{
  public class Form1 : Form
  {
    private Button button1;

    private Label label1;

    private Label label2;

    private Label label3;

    private Label label4;

    private TextBox txtbox1;

    private TextBox txtbox2;

    private TextBox txtbox3;

    private TextBox txtbox4;

    private TextBox txtbox5;

    public Form1()
    {

      //Form1
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 500);
      this.Name = "Giải Phương Trình Bậc 2";
      this.Text = "Giải Phương Trình Bậc 2";
      this.ResumeLayout(false);
      this.PerformLayout();

      //Button 1
      button1 = new Button();
      button1.Size = new Size(60, 40); //(w,h)
      button1.Location = new Point(60, 280); //(x,y)
      button1.Text = "Đáp số";
      button1.TabIndex = 4;
      this.Controls.Add(button1);
      button1.Click += new EventHandler(button1_Click);

      //Label 1
      label1 = new Label();
      label1.UseMnemonic = true;
      label1.Text = "Hệ số a:";
      label1.Font = new Font("Arial", 15);
      label1.TabStop = false;
      label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);
      label1.Location = new Point(20, 100);
      this.Controls.Add(label1);

      //Label 2
      label2 = new Label();
      label2.UseMnemonic = true;
      label2.Text = "Hệ số b:";
      label2.Font = new Font("Arial", 15);
      label2.TabStop = false;
      label2.Size = new Size(label2.PreferredWidth, label2.PreferredHeight);
      label2.Location = new Point(20, 145);
      this.Controls.Add(label2);

      //Label 3
      label3 = new Label();
      label3.UseMnemonic = true;
      label3.Text = "Hệ số c:";
      label3.Font = new Font("Arial", 15);
      label3.TabStop = false;
      label3.Size = new Size(label3.PreferredWidth, label3.PreferredHeight);
      label3.Location = new Point(20, 190);
      this.Controls.Add(label3);

      //Label 4
      label4 = new Label();
      label4.UseMnemonic = true;
      label4.Text = "Kết quả:";
      label4.TabStop = false;
      label4.Font = new Font("Arial", 15);
      label4.Size = new Size(label4.PreferredWidth, label4.PreferredHeight);
      label4.Location = new Point(20, 235);
      this.Controls.Add(label4);

      //TextBox 1
      txtbox1 = new TextBox();
      txtbox1.AcceptsReturn = true;
      txtbox1.AcceptsTab = true;
      txtbox1.Multiline = true;
      txtbox1.BackColor = Color.FromName("White");
      txtbox1.Location = new Point(100, 100);
      txtbox1.Height = 30;
      txtbox1.Width = 100;
      txtbox1.Font = new Font("Arial", 13);
      txtbox1.Tag = "Hệ số a";
      txtbox1.Text = (string)txtbox1.Tag;
      txtbox1.TabIndex = 0;
      txtbox1.AcceptsReturn = false;
      txtbox1.Multiline = false;
      txtbox1.AcceptsTab = false;
      txtbox1.ForeColor = Color.FromName("Gray");
      txtbox1.Click += new EventHandler(OnClickTxtBox);
      txtbox1.TextChanged += new EventHandler(OnTextChanged);
      this.Controls.Add(txtbox1);

      //TextBox 2
      txtbox2 = new TextBox();
      txtbox2.AcceptsReturn = true;
      txtbox2.AcceptsTab = true;
      txtbox2.Multiline = true;
      txtbox2.BackColor = Color.FromName("White");
      txtbox2.Location = new Point(100, 145);
      txtbox2.Height = 30;
      txtbox2.Width = 100;
      txtbox2.Font = new Font("Arial", 13);
      txtbox2.Tag = "Hệ số b";
      txtbox2.Text = (string)txtbox2.Tag;
      txtbox2.TabIndex = 1;
      txtbox2.ForeColor = Color.FromName("Gray");
      txtbox2.AcceptsReturn = false;
      txtbox2.Multiline = false;
      txtbox2.AcceptsTab = false;
      txtbox2.Click += new EventHandler(OnClickTxtBox);
      txtbox2.TextChanged += new EventHandler(OnTextChanged);
      this.Controls.Add(txtbox2);

      //TextBox 3
      txtbox3 = new TextBox();
      txtbox3.AcceptsReturn = true;
      txtbox3.AcceptsTab = true;
      txtbox3.Multiline = true;
      txtbox3.BackColor = Color.FromName("White");
      txtbox3.Location = new Point(100, 190);
      txtbox3.Height = 28;
      txtbox3.Width = 100;
      txtbox3.Font = new Font("Arial", 13);
      txtbox3.Tag = "Hệ số c";
      txtbox3.Text = (string)txtbox3.Tag;
      txtbox3.TabIndex = 2;
      txtbox3.AcceptsReturn = false;
      txtbox3.Multiline = false;
      txtbox3.AcceptsTab = false;
      txtbox3.ForeColor = Color.FromName("Gray");
      txtbox3.Click += new EventHandler(OnClickTxtBox);
      txtbox3.TextChanged += new EventHandler(OnTextChanged);
      this.Controls.Add(txtbox3);

      //TextBox 4
      txtbox4 = new TextBox();
      txtbox4.AcceptsReturn = true;
      txtbox4.AcceptsTab = true;
      txtbox4.Multiline = true;
      txtbox4.BackColor = Color.FromName("Gray");
      txtbox4.Location = new Point(100, 235);
      txtbox4.Height = 28;
      txtbox4.Width = 100;
      txtbox4.Font = new Font("Arial", 13);
      txtbox4.Tag = "X1";
      txtbox4.Text = (string)txtbox4.Tag;
      txtbox4.TabStop = false;
      txtbox4.AcceptsReturn = false;
      txtbox4.Multiline = false;
      txtbox4.Enabled = false;
      txtbox4.AcceptsTab = false;
      txtbox4.Click += new EventHandler(OnClickTxtBox);
      txtbox4.TextChanged += new EventHandler(OnTextChanged);
      this.Controls.Add(txtbox4);

      //TextBox 5
      txtbox5 = new TextBox();
      txtbox5.AcceptsReturn = true;
      txtbox5.AcceptsTab = true;
      txtbox5.BackColor = Color.FromName("Gray");
      txtbox5.Multiline = true;
      txtbox5.Location = new Point(220, 235);
      txtbox5.Height = 28;
      txtbox5.Width = 100;
      txtbox5.Font = new Font("Arial", 13);
      txtbox5.Tag = "X2";
      txtbox5.Text = (string)txtbox5.Tag;
      txtbox5.TabStop = false;
      txtbox5.AcceptsReturn = false;
      txtbox5.Multiline = false;
      txtbox5.Enabled = false;
      txtbox5.AcceptsTab = false;
      txtbox5.Click += new EventHandler(OnClickTxtBox);
      txtbox5.TextChanged += new EventHandler(OnTextChanged);
      this.Controls.Add(txtbox5);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double a,b,c;
      bool resultA,resultB,resultC;
      resultA = double.TryParse(txtbox1.Text, out a);
      resultB = double.TryParse(txtbox2.Text, out b);
      resultC = double.TryParse(txtbox3.Text, out c);
      if(!resultA)
      {
        MessageBox.Show("Nhap lai he so a");
        txtbox1.Select();
      }      
      else if(!resultB)
      {
        MessageBox.Show("Nhap lai he so b");
        txtbox2.Select();
      }
      else if(!resultC)
      {
        MessageBox.Show("Nhap lai he so c");
        txtbox3.Select();
      }else
      {
        double delta = ((b*b)-(4*a*c));
        double result;
        string temp;
        if(delta < 0)
        {
          txtbox5.Text = "Vô nghiệm";
          txtbox4.Text = "Vô nghiệm";
        } else if (delta == 0)
        {
          result = (-b/2*a);
          temp = Convert.ToString(result);
          txtbox4.Text = temp;
          txtbox5.Text = temp;
        } else if (delta > 0)
        {
          result = (-b + Math.Sqrt(delta))/(2*a);
          temp = Convert.ToString(result);
          txtbox4.Text = temp;
          result = (-b - Math.Sqrt(delta))/(2*a);
          temp = Convert.ToString(result);
          txtbox5.Text = temp;
        }
      }
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
      var textbox = (TextBox)sender;
      // if (string.IsNullOrEmpty(textbox.Text))
      // 
      //   textbox.Text = (string)textbox.Tag;
      // }
      textbox.KeyDown += new KeyEventHandler(OnEnterPressed);
      textbox.Text = textbox.Text;
      textbox.ForeColor = Color.FromName("Black");
    }

    private void OnClickTxtBox(object sender, EventArgs e)
    {
      var textbox = (TextBox)sender;
      textbox.SelectAll();
      
    }

    private void OnEnterPressed(object sender, KeyEventArgs e)
    {
      var textbox = (TextBox)sender;
      if( (e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return) )
      {
        this.SelectNextControl( (Control)sender, true, true, true, true );
        if (string.IsNullOrEmpty(textbox.Text))
        {          
          textbox.Text = (string)textbox.Tag;
          textbox.ForeColor = Color.FromName("Gray");
        }
      }
    }

    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }
  }
}
