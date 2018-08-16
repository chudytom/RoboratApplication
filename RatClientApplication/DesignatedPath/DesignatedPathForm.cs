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
        private DesignatedPathManager pathManager;
        public DesignatedPathForm()
        {
            InitializeComponent();
            pathManager = new DesignatedPathManager();
            pathManager.DeleteControlRequested += PathManager_DeleteRequested;
            pathManager.AddControlRequested += PathManager_AddControlRequested;
        }
        private void PathManager_DeleteRequested(object sender, EventArgs e)
        {
            var controlToDelete = sender as PathElementControl;
            pathLayoutPanel.Controls.Remove(controlToDelete);
        }

        private void PathManager_AddControlRequested(object sender, EventArgs e)
        {
            var control = sender as PathElementControl;
            pathLayoutPanel.Controls.Add(control);
        }


        private void addPathElementButton_Click(object sender, EventArgs e)
        {
            pathManager.AddEmptyPathElement();
        }
        

        private void executePathButton_Click(object sender, EventArgs e)
        {
            ExecutePathRequested(pathManager.PathElements, EventArgs.Empty);
            Close();
        }

        private void savePathButton_Click(object sender, EventArgs e)
        {
            pathManager.SavePath();
        }

        private void loadPathButton_Click(object sender, EventArgs e)
        {
            pathManager.LoadPath();
        }

        public event EventHandler ExecutePathRequested = delegate { };
    }
}
