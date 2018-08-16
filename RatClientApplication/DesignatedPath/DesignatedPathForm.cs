using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatClientApplication.DesignatedPath
{
    public partial class DesignatedPathForm : Form
    {
        public List<PathElement> PathElements { get; set; } = new List<PathElement>();
        public DesignatedPathForm()
        {
            InitializeComponent();
        }

        private void addPathElementButton_Click(object sender, EventArgs e)
        {
            AddPathElement();
        }

        private void AddPathElement()
        {
            var pathElement = new PathElement();
            PathElements.Add(pathElement);
            var control = new PathElementControl(pathElement);
            control.DeleteRequested += Control_DeleteRequested;
            pathLayoutPanel.Controls.Add(control);
        }

        private void Control_DeleteRequested(object sender, EventArgs e)
        {
            var controlToDelete = sender as PathElementControl;
            PathElements.Remove(controlToDelete.CustomPathElement);
            pathLayoutPanel.Controls.Remove(controlToDelete);
        }

        private void executePathButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Path execution in progress");
        }
    }
}
