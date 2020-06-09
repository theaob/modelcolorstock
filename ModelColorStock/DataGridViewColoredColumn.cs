using System.Drawing;
using System.Windows.Forms;

namespace ModelColorStock
{
    public sealed class DataGridViewColoredColumn : DataGridViewColumn
    {
        public DataGridViewColoredColumn()
        {
            CellTemplate = new DataGridViewColoredCell();

        }

        public class DataGridViewColoredCell : DataGridViewTextBoxCell
        {

            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

                if(value != null)
                {
                    string cellValue = (string)value.ToString();
                    const int horizontaloffset = 0;
                    var newRect = new Rectangle(
                       cellBounds.X + horizontaloffset,
                       cellBounds.Y + cellBounds.Height - 6,
                       cellBounds.Width,
                       5);

                    if (cellValue != null && cellValue != "")
                    {

                        if (!cellValue.StartsWith("#"))
                        {
                            cellValue = "#" + cellValue;
                        }

                        graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml(cellValue)), newRect);
                    }
                }
            }

            void DrawString(Graphics graphics, Rectangle cellBounds, DataGridViewElementStates cellState, string cellText)
            {
                Font fnt = new Font("Arial", 12, GraphicsUnit.Pixel);

                SizeF textSize =
                   graphics.MeasureString(cellText, fnt);


                //  Calculate the correct color:
                Color textColor = Color.Black;
                if ((cellState &
                   DataGridViewElementStates.Selected) ==
                   DataGridViewElementStates.Selected)
                {
                    textColor = InheritedStyle.SelectionForeColor;
                }
                // Draw the text:
                using (SolidBrush brush =
                new SolidBrush(textColor))
                {
                    graphics.DrawString(cellText, fnt, brush,
                      cellBounds.X,
                      cellBounds.Y);
                }
            }
        }
    }
}
