using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions
{

    class DirectionData
    {
        public int LinearSpeed1
        {
            get; set;       
        }
        public int AngularSpeed1
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
            get { return LinearSpeed1 * LinearDirection; }
        }
        public int RotationSpeed
        {
            get { return AngularSpeed1 * RotationDirection; }
        }
    }
}
