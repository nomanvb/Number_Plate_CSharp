using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AdvancedCognition.Imaging
{
	/// <summary>
	/// Extension methods for Image
	/// </summary>
	public static class ImageExtension
	{
		/// <summary>
		/// Crops an image according to a selection rectangel
		/// </summary>
		/// <param name="image">
		/// the image to be cropped
		/// </param>
		/// <param name="selection">
		/// the selection
		/// </param>
		/// <returns>
		/// cropped image
		/// </returns>
		public static Image Crop(this Image image, Rectangle selection)
		{
			Bitmap bmp = image as Bitmap;

			// Check if it is a bitmap:
			if (bmp == null)
				throw new ArgumentException("Kein gültiges Bild (Bitmap)");

			// Crop the image:
			Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);
            
			// Release the resources:
			image.Dispose();

			return cropBmp;
		}

        public static Image CropF(this Image image, RectangleF selection)
        {
            Bitmap bmp = image as Bitmap;

            // Check if it is a bitmap:
            if (bmp == null)
                throw new ArgumentException("Kein gültiges Bild (Bitmap)");

            // Crop the image:
            Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

            // Release the resources:
            image.Dispose();

            return cropBmp;

        }

        public static Image CropImage(this Image image, Rectangle selection)
        {
            Bitmap bmp = new Bitmap(selection.Width, selection.Height);
            using (Graphics gph = Graphics.FromImage(bmp))
            {
                gph.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), selection, GraphicsUnit.Pixel);
            }
            //bmp = MakeGrayscale3(bmp);
            return bmp;

        }

		//---------------------------------------------------------------------
		/// <summary>
		/// Fits an image to the size of a picturebox
		/// </summary>
		/// <param name="image">
		/// image to be fit
		/// </param>
		/// <param name="picBox">
		/// picturebox in that the image should fit
		/// </param>
		/// <returns>
		/// fitted image
		/// </returns>
		/// <remarks>
		/// Although the picturebox has the SizeMode-property that offers
		/// the same functionality an OutOfMemory-Exception is thrown
		/// when assigning images to a picturebox several times.
		/// 
		/// AFAIK the SizeMode is designed for assigning an image to
		/// picturebox only once.
		/// </remarks>
		public static Image Fit2PictureBox(this Image image, PictureBox picBox)
		{
			Bitmap bmp = null;
			Graphics g;

			// Scale:
			double scaleY = (double)image.Width / picBox.Width;
			double scaleX = (double)image.Height / picBox.Height;
			double scale = scaleY < scaleX ? scaleX : scaleY;

			// Create new bitmap:
			bmp = new Bitmap(
				(int)((double)image.Width / scale),
				(int)((double)image.Height / scale));

			// Set resolution of the new image:
			bmp.SetResolution(
				image.HorizontalResolution,
				image.VerticalResolution);

			// Create graphics:
			g = Graphics.FromImage(bmp);

			// Set interpolation mode:
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			// Draw the new image:
			g.DrawImage(
				image,
				new Rectangle(			// Ziel
					0, 0,
					bmp.Width, bmp.Height),
				new Rectangle(			// Quelle
					0, 0,
					image.Width, image.Height),
				GraphicsUnit.Pixel);

			// Release the resources of the graphics:
			g.Dispose();
			
			// Release the resources of the origin image:
			image.Dispose();

			return bmp;
		}

        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
      {
         new float[] {.3f, .3f, .3f, 0, 0},
         new float[] {.59f, .59f, .59f, 0, 0},
         new float[] {.11f, .11f, .11f, 0, 0},
         new float[] {0, 0, 0, 1, 0},
         new float[] {0, 0, 0, 0, 1}
      });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
	}
}