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
	}

	private void ShutdownTimer_StateChanged(bool active) {
		WriteState(active);
	}

	private void WriteState(bool active) {
		if (buttonStart.InvokeRequired) {
			buttonStart.Invoke(WriteState);
			return;
		}

		textMinutes.Enabled = !active;

		if (active) {
			buttonStart.BackColor = Color.LightPink;
			buttonStart.Text = "Stop";
			return;
		}

		buttonStart.BackColor = Color.LightGreen;
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

	private void ButtonStop_Click(object sender, EventArgs e) {
		shutdownTimer.Stop();
	}
}
