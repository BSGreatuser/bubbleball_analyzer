namespace 파워볼_분석기
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002424 File Offset: 0x00000624
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002460 File Offset: 0x00000660
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::파워볼_분석기.Form1));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("굴림", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label1.Location = new global::System.Drawing.Point(883, 560);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(76, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "추천값 ";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("굴림", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(917, 544);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(42, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "시간";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Do Hyeon", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(8, 23);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(134, 48);
			this.label3.TabIndex = 2;
			this.label3.Text = "파워볼";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Do Hyeon", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(6, 27);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(39, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "날짜";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Do Hyeon", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(6, 24);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(112, 48);
			this.label5.TabIndex = 4;
			this.label5.Text = "0:00";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.groupBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new global::System.Drawing.Font("Do Hyeon", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.groupBox1.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new global::System.Drawing.Point(63, 127);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(289, 61);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "데이터 서버";
			this.groupBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new global::System.Drawing.Font("Do Hyeon", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.groupBox2.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox2.Location = new global::System.Drawing.Point(63, 194);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(133, 80);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "데이터 연동";
			this.groupBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Font = new global::System.Drawing.Font("Do Hyeon", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.groupBox3.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox3.Location = new global::System.Drawing.Point(202, 194);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(149, 80);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "데이터 결과값";
			this.groupBox4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox4.Controls.Add(this.groupBox1);
			this.groupBox4.Controls.Add(this.groupBox3);
			this.groupBox4.Controls.Add(this.groupBox2);
			this.groupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(405, 449);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(404, 444);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.Name = "Form1";
			this.Text = "Life Batting Program";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.GroupBox groupBox4;
	}
}
