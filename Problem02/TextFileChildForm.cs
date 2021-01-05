//ID: 1775227
//Name: Marissa Goncalves
//Assignment 5 - Problem 2: MDI Text Editor

using System.Drawing;
using System.Windows.Forms;

namespace Problem02
{
    public partial class TextFileChildForm : Form
    {
        public TextFileChildForm(string title)
        {
            InitializeComponent();
            Text = title;
        }

        public void ChangeTextColor(Color colour)
        {
            displayRichTextBox.SelectionColor = colour;
        }


        public void ChangeTextSize(int size, string fontName)
        {
            displayRichTextBox.SelectionFont = new Font(fontName, size);
        }


        public void ChangeTextFont(int size, string fontName)
        {
            displayRichTextBox.SelectionFont = new Font(fontName, size);
        }

    }
}
