using System.Diagnostics;

namespace ShutdownTimer;
internal class ShutdownTimer {
	private readonly ActivityWatcher activityWatcher;

	private const int SHUTDOWN_NOTIFICATION_SECONDS = 30;

	public bool Active { get; private set; } = false;
	public event Action<bool>? StateChanged;

	private int minutes = 0;
	private DateTimeOffset lastActivity;
	private readonly System.Timers.Timer timer;
	private bool showPreviewAlert = false;

	public ShutdownTimer() {
		activityWatcher = new();
		activityWatcher.UserAction += ActivityWatcher_UserAction;
		timer = new(1000);
		timer.Elapsed += Timer_Elapsed;
	}

	public void Start(int minutes) => ChangeState(true, minutes);

	public void Stop() => ChangeState(false, 0);

	private void ChangeState(bool start, int minutes) {
		if (start == Active) {
			return;
		}

		Active = start;
		this.minutes = minutes;
		lastActivity = DateTimeOffset.UtcNow;

		if (start) {
			timer.Start();
		} else {
			timer.Stop();
		}

		StateChanged?.Invoke(start);
	}


	private void ActivityWatcher_UserAction() {
		lastActivity = DateTimeOffset.UtcNow;
		showPreviewAlert = false;
	}

	private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e) {
		DateTimeOffset shutdownTime = lastActivity.AddMinutes(minutes);

		if (!showPreviewAlert
			&& shutdownTime.AddSeconds(-SHUTDOWN_NOTIFICATION_SECONDS) < DateTimeOffset.UtcNow) {
			showPreviewAlert = true;
			MessageBox.Show($"Shutdown in {SHUTDOWN_NOTIFICATION_SECONDS} seconds");
			return;
		}

		if (shutdownTime > DateTimeOffset.UtcNow) {
			return;
		}

		Stop();
		ProcessStartInfo processStartInfo = new("shutdown.exe", "/s /t 0");
		Process.Start(processStartInfo);
	}
}
