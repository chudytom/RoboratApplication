using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatClientApplication.DesignatedPath
{
    public partial class PathElementControl : UserControl
    {
        public PathElement CustomPathElement { get; private set; } = new PathElement();

        public PathElementControl()
        {
            InitializeComponent();
            AddItemsToComboBox();
        }

        public PathElementControl(PathElement pathElement) : this()
        {
            CustomPathElement = pathElement;
        }

        private void AddItemsToComboBox()
        {
            foreach (var item in Enum.GetNames(typeof(PathElement.Direction)))
            {
                directionComboBox.Items.Add(item);
            }
        }

        private void directionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomPathElement.PathDirection = (PathElement.Direction)directionComboBox.SelectedIndex;
        }

        private void speedNumeric_ValueChanged(object sender, EventArgs e)
        {
            CustomPathElement.Speed = speedNumeric.Value;
        }

        private void timeNumeric_ValueChanged(object sender, EventArgs e)
        {
            CustomPathElement.Time = timeNumeric.Value;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRequested(this, EventArgs.Empty);
        }

        public event EventHandler DeleteRequested = delegate { };

    }
}
