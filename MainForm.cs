namespace ShutdownTimer;

public partial class Main : Form {
	private readonly Label labelStatus;
	private readonly ShutdownTimer shutdownTimer = new();
	public Main() {
		InitializeComponent();
		labelStatus = (Label)Controls.Find("LabelStatus", false)[0];
		shutdownTimer.StateChanged += ShutdownTimer_StateChanged;
	}

	private void ShutdownTimer_StateChanged(bool active) {
		WriteState(active ? "Active" : "Inactive");
	}

	private void WriteState(string state) {
		if (labelStatus.InvokeRequired) {
			labelStatus.Invoke(() => WriteState(state));
		} else {
			labelStatus.Text = state;
		}
	}

	private void ButtonStart_Click(object sender, EventArgs e) {
		shutdownTimer.Start(10);
	}

	private void ButtonStop_Click(object sender, EventArgs e) {
		shutdownTimer.Stop();
	}
}
