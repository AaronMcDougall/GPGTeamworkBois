// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is used to call <see cref="RTCAudioInterface.AddNotifyAudioBeforeRender" />.
	/// </summary>
	public class AddNotifyAudioBeforeRenderOptions
	{
		/// <summary>
		/// The Product User ID of the user trying to request this operation.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room this event is registered on.
		/// </summary>
		public string RoomName { get; set; }

		/// <summary>
		/// Mixed audio or unmixed audio.
		/// For unmixed audio notifications it is not supported to modify the samples in the callback.
		/// </summary>
		public bool UnmixedAudio { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyAudioBeforeRenderOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private int m_UnmixedAudio;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string RoomName
		{
			set
			{
				Helper.TryMarshalSet(ref m_RoomName, value);
			}
		}

		public bool UnmixedAudio
		{
			set
			{
				Helper.TryMarshalSet(ref m_UnmixedAudio, value);
			}
		}

		public void Set(AddNotifyAudioBeforeRenderOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAudioInterface.AddnotifyaudiobeforerenderApiLatest;
				LocalUserId = other.LocalUserId;
				RoomName = other.RoomName;
				UnmixedAudio = other.UnmixedAudio;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyAudioBeforeRenderOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_RoomName);
		}
	}
}