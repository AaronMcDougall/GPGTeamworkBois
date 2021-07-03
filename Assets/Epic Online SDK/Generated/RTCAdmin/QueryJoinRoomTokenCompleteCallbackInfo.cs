// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAdmin
{
	/// <summary>
	/// Data containing the result information for a query join room token request.
	/// </summary>
	public class QueryJoinRoomTokenCompleteCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="RTCAdminInterface.QueryJoinRoomToken" />.
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// Room the request was made for.
		/// </summary>
		public string RoomName { get; private set; }

		/// <summary>
		/// URL passed to backend to join room.
		/// </summary>
		public string ClientBaseUrl { get; private set; }

		/// <summary>
		/// If the query completed successfully, this contains an identifier that should be used to retrieve the tokens.
		/// This identifier is only valid for the duration of the callback.
		/// <seealso cref="RTCAdminInterface.CopyUserTokenByIndex" />
		/// <seealso cref="RTCAdminInterface.CopyUserTokenByUserId" />
		/// </summary>
		public uint QueryId { get; private set; }

		/// <summary>
		/// How many token received as result of the query
		/// </summary>
		public uint TokenCount { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(QueryJoinRoomTokenCompleteCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				RoomName = other.Value.RoomName;
				ClientBaseUrl = other.Value.ClientBaseUrl;
				QueryId = other.Value.QueryId;
				TokenCount = other.Value.TokenCount;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryJoinRoomTokenCompleteCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryJoinRoomTokenCompleteCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_ClientBaseUrl;
		private uint m_QueryId;
		private uint m_TokenCount;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public string RoomName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_RoomName, out value);
				return value;
			}
		}

		public string ClientBaseUrl
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_ClientBaseUrl, out value);
				return value;
			}
		}

		public uint QueryId
		{
			get
			{
				return m_QueryId;
			}
		}

		public uint TokenCount
		{
			get
			{
				return m_TokenCount;
			}
		}
	}
}