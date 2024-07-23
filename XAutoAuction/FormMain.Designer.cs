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
        buttonStart = new Button();
        SuspendLayout();
        // 
        // buttonStart
        // 
        buttonStart.Location = new Point(12, 12);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(174, 45);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(198, 69);
        Controls.Add(buttonStart);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = false;
        Name = "FormMain";
        ShowIcon = false;
        Text = "XAA";
        TopMost = true;
        Load += FormMain_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button buttonStart;
}