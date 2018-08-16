using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatClientApplication.DesignatedPath
{
    public class PathManager
    {
        public List<PathElement> PathElements { get; private set; } = new List<PathElement>();

        public PathManager(List<PathElement> pathElements)
        {
            PathElements = pathElements;
        }


    }
}
