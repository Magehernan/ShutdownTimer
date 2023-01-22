namespace ShutdownTimer;

partial class Main {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
			this.ButtonStart = new System.Windows.Forms.Button();
			this.ButtonStop = new System.Windows.Forms.Button();
			this.LabelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonStart
			// 
			this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonStart.Location = new System.Drawing.Point(12, 126);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(75, 23);
			this.ButtonStart.TabIndex = 0;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// ButtonStop
			// 
			this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStop.Location = new System.Drawing.Point(97, 126);
			this.ButtonStop.Name = "ButtonStop";
			this.ButtonStop.Size = new System.Drawing.Size(75, 23);
			this.ButtonStop.TabIndex = 1;
			this.ButtonStop.Text = "Stop";
			this.ButtonStop.UseVisualStyleBackColor = true;
			this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// LabelStatus
			// 
			this.LabelStatus.AutoSize = true;
			this.LabelStatus.Location = new System.Drawing.Point(124, 87);
			this.LabelStatus.Name = "LabelStatus";
			this.LabelStatus.Size = new System.Drawing.Size(48, 15);
			this.LabelStatus.TabIndex = 2;
			this.LabelStatus.Text = "Inactive";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(184, 161);
			this.Controls.Add(this.LabelStatus);
			this.Controls.Add(this.ButtonStop);
			this.Controls.Add(this.ButtonStart);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "Main";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shutdown";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Button ButtonStart;
	private Button ButtonStop;
	private Label LabelStatus;
}
