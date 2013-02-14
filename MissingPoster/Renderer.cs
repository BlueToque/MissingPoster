using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Reporting.WinForms;
using System.Drawing.Drawing2D;
using System;

namespace MissingPoster
{
    public static class Renderer
    {
        /// <summary>
        /// 
        /// </summary>
        static XNamespace ns1 = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";

        /// <summary>
        /// 
        /// </summary>
        public static List<string> s_imageFileFormats = new List<string>() { ".png", ".jpg", ".gif", ".bmp", ".wmf" };

        /// <summary>
        /// get the map element from the XmlDocument with the form definition
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static XElement GetImage(string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement xMap = xdoc
                .Element(ns1 + "Report")
                .Element(ns1 + "Body")
                .Element(ns1 + "ReportItems")
                .Elements(ns1 + "Image")
                .Where(x => x.Attribute("Name").Value == "MissingPersonImage")
                .FirstOrDefault();
            return xMap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xElement"></param>
        /// <param name="resolution"></param>
        /// <returns></returns>
        static float ParseValue(XElement xElement, float resolution)
        {
            if (xElement.Value.EndsWith("cm"))
                return float.Parse(xElement.Value.Replace("cm", "")) * 0.393701f * resolution;
            else
                return float.Parse(xElement.Value.Replace("in", "")) * resolution;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="templatePath"></param>
        /// <param name="resolution"></param>
        /// <returns></returns>
        internal static SizeF GetSize(string templatePath, float resolution)
        {
            XElement xMap = GetImage(templatePath);

            float width = 0.0f;
            float height = 0.0f;
            if (xMap != null)
            {
                width = ParseValue(xMap.Element(ns1 + "Width"), resolution);
                height = ParseValue(xMap.Element(ns1 + "Height"), resolution);
            }

            return new SizeF(width, height);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reportViewer"></param>
        /// <param name="fileName"></param>
        /// <param name="format">"Excel", "PDF", "Word", "Image"</param>
        public static void RenderReport(ReportViewer reportViewer, string fileName, string format)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer.LocalReport.Render(
                format,
                null,
                out mimeType,
                out encoding,
                out filenameExtension,
                out streamids,
                out warnings);

            string ext = Path.GetExtension(fileName).ToLower();
            if (s_imageFileFormats.Contains(ext))
                ExportImage(fileName, bytes);
            else
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    fs.Write(bytes, 0, bytes.Length);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="bytes"></param>
        public static void ExportImage(string fileName, byte[] bytes)
        {
            string ext = Path.GetExtension(fileName).ToLower();

            Image image = Image.FromStream(new MemoryStream(bytes));
            switch (ext)
            {
                case ".bmp": image.Save(fileName, ImageFormat.Bmp); break;
                case ".jpg": image.Save(fileName, ImageFormat.Jpeg); break;
                case ".png": image.Save(fileName, ImageFormat.Png); break;
                case ".wmf": image.Save(fileName, ImageFormat.Wmf); break;
                case ".gif": image.Save(fileName, ImageFormat.Gif); break;
                default: 
                    MessageBox.Show(
                        null, 
                        "Unable to export to selected format", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error); 
                        break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="destSize"></param>
        /// <returns></returns>
        public static Image resizeImage(Image image, Size destSize)
        {
            //Image image = Image.FromFile(path + originalFilename);

            Image thumbnail = new Bitmap(destSize.Width, destSize.Height);
            using (Graphics graphic = Graphics.FromImage(thumbnail))
            {

                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;

                // Figure out the ratio
                double ratioX = (double)destSize.Width / (double)image.Width;
                double ratioY = (double)destSize.Height / (double)image.Height;

                // use whichever multiplier is smaller
                double ratio = ratioX < ratioY ? ratioX : ratioY;

                // now we can get the new height and width
                int newHeight = Convert.ToInt32(image.Height * ratio);
                int newWidth = Convert.ToInt32(image.Width * ratio);

                // Now calculate the X,Y position of the upper-left corner 
                // (one of these will always be zero)
                int posX = Convert.ToInt32((destSize.Width - (image.Width * ratio)) / 2);
                int posY = Convert.ToInt32((destSize.Height - (image.Height * ratio)) / 2);

                graphic.Clear(Color.White); // white padding
                graphic.DrawImage(image, posX, posY, newWidth, newHeight);
            }
            //ImageCodecInfo[] info = ImageCodecInfo.GetImageEncoders();
            //EncoderParameters encoderParameters;
            //encoderParameters = new EncoderParameters(1);
            //encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100L);
            
            return thumbnail;
            //thumbnail.Save(path + width + "." + originalFilename, info[1], encoderParameters);
        }
    }
}
