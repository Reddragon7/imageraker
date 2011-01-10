﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ImageRakerToolbar
{
	public class TransparentLabel : Label
	{
		/// <summary>
		/// Creates a new <see cref="TransparentLabel"/> instance.
		/// </summary>
		public TransparentLabel()
		{
			TabStop = false;
		}

		/// <summary>
		/// Gets the creation parameters.
		/// </summary>
		//protected override CreateParams CreateParams
		//{
		//    get
		//    {
		//        CreateParams cp = base.CreateParams;
		//        cp.ExStyle |= 0x20;
		//        return cp;
		//    }
		//}

		/// <summary>
		/// Paints the background.
		/// </summary>
		/// <param name="e">E.</param>
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (this.BackColor != Color.Transparent)
			{
				IntPtr hdc = e.Graphics.GetHdc();
				Rectangle rec = new Rectangle(e.ClipRectangle.Left,
				e.ClipRectangle.Top, e.ClipRectangle.Width, e.ClipRectangle.Height);
				try
				{
					UxTheme.DrawThemeParentBackground(this.Handle, hdc, ref rec);
				}
				catch (Exception ex)
				{
					Logger.Warn("cannot draw label background! {0}", ex.Message);
				}
				e.Graphics.ReleaseHdc(hdc);
			}
			else
			{
				base.OnPaintBackground(e);
			}
		}

		/// <summary>
		/// Paints the control.
		/// </summary>
		/// <param name="e">E.</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			using (SolidBrush brush = new SolidBrush(ForeColor))
			{
				e.Graphics.DrawString(Text, Font, brush, -1, 0);
			}
		}

	}
}
