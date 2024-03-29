﻿namespace HANDMIsTestSuite
{
    public enum ControlModes
    {
        BreathIntensity,
        GazePointXRaw,
        GazePointXSmooth,
        GazePointY,
        HeadPitch,
        HeadYaw,
        HeadRoll,
        HeadVelocity,
        MouseX,
        MouseY,
        None
    }

    static class ControlModesMethods
    {
        public static ControlDirection GetDirection(this ControlModes controlMode)
        {
            switch (controlMode)
            {
                case ControlModes.BreathIntensity:
                    return ControlDirection.X;
                case ControlModes.GazePointXRaw:
                    return ControlDirection.X;
                case ControlModes.GazePointXSmooth:
                    return ControlDirection.X;
                case ControlModes.GazePointY:
                    return ControlDirection.Y;
                case ControlModes.HeadPitch:
                    return ControlDirection.X;
                case ControlModes.HeadYaw:
                    return ControlDirection.X;
                case ControlModes.HeadRoll:
                    return ControlDirection.X;
                case ControlModes.HeadVelocity:
                    return ControlDirection.X;
                case ControlModes.MouseX:
                    return ControlDirection.X;
                case ControlModes.MouseY:
                    return ControlDirection.Y;
                default:
                    return ControlDirection.X;
            }
        }
    }

    public enum ControlDirection
    {
        X,
        Y
    }
}
