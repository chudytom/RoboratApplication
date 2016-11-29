using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions
{

    class DirectionData
    {
        public int Speed
        {
            get; set;
        }
        public int LinearDirection
        {
            get;set;
        }
        public int RotationDirection
        {
            get; set;
        }
        public int LinearSpeed
        {
            get { return Speed * LinearDirection; }
        }
        public int RotationSpeed
        {
            get { return Speed * RotationDirection; }
        }
    }
}
