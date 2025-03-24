using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sfGrid.CellRenderers.Remove("Text");
            sfGrid.CellRenderers.Add("Text", new CustomTextCellRenderer());
        }
    }
    public class CustomTextCellRenderer : DataGridTextBoxCellRenderer
    {
        protected override void OnSetCellStyle(DataColumnBase dataColumn)
        {
            base.OnSetCellStyle(dataColumn);

            if (dataColumn != null)
            {
                DataGridCell gridCell = dataColumn.ColumnElement;

                if (gridCell != null)
                {
                    var label = gridCell.Children[0] as Label;
                    if (label != null)
                    {
                        label.TextColor = Colors.Orange;
                        label.FontAttributes = FontAttributes.Bold;
                    }

                    gridCell = null;
                }
            }
        }
    }
}