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
            pathLayoutPanel.Controls.Add(control);
        }
    }
}
