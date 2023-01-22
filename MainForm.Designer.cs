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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.ButtonStart = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TextMinutes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonStart
			// 
			this.ButtonStart.BackColor = System.Drawing.Color.PaleGreen;
			this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonStart.Location = new System.Drawing.Point(98, 46);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(110, 41);
			this.ButtonStart.TabIndex = 0;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = false;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ShutdownTimer.Properties.Resources.icon;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 75);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// TextMinutes
			// 
			this.TextMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextMinutes.Location = new System.Drawing.Point(159, 12);
			this.TextMinutes.Name = "TextMinutes";
			this.TextMinutes.Size = new System.Drawing.Size(49, 29);
			this.TextMinutes.TabIndex = 4;
			this.TextMinutes.Text = "30";
			this.TextMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(98, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Minutes";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 99);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextMinutes);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ButtonStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(236, 138);
			this.MinimumSize = new System.Drawing.Size(236, 138);
			this.Name = "Main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shutdown";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Button ButtonStart;
	private PictureBox pictureBox1;
	private TextBox TextMinutes;
	private Label label1;
}
