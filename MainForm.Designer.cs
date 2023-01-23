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
			this.ButtonStart.BackColor = System.Drawing.Color.DarkGreen;
			this.ButtonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
			this.ButtonStart.FlatAppearance.BorderSize = 0;
			this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
			this.ButtonStart.Location = new System.Drawing.Point(98, 45);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(110, 41);
			this.ButtonStart.TabIndex = 0;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = false;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 75);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// TextMinutes
			// 
			this.TextMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.TextMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
			this.TextMinutes.Location = new System.Drawing.Point(159, 11);
			this.TextMinutes.Name = "TextMinutes";
			this.TextMinutes.Size = new System.Drawing.Size(49, 29);
			this.TextMinutes.TabIndex = 4;
			this.TextMinutes.Text = "30";
			this.TextMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
			this.label1.Location = new System.Drawing.Point(98, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Minutes";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(220, 94);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextMinutes);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ButtonStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
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
