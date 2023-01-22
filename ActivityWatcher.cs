using System.ComponentModel;

namespace ShutdownTimer;
internal class ActivityWatcher {
	private int x;
	private int y;

	public event Action? UserAction;

	public ActivityWatcher() {
		_ = WatchAsync();
	}

	private async Task WatchAsync() {
		while (true) {
			await Task.Delay(100);
			if (x == Cursor.Position.X
				&& y == Cursor.Position.Y) {
				continue;
			}

			x = Cursor.Position.X;
			y = Cursor.Position.Y;

			UserAction?.Invoke();
		}
	}
}
