using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlimDX.DirectInput;


namespace Snek_Game
{
    public class ManuInput
    {
        private DirectInput input = new DirectInput();
        private Joystick stick;
        public int xval { get; private set; }
        public int yval { get; private set; }
        public int zval { get; private set; }
        public bool[] buttons { get; private set; }
        public Joystick[] GetSticks()
        {
            List<Joystick> sticks = new List<Joystick>();
            foreach (DeviceInstance device in input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    stick = new Joystick(input, device.InstanceGuid);
                    stick.Acquire();
                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                        {
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                        }
                    }
                    sticks.Add(stick);
                }
                catch (DirectInputException)
                {

                }
            }

            return sticks.ToArray();
        }

        public void stickHandle(Joystick stick, int id)
        {
            JoystickState state = new JoystickState();
            state = stick.GetCurrentState();

            xval = state.X;
            yval = state.Y;
            zval = state.Z;

            buttons = state.GetButtons();
        }
    }
}
