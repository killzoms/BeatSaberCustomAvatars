using System;

namespace CustomAvatar.Tracking
{
    internal class TrackedDeviceTypeAttribute : Attribute
    {
        public string[] Names { get; set; }

        public TrackedDeviceTypeAttribute(params string[] names)
        {
            Names = names;
        }
    }

    internal enum TrackedDeviceType
    {
        [TrackedDeviceType("")] Unknown,
        [TrackedDeviceType("vive")] ViveHeadset,
        [TrackedDeviceType("knuckles")] ValveIndexController,
        [TrackedDeviceType("vive_tracker", "kinect_device")] Tracker,
        [TrackedDeviceType("vive_tracker_handed")] HeldInHand,
        [TrackedDeviceType("vive_tracker_left_foot", "kinect_device_left_foot")] LeftFoot,
        [TrackedDeviceType("vive_tracker_right_foot", "kinect_device_right_foot")] RightFoot,
        [TrackedDeviceType("vive_tracker_left_shoulder")] LeftShoulder,
        [TrackedDeviceType("vive_tracker_right_shoulder")] RightShoulder,
        [TrackedDeviceType("vive_tracker_waist", "kinect_device_waist")] Waist,
        [TrackedDeviceType("vive_tracker_chest")] Chest,
        [TrackedDeviceType("vive_tracker_camera")] Camera,
        [TrackedDeviceType("vive_tracker_keyboard")] Keyboard
    }
}
