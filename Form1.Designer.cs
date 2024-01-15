namespace GOG_Intergalactic
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			listBox1 = new ListBox();
			splitContainer2 = new SplitContainer();
			productSettings = new CheckedListBox();
			shortcutButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(listBox1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(484, 485);
			splitContainer1.SplitterDistance = 243;
			splitContainer1.TabIndex = 0;
			// 
			// listBox1
			// 
			listBox1.DisplayMember = "Title";
			listBox1.Dock = DockStyle.Fill;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(0, 0);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(243, 485);
			listBox1.TabIndex = 0;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(productSettings);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(shortcutButton);
			splitContainer2.Size = new Size(237, 485);
			splitContainer2.SplitterDistance = 411;
			splitContainer2.TabIndex = 0;
			// 
			// productSettings
			// 
			productSettings.CheckOnClick = true;
			productSettings.Dock = DockStyle.Fill;
			productSettings.FormattingEnabled = true;
			productSettings.Items.AddRange(new object[] { "autoUpdate", "cloudStorage", "overlay", "desktopShortcut" });
			productSettings.Location = new Point(0, 0);
			productSettings.Name = "productSettings";
			productSettings.Size = new Size(237, 411);
			productSettings.TabIndex = 0;
			productSettings.ItemCheck += productSettings_ItemCheck;
			// 
			// shortcutButton
			// 
			shortcutButton.Dock = DockStyle.Fill;
			shortcutButton.Enabled = false;
			shortcutButton.Location = new Point(0, 0);
			shortcutButton.Name = "shortcutButton";
			shortcutButton.Size = new Size(237, 70);
			shortcutButton.TabIndex = 0;
			shortcutButton.Text = "Create Desktop shortcut";
			shortcutButton.UseVisualStyleBackColor = true;
			shortcutButton.Click += shortcutButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 485);
			Controls.Add(splitContainer1);
			MaximizeBox = false;
			Name = "Form1";
			Text = "GOG Intergalactic";
			Load += Form1_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private ListBox listBox1;
		private SplitContainer splitContainer2;
		private CheckedListBox productSettings;
		private Label label1;
		private Button shortcutButton;
	}
}
