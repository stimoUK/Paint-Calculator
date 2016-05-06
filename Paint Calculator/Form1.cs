using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Calculator
{
    public partial class PaintCalculator : Form
    {
        // variables
        double height;
        double width;
        double length;
        double area;
        double volume;
        double paintableArea;
        double requiredPaint;
        double widthWall;
        double lengthWall;

        // constructor
        public PaintCalculator()
        {
            InitializeComponent();
        }

        // methods
        #region Calculations

        public void CalcArea()
        {
            area = length * width;
        }

        public void CalcVolume()
        {
            volume = area * height;
        }

        public void CalcPaintArea()
        {
            widthWall = width * height * 2;
            lengthWall = length * height * 2;
            paintableArea = widthWall + lengthWall;

            if (paintableArea < 0)
            {
                paintableArea = 0;
            }
        }

        public void CalcRequiredPaint(double paintCoveragePerLitre)
        {
            requiredPaint = paintableArea / paintCoveragePerLitre;

            if (requiredPaint < 0)
            {
                requiredPaint = 0;
            }
        }

        #endregion

        #region Button

        private void Go_Click(object sender, EventArgs e)
        {
            // coverage of paint, 1 litre per 12 sq metres.
            double coverage = 12;
            bool inputValid = true;

            // Validate that all room dimension inputs are numerical and not too large before passing to class
            if (Regex.IsMatch(textWidth.Text, @"^[0-9,\.]+$") == true && Convert.ToDouble(textWidth.Text) < 1000)
            {
                width = Convert.ToDouble(textWidth.Text);
            }
            else
            {
                inputValid = false;
            }

            if (Regex.IsMatch(textLength.Text, @"^[0-9,\.]+$") == true && Convert.ToDouble(textLength.Text) < 1000)
            {
                length = Convert.ToDouble(textLength.Text);
            }
            else
            {
                inputValid = false;
            }

            if (Regex.IsMatch(textHeight.Text, @"^[0-9,\.]+$") == true && Convert.ToDouble(textHeight.Text) < 1000)
            {
                height = Convert.ToDouble(textHeight.Text);
            }
            else
            {
                inputValid = false;
            }

            if (inputValid == true)
            {
                // Run calculations if input is valid
                CalcArea();
                CalcVolume();
                CalcPaintArea();
                CalcRequiredPaint(coverage);

                // Display results
                displayArea.Text = area.ToString() + "m\u00b2"; // Unicode - displays squared.
                displayVolume.Text = volume.ToString() + "m\u00b3"; // Unicode - displays cubed.
                paintRequired.Text = requiredPaint.ToString() + "L";
            }
            else
            {
                MessageBox.Show("Room dimensions invalid. Please re-enter them and try again.");
            }
        }

        #endregion
    }
}
