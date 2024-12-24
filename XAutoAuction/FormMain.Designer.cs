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
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(11, 7);
        buttonStart.Margin = new Padding(2);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(84, 23);
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
        checkBox.Location = new Point(166, 9);
        checkBox.Name = "checkBox";
        checkBox.Size = new Size(59, 19);
        checkBox.TabIndex = 1;
        checkBox.Text = "Check";
        checkBox.UseVisualStyleBackColor = true;
        checkBox.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // textBox
        // 
        textBox.Location = new Point(100, 7);
        textBox.Name = "textBox";
        textBox.Size = new Size(60, 23);
        textBox.TabIndex = 2;
        textBox.Text = "120";
        textBox.TextChanged += textBox_TextChanged;
        // 
        // button1
        // 
        button1.Location = new Point(11, 38);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(39, 23);
        button1.TabIndex = 3;
        button1.Text = "15m";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(54, 38);
        button2.Margin = new Padding(2);
        button2.Name = "button2";
        button2.Size = new Size(39, 23);
        button2.TabIndex = 4;
        button2.Text = "30m";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(97, 38);
        button3.Margin = new Padding(2);
        button3.Name = "button3";
        button3.Size = new Size(39, 23);
        button3.TabIndex = 5;
        button3.Text = "1h";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(140, 38);
        button4.Margin = new Padding(2);
        button4.Name = "button4";
        button4.Size = new Size(39, 23);
        button4.TabIndex = 6;
        button4.Text = "2h";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(183, 38);
        button5.Margin = new Padding(2);
        button5.Name = "button5";
        button5.Size = new Size(39, 23);
        button5.TabIndex = 7;
        button5.Text = "4h";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(231, 64);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox);
        Controls.Add(checkBox);
        Controls.Add(buttonStart);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(2);
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
}