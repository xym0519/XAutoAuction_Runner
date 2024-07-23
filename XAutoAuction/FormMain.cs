using System.Diagnostics;
using System.Runtime.InteropServices;

namespace XAutoAuction;

public partial class FormMain : Form
{
    // Windows API 函数声明
    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    // Windows API 函数声明
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    // 全局热键的唯一标识符
    private const int HOTKEY_ID = 1;

    // Windows 消息常量
    private const int WM_HOTKEY = 0x0312;

    // 全局热键的修饰键和键码
    private const uint MOD_CONTROL = 0x0002; // Ctrl 键
    private const uint MOD_SHIFT = 0x0004; // Shift 键
    private const uint VK_R = 0x52; // R 键的虚拟键码

    // 注册全局热键的方法
    private void RegisterGlobalHotKey()
    {
        // 将修饰键和键码转换为 Windows API 的参数
        if (!RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_SHIFT, VK_R))
        {
            MessageBox.Show("Failed to register hotkey.");
        }
    }

    // 取消注册全局热键的方法
    private void UnregisterGlobalHotKey()
    {
        // 取消注册全局热键
        if (!UnregisterHotKey(this.Handle, HOTKEY_ID))
        {
            MessageBox.Show("Failed to unregister hotkey.");
        }
    }

    // 处理窗体消息，捕获全局热键事件
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        // 检查是否接收到了热键消息
        if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
        {
            ToggleStart();
        }
    }

    private bool isRunning = false;

    public FormMain()
    {
        InitializeComponent();
        MaximizeBox = false; // 隐藏最大化按钮
        MinimizeBox = false; // 隐藏最大化按钮
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        RegisterGlobalHotKey();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        UnregisterGlobalHotKey();
        StopHotkeyThread();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        ToggleStart();
    }

    private CancellationTokenSource? cancellationTokenSource = null;
    private ManualResetEventSlim resetEvent = new ManualResetEventSlim(true);
    private Thread hotkeyThread;

    private void ToggleStart()
    {
        if (cancellationTokenSource == null)
        {
            // 启动新线程
            cancellationTokenSource = new CancellationTokenSource();
            resetEvent.Reset(); // 重置 ManualResetEventSlim

            hotkeyThread = new Thread(() =>
            {
                try
                {
                    // 隐藏窗口
                    HideForm();

                    while (!cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        // 获取名为 "LYWOW" 的进程并发送热键
                        Process[] processes = Process.GetProcessesByName("WowClassic");
                        foreach (Process process in processes)
                        {
                            // 检查是否已请求取消操作
                            if (cancellationTokenSource.Token.IsCancellationRequested)
                            {
                                return;
                            }

                            IntPtr mainWindowHandle = process.MainWindowHandle;
                            if (mainWindowHandle != IntPtr.Zero)
                            {
                                SetForegroundWindow(mainWindowHandle);
                                Thread.Sleep(100);
                                SendKeys.SendWait("\\");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    // 捕获 OperationCanceledException，表示任务被取消
                }
                finally
                {
                    // 显示窗口
                    ShowForm();

                    resetEvent.Set(); // 设置 ManualResetEventSlim，表示线程已结束
                    cancellationTokenSource.Dispose();
                    cancellationTokenSource = null;
                }
            });

            hotkeyThread.Start();
        }
        else
        {
            // 请求取消当前线程
            cancellationTokenSource.Cancel();

            // 等待线程结束并重新置空
            resetEvent.Wait();
        }
    }

    // 安全地隐藏窗口
    private void HideForm()
    {
        if (this.InvokeRequired)
        {
            this.BeginInvoke((Action)(() => { this.Visible = false; }));
        }
        else
        {
            this.Visible = false;
        }
    }

    // 安全地显示窗口
    private void ShowForm()
    {
        if (this.InvokeRequired)
        {
            this.BeginInvoke((Action)(() => { this.Visible = true; }));
        }
        else
        {
            this.Visible = true;
        }
    }

    // 停止热键处理线程
    private void StopHotkeyThread()
    {
        if (cancellationTokenSource != null)
        {
            cancellationTokenSource.Cancel();
            resetEvent.Wait();
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;
        }
    }
}