using System;
using System.Windows.Forms;
using SharpShell.SharpPreviewHandler;

public partial class PreviewControl : PreviewHandlerControl
{
        public string Path;
        public PreviewControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void DoPreview(String path)
        {
            Paloma.TargaImage tga = new Paloma.TargaImage(Path);
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = tga.Image;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Width;

            TabControl tb = new TabControl();

            TabPage tp1 = new TabPage();
            tp1.Text = "Properities ";
            tp1.AutoScroll = true;

            tp1.Controls.Add(new Label
            {
                Text = "Width :     " + tga.Header.Width + " px",
                Dock = DockStyle.Top
            });
            tp1.Controls.Add(new Label
            {
                Text = "Height:    " + tga.Header.Height + " px",
                Dock = DockStyle.Top
            });
            tp1.Controls.Add(new Label
            {
                Text = "ImageType: " + tga.Header.ImageType.ToString() + " px",
                Dock = DockStyle.Top
            });
            tp1.Controls.Add(new Label
            {
                Text = "Format:   " + tga.Format.ToString() + " px",
                Dock = DockStyle.Top
            });


            tp1.Controls.Add(new Label
            {
                Text = "Width:   " + tga.Header.Width + " px",
                Dock = DockStyle.Top
            });

            tb.TabPages.Add(tp1);
            tb.Dock = DockStyle.Bottom;

            Controls.Add(pictureBox1);
            Controls.Add(tb);
            
            
        }
}
