// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is used to get information about a specific input device.
	/// </summary>
	public class AudioOutputDeviceInfo : ISettable
	{
		/// <summary>
		/// True if this is the default audio input device in the system.
		/// </summary>
		public bool DefaultDevice { get; set; }

		/// <summary>
		/// The persistent unique id of the device.
		/// </summary>
		public string DeviceId { get; set; }

		/// <summary>
		/// The name of the device
		/// </summary>
		public string DeviceName { get; set; }

		internal void Set(AudioOutputDeviceInfoInternal? other)
		{
			if (other != null)
			{
				DefaultDevice = other.Value.DefaultDevice;
				DeviceId = other.Value.DeviceId;
				DeviceName = other.Value.DeviceName;
			}
		}

		public void Set(object other)
		{
			Set(other as AudioOutputDeviceInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AudioOutputDeviceInfoInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private int m_DefaultDevice;
		private System.IntPtr m_DeviceId;
		private System.IntPtr m_DeviceName;

		public bool DefaultDevice
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_DefaultDevice, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_DefaultDevice, value);
			}
		}

		public string DeviceId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_DeviceId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_DeviceId, value);
			}
		}

		public string DeviceName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_DeviceName, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_DeviceName, value);
			}
		}

		public void Set(AudioOutputDeviceInfo other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAudioInterface.AudiooutputdeviceinfoApiLatest;
				DefaultDevice = other.DefaultDevice;
				DeviceId = other.DeviceId;
				DeviceName = other.DeviceName;
			}
		}

		public void Set(object other)
		{
			Set(other as AudioOutputDeviceInfo);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_DeviceId);
			Helper.TryMarshalDispose(ref m_DeviceName);
		}
	}
}