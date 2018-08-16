using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;

namespace RatClientApplication
{
    #region ComputerToRobot

    public class ComputerToRoboRatMessage
    {
        public int mode;                   //# 0 - manual # 1 - automatic # 2 - random
        public Speed speed;
        public Camera camera;
        public PheromonesVolumeToRelease pheromones;
        public Ultrasound ultrasound;

        public ComputerToRoboRatMessage()
        {
            speed = new Speed();
            camera = new Camera();
            pheromones = new PheromonesVolumeToRelease();
            ultrasound = new Ultrasound();
        }

        public ComputerToRoboRatMessage(int mode, Speed speed, Camera camera, PheromonesVolumeToRelease pheromones, Ultrasound ultrasound)
        {
            this.mode = mode;
            this.speed = speed;
            this.camera = camera;
            this.pheromones = pheromones;
            this.ultrasound = ultrasound;
        }
    }
    public class Speed
    {
        public bool panic;
        public int linear;
        public int angular;

        public Speed() { }
        public Speed(bool panic, int linearSpeed, int rotationSpeed)
        {
            this.panic = panic;
            this.linear = linearSpeed;
            this.angular = rotationSpeed;
        }
    }
    public class Camera
    {
        public bool should_stream;
        public DetectedPosition detected_position;
        public CameraAddress address;
        //public DetectionCalibration detection_calibration;

        //public Camera() { address = new CameraAddress(); detection_calibration = new DetectionCalibration(); }
        public Camera() { address = new CameraAddress(); detected_position = new DetectedPosition(); }
        public Camera(bool shouldStream, CameraAddress outgoingCameraAddress)
        {
            this.should_stream = shouldStream;
            this.address = outgoingCameraAddress;
        }
    }

    public class DetectedPosition
    {
        public DetectedPosition() { }
        public DetectedPosition(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
    }

    //public class DetectionCalibration
    //{
    //    public DetectionCalibration()
    //    {
    //        hue = new Hue() { min = 21, max = 28 };
    //        saturation = new Saturation() { min = 102, max = 140 };
    //        value = new Value() { min = 151, max = 210 };
    //    }

    //    public Hue hue;
    //    public Saturation saturation;
    //    public Value value;
    //}

    public class Hue
    {
        public int min;
        public int max;
    }

    public class Saturation
    {
        public int min;
        public int max;
    }

    public class Value
    {
        public int min;
        public int max;
    }

    public class CameraAddress
    {
        public string ip;
        public int port;

        public CameraAddress() { }
        public CameraAddress(string ipAddress, int portNumber)
        {
            this.ip = ipAddress;
            this.port = portNumber;
        }
    }

    public class PheromonesVolumeToRelease
    {
        public float stress_pheromone_volume_out;

        public PheromonesVolumeToRelease() { }
        public PheromonesVolumeToRelease(float stress_pheromone_volume_out)
        {
            this.stress_pheromone_volume_out = stress_pheromone_volume_out;
        }
    }
    public class Ultrasound
    {
        public int frequency;

        public Ultrasound() { }
        public Ultrasound(int frequency)
        {
            this.frequency = frequency;
        }
    }
    #endregion

    #region RobotToComputer

    public class RoboRatToComputerMessage
    {
        public string diagnostics;
        public int mode;
        public BatteryState battery_state;
        public PheromonesVolumeLeft incoming_pheromones;

        public RoboRatToComputerMessage()
        {
            battery_state = new BatteryState(0);
            incoming_pheromones = new PheromonesVolumeLeft(0);
        }
        public RoboRatToComputerMessage(string incomingDiagnostics, int incomingMode, BatteryState incomingBattery_state, PheromonesVolumeLeft incoming_pheromones)
        {
            this.diagnostics = incomingDiagnostics;
            this.mode = incomingMode;
            this.battery_state = incomingBattery_state;
            this.incoming_pheromones = incoming_pheromones;
        }
    }
    public class BatteryState
    {
        public int percentage;

        public BatteryState(int percentage)
        {
            this.percentage = percentage;
        }
    }
    public class PheromonesVolumeLeft
    {
        public float stress_pheromone_volume_left;

        public PheromonesVolumeLeft(float stress_pheromone_volume_left)
        {
            this.stress_pheromone_volume_left = stress_pheromone_volume_left;
        }
    }
    #endregion
}
