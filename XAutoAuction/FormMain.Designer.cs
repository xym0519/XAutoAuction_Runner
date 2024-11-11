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
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(8, 7);
        buttonStart.Margin = new Padding(2);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(112, 27);
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
        checkBox.Location = new Point(12, 39);
        checkBox.Name = "checkBox";
        checkBox.Size = new Size(59, 19);
        checkBox.TabIndex = 1;
        checkBox.Text = "Check";
        checkBox.UseVisualStyleBackColor = true;
        checkBox.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(128, 64);
        Controls.Add(checkBox);
        Controls.Add(buttonStart);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(2);
        MinimizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        Text = "Baidu";
        TopMost = true;
        Load += FormMain_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonStart;
    private NotifyIcon notifyIcon;
    private CheckBox checkBox;
}