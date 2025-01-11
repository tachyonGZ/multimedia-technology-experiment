namespace exp2
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox_origin = new System.Windows.Forms.PictureBox();
			this.pictureBox_proc = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_proc)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_origin
			// 
			this.pictureBox_origin.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_origin.Name = "pictureBox_origin";
			this.pictureBox_origin.Size = new System.Drawing.Size(520, 520);
			this.pictureBox_origin.TabIndex = 0;
			this.pictureBox_origin.TabStop = false;
			// 
			// pictureBox_proc
			// 
			this.pictureBox_proc.Location = new System.Drawing.Point(538, 12);
			this.pictureBox_proc.Name = "pictureBox_proc";
			this.pictureBox_proc.Size = new System.Drawing.Size(520, 520);
			this.pictureBox_proc.TabIndex = 1;
			this.pictureBox_proc.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(1065, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 43);
			this.button1.TabIndex = 2;
			this.button1.Text = "打开图片";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(1065, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 43);
			this.button2.TabIndex = 3;
			this.button2.Text = "灰度化";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button4.Location = new System.Drawing.Point(1065, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(101, 43);
			this.button4.TabIndex = 5;
			this.button4.Text = "保存图片";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 544);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox_proc);
			this.Controls.Add(this.pictureBox_origin);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_proc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_origin;
		private System.Windows.Forms.PictureBox pictureBox_proc;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
	}
}

