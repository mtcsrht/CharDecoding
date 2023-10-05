using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharDecoding
{
    public partial class FrmMain : Form
    {

        public Label[,] LblMatrix { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            InitLblMatrix();
        }

        private void InitLblMatrix()
        {
            LblMatrix = new Label[7, 4];
            for (int r = 0; r < LblMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < LblMatrix.GetLength(1); c++)
                {
                    LblMatrix[r, c] = new Label()
                    {
                        AutoSize = false,
                        Bounds = new Rectangle(
                            x: c * 50,
                            y: r * 50,
                            width: 50,
                            height: 50
                            ),
                        BackColor = Color.White,
                        Text = "0",
                        Font = new Font("Arial", 24f, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(5),
                        Padding = Padding.Empty
                    };
                    LblMatrix[r, c].Click += LblMatrixCell_Click;
                    pnlMatrixContainer.Controls.Add(LblMatrix[r, c]);
                }
            }
        }

        private void LblMatrixCell_Click(object sender, EventArgs e)
        {
            var lblBtn = (sender as Label);
            if (lblBtn.Text == "0")
            {
                lblBtn.BackColor = Color.LightGray;
                lblBtn.Text = "1";
            }
            else
            {
                lblBtn.BackColor = Color.White;
                lblBtn.Text = "0";
            }
        }
    }
}
