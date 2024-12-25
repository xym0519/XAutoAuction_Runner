using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace XAutoAuction;

public partial class FormMain : Form
{
    // Windows API 函数声明
    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


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
    private const uint VK_E = 0x45; // E 键的虚拟键码

    // 消息常量
    const uint WM_MOUSEMOVE = 0x0200; // 鼠标移动
    const uint WM_RBUTTONDOWN = 0x0204; // 右键按下
    const uint WM_RBUTTONUP = 0x0205; // 右键释放

    // 定义鼠标坐标结构
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }

    // 注册全局热键的方法
    private void RegisterGlobalHotKey()
    {
        // 将修饰键和键码转换为 Windows API 的参数
        if (!RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_SHIFT, VK_E))
        {
            MessageBox.Show(@"Failed to register hotkey.");
        }
    }

    // 取消注册全局热键的方法
    private void UnregisterGlobalHotKey()
    {
        // 取消注册全局热键
        if (!UnregisterHotKey(this.Handle, HOTKEY_ID))
        {
            MessageBox.Show(@"Failed to unregister hotkey.");
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

    public FormMain()
    {
        InitializeComponent();
        MaximizeBox = false; // 隐藏最大化按钮
        MinimizeBox = false; // 隐藏最小化按钮
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

    private string? _fileVersion = "";

    private void FormMain_Load(object sender, EventArgs e)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var info = FileVersionInfo.GetVersionInfo(assembly.Location);
        _fileVersion = info.FileVersion;
        this.Text = @"D" + _fileVersion;
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        ToggleStart();
    }

    private void SendMouseMove(IntPtr hwnd, int x, int y)
    {
        // 将鼠标移动消息发送到目标窗口
        POINT pt = new POINT { x = x, y = y };
        IntPtr lParam = (IntPtr)((y << 16) | (x & 0xFFFF)); // 转换为 lParam 格式
        SendMessage(hwnd, WM_MOUSEMOVE, IntPtr.Zero, lParam);
    }

    // 发送鼠标右键按下消息
    static void SendMouseRightButtonDown(IntPtr hwnd, int x, int y)
    {
        // 将鼠标右键按下消息发送到目标窗口
        POINT pt = new POINT { x = x, y = y };
        IntPtr lParam = (IntPtr)((y << 16) | (x & 0xFFFF)); // 转换为 lParam 格式
        SendMessage(hwnd, WM_RBUTTONDOWN, IntPtr.Zero, lParam);
    }

    // 发送鼠标右键释放消息
    static void SendMouseRightButtonUp(IntPtr hwnd, int x, int y)
    {
        // 将鼠标右键释放消息发送到目标窗口
        POINT pt = new POINT { x = x, y = y };
        IntPtr lParam = (IntPtr)((y << 16) | (x & 0xFFFF)); // 转换为 lParam 格式
        SendMessage(hwnd, WM_RBUTTONUP, IntPtr.Zero, lParam);
    }

    private CancellationTokenSource? _cancellationTokenSource;
    private readonly ManualResetEventSlim _resetEvent = new(true);

    private Thread? _hotkeyThread;

    // private int round = 0;
    private long _startTime;
    private long _last6Time;
    private long _autoStopTime = 7200;

    private void mode1(IntPtr mainWindowHandle)
    {
        var curTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
        var random = new Random();

        var key = random.Next(1, 6).ToString();
        SendKeys.SendWait(key);
        Thread.Sleep(random.Next(300, 500));

        if (!checkBox.Checked) return;
        if (curTime - _last6Time <= 1) return;
        SendKeys.SendWait("6");
        Thread.Sleep(random.Next(50, 100));
        _last6Time = curTime;
    }

    private int a = 0;
    private void mode2(IntPtr mainWindowHandle)
    {
        var random = new Random();

        var x1 = int.Parse(textBox11.Text);
        var y1 = int.Parse(textBox12.Text);
        var t1 = int.Parse(textBox13.Text);

        var x2 = int.Parse(textBox21.Text);
        var y2 = int.Parse(textBox22.Text);
        var t2 = int.Parse(textBox23.Text);

        // t1 = 3;
        // t2 = 3;
        // x1 = 1021;
        // y1 = 518;
        // x2 = 900;
        // y2 = 475;
        SendMouseMove(mainWindowHandle, x1, y1);
        Thread.Sleep(50);
        SendMouseRightButtonDown(mainWindowHandle, x1, y1);
        SendMouseRightButtonUp(mainWindowHandle, x1, y1);
        Thread.Sleep(t1 * 1000 + random.Next(300, 500));

        SendMouseMove(mainWindowHandle, x2, y2);
        Thread.Sleep(50);
        SendMouseRightButtonDown(mainWindowHandle, x2, y2);
        SendMouseRightButtonUp(mainWindowHandle, x2, y2);
        Thread.Sleep(t2 * 1000 + random.Next(150, 350));
    }

    private void ToggleStart()
    {
        _autoStopTime = int.Parse(textBox.Text) * 60;
        if (_cancellationTokenSource == null)
        {
            // 启动新线程
            _cancellationTokenSource = new CancellationTokenSource();
            _resetEvent.Reset(); // 重置 ManualResetEventSlim

            _hotkeyThread = new Thread(() =>
            {
                try
                {
                    // 隐藏窗口
                    HideForm();

                    while (!_cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        var curTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
                        if (curTime - _startTime >= _autoStopTime)
                        {
                            // 请求取消当前线程
                            _cancellationTokenSource.Cancel();

                            break;
                        }

                        notifyIcon.Text = @"TimeLeft: " + (_autoStopTime - (curTime - _startTime));
                        this.Text = @"Baidu " + (_autoStopTime - (curTime - _startTime));

                        // 获取名为 "LYWOW" 的进程并发送热键
                        var processes = Process.GetProcessesByName("WowClassic");
                        // var processes = Process.GetProcessesByName("Chrome");
                        foreach (var process in processes)
                        {
                            // 检查是否已请求取消操作
                            if (_cancellationTokenSource.Token.IsCancellationRequested)
                            {
                                return;
                            }

                            var mainWindowHandle = process.MainWindowHandle;
                            if (mainWindowHandle == IntPtr.Zero) continue;
                            SetForegroundWindow(mainWindowHandle);
                            var random = new Random();

                            Thread.Sleep(random.Next(90, 110));
                            if (radioButton1.Checked)
                            {
                                mode1(mainWindowHandle);
                            }
                            else
                            {
                                mode2(mainWindowHandle);
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

                    _resetEvent.Set(); // 设置 ManualResetEventSlim，表示线程已结束
                    _cancellationTokenSource.Dispose();
                    _cancellationTokenSource = null;
                }
            });

            // 获取当前 UTC 时间
            _startTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            _hotkeyThread.Start();
            this.buttonStart.Text = @"Stop";
        }
        else
        {
            // 请求取消当前线程
            _cancellationTokenSource.Cancel();

            // 等待线程结束并重新置空
            _resetEvent.Wait();

            this.buttonStart.Text = @"Comp";
            this.notifyIcon.Text = @"BD";
            this.Text = @"D" + _fileVersion;
        }
    }

    // 安全地隐藏窗口
    private void HideForm()
    {
        if (this.InvokeRequired)
        {
            this.BeginInvoke(() => { this.Visible = false; });
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
            this.BeginInvoke(() => { this.Visible = true; });
        }
        else
        {
            this.Visible = true;
        }
    }

    // 停止热键处理线程
    private void StopHotkeyThread()
    {
        if (_cancellationTokenSource == null) return;
        _cancellationTokenSource.Cancel();
        _resetEvent.Wait();
        _cancellationTokenSource.Dispose();
        _cancellationTokenSource = null;
    }

    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (this.Visible)
        {
            HideForm();
        }
        else
        {
            ShowForm();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox.Text = @"15";
        ToggleStart();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox.Text = @"30";
        ToggleStart();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        textBox.Text = @"60";
        ToggleStart();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        textBox.Text = @"120";
        ToggleStart();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        textBox.Text = @"240";
        ToggleStart();
    }
}