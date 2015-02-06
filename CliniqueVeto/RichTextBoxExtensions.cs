using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniqueVeto
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, float taille = 12, bool bold = false, bool italic = false, bool souligne = false)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            if (bold)
                box.SelectionFont = new Font(new System.Drawing.FontFamily("Cambria"), taille, FontStyle.Bold);
            else if (italic)
                box.SelectionFont = new Font(new System.Drawing.FontFamily("Cambria"), taille, FontStyle.Italic);
            else if (souligne)
                box.SelectionFont = new Font(new System.Drawing.FontFamily("Cambria"), taille, FontStyle.Underline);
            else
                box.SelectionFont = new Font(new System.Drawing.FontFamily("Cambria"), taille);


            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
