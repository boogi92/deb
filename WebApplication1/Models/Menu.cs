namespace WebApplication1.Models
{
    using System.Drawing;
    using System.IO;

    public class Menu
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual byte[] Imeg { get; set; }
        public virtual Image Img {
            get
            {
                return Image.FromStream(new MemoryStream(Imeg));
            }
        }
    }
}