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
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(8, 7);
        buttonStart.Margin = new Padding(2);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(122, 27);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Compose";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // notifyIcon
        // 
        notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
        notifyIcon.Text = "DittoPro";
        notifyIcon.Visible = true;
        notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(139, 41);
        Controls.Add(buttonStart);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(2);
        MinimizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        Text = "DittoPro";
        TopMost = true;
        Load += FormMain_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button buttonStart;
    private NotifyIcon notifyIcon;
}