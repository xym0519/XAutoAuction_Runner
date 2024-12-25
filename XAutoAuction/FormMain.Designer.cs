namespace XAutoAuction;

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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        buttonStart = new Button();
        notifyIcon = new NotifyIcon(components);
        checkBox = new CheckBox();
        textBox = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        textBox11 = new TextBox();
        textBox12 = new TextBox();
        textBox13 = new TextBox();
        textBox21 = new TextBox();
        textBox22 = new TextBox();
        textBox23 = new TextBox();
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(16, 12);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(240, 38);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Comp";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // notifyIcon
        // 
        notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
        notifyIcon.Text = "Baidu";
        notifyIcon.Visible = true;
        notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
        // 
        // checkBox
        // 
        checkBox.AutoSize = true;
        checkBox.Location = new Point(91, 117);
        checkBox.Margin = new Padding(4, 5, 4, 5);
        checkBox.Name = "checkBox";
        checkBox.Size = new Size(85, 29);
        checkBox.TabIndex = 1;
        checkBox.Text = "Check";
        checkBox.UseVisualStyleBackColor = true;
        // 
        // textBox
        // 
        textBox.Location = new Point(261, 12);
        textBox.Margin = new Padding(4, 5, 4, 5);
        textBox.Name = "textBox";
        textBox.Size = new Size(54, 31);
        textBox.TabIndex = 2;
        textBox.Text = "120";
        // 
        // button1
        // 
        button1.Location = new Point(16, 63);
        button1.Name = "button1";
        button1.Size = new Size(56, 38);
        button1.TabIndex = 3;
        button1.Text = "15m";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(77, 63);
        button2.Name = "button2";
        button2.Size = new Size(56, 38);
        button2.TabIndex = 4;
        button2.Text = "30m";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(139, 63);
        button3.Name = "button3";
        button3.Size = new Size(56, 38);
        button3.TabIndex = 5;
        button3.Text = "1h";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(200, 63);
        button4.Name = "button4";
        button4.Size = new Size(56, 38);
        button4.TabIndex = 6;
        button4.Text = "2h";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(261, 63);
        button5.Name = "button5";
        button5.Size = new Size(56, 38);
        button5.TabIndex = 7;
        button5.Text = "4h";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Checked = true;
        radioButton1.Location = new Point(16, 117);
        radioButton1.Margin = new Padding(4, 5, 4, 5);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(63, 29);
        radioButton1.TabIndex = 8;
        radioButton1.TabStop = true;
        radioButton1.Text = "m1";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(16, 158);
        radioButton2.Margin = new Padding(4, 5, 4, 5);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(63, 29);
        radioButton2.TabIndex = 9;
        radioButton2.Text = "m2";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // textBox11
        // 
        textBox11.Location = new Point(91, 157);
        textBox11.Margin = new Padding(4, 5, 4, 5);
        textBox11.Name = "textBox11";
        textBox11.Size = new Size(68, 31);
        textBox11.TabIndex = 10;
        textBox11.Text = "0";
        // 
        // textBox12
        // 
        textBox12.Location = new Point(170, 157);
        textBox12.Margin = new Padding(4, 5, 4, 5);
        textBox12.Name = "textBox12";
        textBox12.Size = new Size(68, 31);
        textBox12.TabIndex = 11;
        textBox12.Text = "0";
        // 
        // textBox13
        // 
        textBox13.Location = new Point(249, 157);
        textBox13.Margin = new Padding(4, 5, 4, 5);
        textBox13.Name = "textBox13";
        textBox13.Size = new Size(68, 31);
        textBox13.TabIndex = 12;
        textBox13.Text = "15";
        // 
        // textBox21
        // 
        textBox21.Location = new Point(91, 205);
        textBox21.Margin = new Padding(4, 5, 4, 5);
        textBox21.Name = "textBox21";
        textBox21.Size = new Size(68, 31);
        textBox21.TabIndex = 13;
        textBox21.Text = "0";
        // 
        // textBox22
        // 
        textBox22.Location = new Point(170, 205);
        textBox22.Margin = new Padding(4, 5, 4, 5);
        textBox22.Name = "textBox22";
        textBox22.Size = new Size(68, 31);
        textBox22.TabIndex = 14;
        textBox22.Text = "0";
        // 
        // textBox23
        // 
        textBox23.Location = new Point(249, 205);
        textBox23.Margin = new Padding(4, 5, 4, 5);
        textBox23.Name = "textBox23";
        textBox23.Size = new Size(68, 31);
        textBox23.TabIndex = 15;
        textBox23.Text = "10";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(330, 253);
        Controls.Add(textBox23);
        Controls.Add(textBox22);
        Controls.Add(textBox21);
        Controls.Add(textBox13);
        Controls.Add(textBox12);
        Controls.Add(textBox11);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox);
        Controls.Add(checkBox);
        Controls.Add(buttonStart);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        Text = "5";
        TopMost = true;
        Load += FormMain_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonStart;
    private NotifyIcon notifyIcon;
    private CheckBox checkBox;
    private TextBox textBox;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private TextBox textBox11;
    private TextBox textBox12;
    private TextBox textBox13;
    private TextBox textBox21;
    private TextBox textBox22;
    private TextBox textBox23;
}