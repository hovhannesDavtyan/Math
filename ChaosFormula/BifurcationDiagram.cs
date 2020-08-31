using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaosFormula
{
    public partial class BifurcationDiagram : Form
    {
        public BifurcationDiagram()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Bitmap diagramImage = new Bitmap(bDiagram.ClientSize.Width, bDiagram.ClientSize.Height);
            bDiagram.BackgroundImage = diagramImage;


            Double coeficient;
            Graphics G = bDiagramProgress.CreateGraphics();
            for (int y = 0; y < diagramImage.Height; y++)
            {
                coeficient = 2.5 + (4 - 2.5) * y / diagramImage.Height;
                Double x = 0.2;
                for (int i = 1; i < 500; i++)
                {
                    x = coeficient * x * (1 - x);
                }

                for (int i = 1; i < 500; i++)
                {
                    x = coeficient * x * (1 - x);
                    diagramImage.SetPixel((int)(x * diagramImage.Width), y, Color.Green);
                    int y1 = (int)(x * bDiagramProgress.Height);
                    G.DrawLine(Pens.Red, 0, y1, 0, y1 + 1);
                    bDiagramProgress.Scroll(1, 0);
                    Application.DoEvents();
                }
                bDiagram.Refresh();
            }
            G.Dispose();
        }
    }
}

public static class MyExtensions
{
    [StructLayout(LayoutKind.Sequential)]
    public class RECT
    {
        public Int32 left;
        public Int32 top;
        public Int32 right;
        public Int32 bottom;
    }
    [DllImport("user32.dll")]
    private static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, [MarshalAs(UnmanagedType.LPStruct)] RECT prcScroll, [MarshalAs(UnmanagedType.LPStruct)] RECT prcClip, IntPtr hrgnUpdate, [MarshalAs(UnmanagedType.LPStruct)] RECT prcUpdate, System.UInt32 flags);
    public static void Scroll(this PictureBox BP, int dx, int dy)
    {
        ScrollWindowEx(BP.Handle, dx, dy, null, null, IntPtr.Zero, null, 2);
    }
}