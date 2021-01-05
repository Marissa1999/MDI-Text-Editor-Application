//ID: 1775227
//Name: Marissa Goncalves
//Assignment 5 - Problem 2: MDI Text Editor

using System.Drawing;
using System.Windows.Forms;

namespace Problem02
{
    public partial class TextEditorForm : Form
    {
        private int childNumber = 1;
        private Color colour = Color.Black;
        private string fontName = "Times New Roman";
        private int size = 12;

        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var child = new TextFileChildForm($"Text File {childNumber}");
            child.MdiParent = this;
            child.Show();

            childNumber++;
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ClearSize()
        {
            size8ToolStripMenuItem.Checked = false;
            size10ToolStripMenuItem.Checked = false;
            size12ToolStripMenuItem.Checked = false;
            size14ToolStripMenuItem.Checked = false;
            size16ToolStripMenuItem.Checked = false;
            size18ToolStripMenuItem.Checked = false;
        }


        private void size8ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size8ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(8, fontName);
            }
        }

        private void size10ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size10ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(10, fontName);
            }
        }

        private void size12ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size12ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(12, fontName);
            }
        }

        private void size14ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size14ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length < 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(14, fontName);
            }
        }

        private void size16ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size16ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(16, fontName);
            }
        }

        private void size18ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearSize();

            size18ToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextSize(18, fontName);
            }
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            microsoftSansSerifToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearFont();

            timesNewRomanToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextFont(size,"Times New Roman");
            }
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearFont();

            microsoftSansSerifToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextFont(size, "Microsoft Sans Serif");
            }
        }

        private void arialToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearFont();

            arialToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextFont(size, "Arial");
            }
        }

        private void courierNewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearFont();

            courierNewToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextFont(size, "Courier New");
            }
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
            pinkToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            blackToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Black);
            }

        }

        private void redToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            redToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Red);
            }
        }

        private void yellowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            yellowToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Yellow);
            }
        }

        private void greenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            greenToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Green);
            }
        }

        private void blueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            blueToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Blue);
            }
        }

        private void orangeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            orangeToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Orange);
            }
        }

        private void purpleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            purpleToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Purple);
            }
        }

        private void pinkToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClearColor();

            pinkToolStripMenuItem.Checked = true;

            if (MdiChildren.Length > 0)
            {
                TextFileChildForm child = (TextFileChildForm) this.ActiveMdiChild;
                child.ChangeTextColor(Color.Pink);
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

    }
}
