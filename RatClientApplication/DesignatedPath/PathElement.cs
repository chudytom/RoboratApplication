using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatClientApplication.DesignatedPath
{
    public class PathElement
    {
        public Direction PathDirection { get; set; }
        public decimal Speed { get; set; }
        public decimal Time { get; set; }


        public enum Direction { Left, Forward, Right, Backward }
    }
}
