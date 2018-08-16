using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatClientApplication.DesignatedPath
{
    public class DesignatedPathManager
    {
        public List<PathElement> PathElements { get; set; } = new List<PathElement>();
        private char delimiter = ';';

        public void AddEmptyPathElement()
        {
            AddPathElement(new PathElement());
        }

        private void AddPathElement(PathElement pathElement)
        {
            PathElements.Add(pathElement);
            var control = new PathElementControl(pathElement);
            control.DeleteRequested += Control_DeleteRequested;
            AddControlRequested(control, EventArgs.Empty);
        }

        public void SavePath(string path = null)
        {
            if (!ValidatePath(PathElements))
                return;
            var actualPath = path;
            if (String.IsNullOrWhiteSpace(actualPath))
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "csv files (*.csv)|*.csv";
                dialog.RestoreDirectory = true;
                dialog.Title = "Choose where to save the file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(dialog.FileName))
                    {
                        actualPath = dialog.FileName;
                    }
                }
                var lines = new List<string>() { String.Join(delimiter.ToString(), "direction", "speed", "time") };
                lines.AddRange(PathElements.Select(elem => String.Join(delimiter.ToString(), (int)elem.PathDirection, elem.Speed, elem.Time)));
                File.WriteAllLines(actualPath, lines);
            }
        }

        private bool ValidatePath(List<PathElement> pathElements)
        {
            if (pathElements.Count == 0)
            {
                MessageBox.Show("There are no path elements to save");
                return false;
            }
            if (pathElements.Any(elem => elem.Speed <= 0 || elem.Time <= 0))
            {
                MessageBox.Show("Speed and Time values must be larger than 0");
                return false;
            }
            return true;
        }

        public void LoadPath()
        {
            if (PathElements.Count > 0)
            {
                DialogResult messageBoxResult = MessageBox.Show(
                    "Are you sure you want to load another path? The correct won't be saved", "Should load different path?",
                    MessageBoxButtons.YesNo);
                if (messageBoxResult != DialogResult.Yes)
                    return;
            }

            var dialog = new OpenFileDialog();
            dialog.Filter = "csv files (*.csv)|*.csv";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PathElements.Clear();
                    var lines = File.ReadAllLines(dialog.FileName);
                    foreach (var line in lines.Skip(1))
                    {
                        var splitLine = line.Split(delimiter);
                        try
                        {
                            var pathElement = new PathElement(
                                (PathElement.DirectionEnum)int.Parse(splitLine[0]), decimal.Parse(splitLine[1]), decimal.Parse(splitLine[2])
                            );
                            AddPathElement(pathElement);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Incorrect values in chosen file");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not load path");
                }
            }

        }

        private void Control_DeleteRequested(object sender, EventArgs e)
        {
            var controlToDelete = sender as PathElementControl;
            PathElements.Remove(controlToDelete.CustomPathElement);
            DeleteControlRequested(controlToDelete, EventArgs.Empty);
        }

        public event EventHandler DeleteControlRequested = delegate { };
        public event EventHandler AddControlRequested = delegate { };
    }
}
