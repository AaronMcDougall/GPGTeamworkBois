// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	public class IsRTCRoomConnectedOptions
	{
		/// <summary>
		/// The ID of the lobby to get the RTC Room name for
		/// </summary>
		public string LobbyId { get; set; }

		/// <summary>
		/// The Product User ID of the local user in the lobby
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct IsRTCRoomConnectedOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LobbyId;
		private System.IntPtr m_LocalUserId;

		public string LobbyId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LobbyId, value);
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(IsRTCRoomConnectedOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyInterface.IsrtcroomconnectedApiLatest;
				LobbyId = other.LobbyId;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as IsRTCRoomConnectedOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LobbyId);
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}