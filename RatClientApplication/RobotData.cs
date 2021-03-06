﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatClientApplication
{
    class RobotData
    {
        public int LinearSpeed1 { get; set; }
        public int AngularSpeed1 { get; set; }
        public int LinearDirection { get; set; }
        public int RotationDirection { get; set; }
        public int LinearSpeed
        {
            get { return LinearSpeed1 * LinearDirection; }
        }
        public int RotationSpeed
        {
            get { return AngularSpeed1 * RotationDirection; }
        }
        public RobotMode Mode { get; set; }
        public enum RobotMode
        {
            Manual, Automatic, Random
        }
    }
}
