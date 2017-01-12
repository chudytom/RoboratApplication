using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RatClientApplication
{
    public class OutgoingMessage
    {
        public int mode;                   //# 0 - manual # 1 - automatic # 2 - random
        public Speed speed;
        public Camera camera;
        public Pheromones pheromones;
        public Ultrasound ultrasound;

        public OutgoingMessage()
        {
            speed = new Speed();
            camera = new Camera();
            pheromones = new Pheromones();
            ultrasound = new Ultrasound();
        }

        public OutgoingMessage(int mode, Speed speed, Camera camera, Pheromones pheromones, Ultrasound ultrasound)
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
        public bool panic;             //: #bool # true to stop
        public int linear;             //: #int !! od -100 do 100 !!
        public int angular;            //: #int !! od -100 do 100 !!

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
        public CameraAddress address;

        public Camera() { address = new CameraAddress(); }
        public Camera(bool shouldStream, CameraAddress outgoingCameraAddress)
        {
            this.should_stream = shouldStream;
            this.address = outgoingCameraAddress;
        }
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
    public class Pheromones
    {
        public float stress_pheromone_volume_out;

        public Pheromones() { }
        public Pheromones(float stress_pheromone_volume_out)
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

    public class IncomingMessage
    {
        public string diagnostics;
        public int mode;                   //: tryb #int # 0 - manual # 1 - automatic # 2 - random
        public Battery_state battery_state;
        public IncomingPheromones incoming_pheromones;
        private string incomingDiagnostics;
        private int incomingMode;
        private Battery_state incomingBattery_state;

        public IncomingMessage()
        {
            battery_state = new Battery_state(0);
            incoming_pheromones = new IncomingPheromones(0);
        }
        public IncomingMessage(string incomingDiagnostics, int incomingMode, Battery_state incomingBattery_state, IncomingPheromones incoming_pheromones)
        {
            this.diagnostics = incomingDiagnostics;
            this.mode = incomingMode;
            this.battery_state = incomingBattery_state;
            this.incoming_pheromones = incoming_pheromones;
        }
    }
    public class Battery_state
    {
        public int percentage;

        public Battery_state(int percentage)
        {
            this.percentage = percentage;
        }
    }
    public class IncomingPheromones         //Here is a difference in naming + Everywhere class name begins with a capital letter
    {
        public float stress_pheromone_volume_left;

        public IncomingPheromones(float stress_pheromone_volume_left)
        {
            this.stress_pheromone_volume_left = stress_pheromone_volume_left;
        }
    }
}
