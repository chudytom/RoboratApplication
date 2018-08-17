using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatClientApplication.DesignatedPath
{
    public class PathElement
    {
        public DirectionEnum PathDirection { get; set; }
        public decimal Speed { get; set; }
        public decimal Time { get; set; }

        public PathElement()
        {

        }

        public PathElement(DirectionEnum direction, decimal speed, decimal time)
        {
            this.PathDirection = direction;
            this.Speed = speed;
            this.Time = time;
        }


        public enum DirectionEnum { Wait, Left, Forward, Right, Backward }
    }
}
