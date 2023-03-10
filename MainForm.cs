using System.Runtime.InteropServices;

namespace ShutdownTimer;

public partial class Main : Form {
	private readonly TextBox textMinutes;
	private readonly Button buttonStart;
	private readonly ShutdownTimer shutdownTimer;
	public Main() {
		InitializeComponent();
		textMinutes = (TextBox)Controls.Find("TextMinutes", false)[0];
		buttonStart = (Button)Controls.Find("ButtonStart", false)[0];
		shutdownTimer = new();
		shutdownTimer.StateChanged += ShutdownTimer_StateChanged;
		ButtonStart_Click(this, EventArgs.Empty);
	}

	private void ShutdownTimer_StateChanged(bool active) {
		WriteState(active);
	}

	private void WriteState(bool active) {
		if (buttonStart.InvokeRequired) {
			buttonStart.Invoke(WriteState, active);
			return;
		}

		textMinutes.Enabled = !active;

		if (active) {
			buttonStart.BackColor = Color.DarkRed;
			buttonStart.Text = "Stop";
			return;
		}

		buttonStart.BackColor = Color.DarkGreen;
		buttonStart.Text = "Start";
	}

	private void ButtonStart_Click(object sender, EventArgs e) {
		if (!int.TryParse(textMinutes.Text, out int minutes)) {
			textMinutes.Text = "30";
			return;
		}

		if (shutdownTimer.Active) {
			shutdownTimer.Stop();
			return;
		}

		shutdownTimer.Start(minutes);
	}

	#region DarkForm
	[LibraryImport("DwmApi")]
	private static partial int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

	protected override void OnHandleCreated(EventArgs e) {
		if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0) {
			_ = DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
		}
	}
	#endregion
}
