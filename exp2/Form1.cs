using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp2
{
	public partial class Form1 : Form
	{
		private string path_;
		public Form1()
		{
			InitializeComponent();
		}

		private Bitmap MakeGrayscale(Bitmap original)
		{
			Bitmap gray = new Bitmap(original.Width, original.Height);

			for (int i = 0; i < gray.Width; i++)
			{
				for (int j = 0; j < gray.Height ; j++)
				{
					// 遍历原先图像中的每个像素点
					// 对每一个像素应用平均化算法进行灰度化
					Color curColor = original.GetPixel(i,j);
					int ret = (int)(curColor.R * 0.299 + curColor.G * 0.587 + curColor.B * 0.114);
					gray.SetPixel(i, j, Color.FromArgb(ret, ret, ret));
				}
			}
			return gray;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			// 选择图片
			using (OpenFileDialog openfile = new OpenFileDialog())
			{
				// 判断图片是否有效
				if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
				{
					// 将图片显示在预览中
					pictureBox_origin.ImageLocation = openfile.FileName;
				}

				// 保存图片路径
				path_ = openfile.FileName;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// 彩色图像灰度化逻辑
			pictureBox_proc.Image = MakeGrayscale((Bitmap)pictureBox_origin.Image);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// 保存灰度化后的图像
			pictureBox_proc.Image.Save(path_ + ".gray");
		}
	}
}
