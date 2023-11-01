namespace Universal_List_Generator
{
	partial class MainForm
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
			kryptonStatusStripInfo = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripContainer = new ToolStripContainer();
			kryptonStatusStripStatistic = new Krypton.Toolkit.KryptonStatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			menuStrip = new MenuStrip();
			kryptonPanel = new Krypton.Toolkit.KryptonPanel();
			kryptonStatusStripInfo.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
			SuspendLayout();
			// 
			// kryptonStatusStripInfo
			// 
			kryptonStatusStripInfo.Dock = DockStyle.None;
			kryptonStatusStripInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			kryptonStatusStripInfo.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
			kryptonStatusStripInfo.Location = new Point(0, 0);
			kryptonStatusStripInfo.Name = "kryptonStatusStripInfo";
			kryptonStatusStripInfo.ProgressBars = null;
			kryptonStatusStripInfo.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStripInfo.Size = new Size(715, 22);
			kryptonStatusStripInfo.SizingGrip = false;
			kryptonStatusStripInfo.TabIndex = 1;
			kryptonStatusStripInfo.Text = "kryptonStatusStripInfo";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStripInfo);
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStripStatistic);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(kryptonPanel);
			toolStripContainer.ContentPanel.Size = new Size(715, 379);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(715, 447);
			toolStripContainer.TabIndex = 2;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
			// 
			// kryptonStatusStripStatistic
			// 
			kryptonStatusStripStatistic.Dock = DockStyle.None;
			kryptonStatusStripStatistic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			kryptonStatusStripStatistic.Location = new Point(0, 22);
			kryptonStatusStripStatistic.Name = "kryptonStatusStripStatistic";
			kryptonStatusStripStatistic.ProgressBars = null;
			kryptonStatusStripStatistic.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStripStatistic.Size = new Size(715, 22);
			kryptonStatusStripStatistic.SizingGrip = false;
			kryptonStatusStripStatistic.TabIndex = 2;
			kryptonStatusStripStatistic.Text = "kryptonStatusStripStatistic";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(118, 17);
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// menuStrip
			// 
			menuStrip.Dock = DockStyle.None;
			menuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(715, 24);
			menuStrip.TabIndex = 0;
			// 
			// kryptonPanel
			// 
			kryptonPanel.Dock = DockStyle.Fill;
			kryptonPanel.Location = new Point(0, 0);
			kryptonPanel.Name = "kryptonPanel";
			kryptonPanel.Size = new Size(715, 379);
			kryptonPanel.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(715, 447);
			Controls.Add(toolStripContainer);
			CornerRoundingRadius = 10F;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
			StateCommon.Border.Rounding = 10F;
			Text = "Universal List Generator";
			kryptonStatusStripInfo.ResumeLayout(false);
			kryptonStatusStripInfo.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Krypton.Toolkit.KryptonButton kryptonButton1;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStripInfo;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStripStatistic;
		private MenuStrip menuStrip;
		private Krypton.Toolkit.KryptonPanel kryptonPanel;
		private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
		private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem toolStripMenuItem3;
	}
}