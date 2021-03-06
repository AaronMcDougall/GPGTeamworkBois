// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Intermediate data needed to complete the <see cref="LoginCredentialType.DeviceCode" /> and <see cref="LoginCredentialType.ExternalAuth" /> login flows, returned by <see cref="LoginCallbackInfo" />.
	/// The data inside should be exposed to the user for entry on a secondary device.
	/// All data must be copied out before the completion of this callback.
	/// </summary>
	public class PinGrantInfo : ISettable
	{
		/// <summary>
		/// Code the user must input on an external device to activate the login
		/// </summary>
		public string UserCode { get; set; }

		/// <summary>
		/// The end-user verification URI. Users can be asked to manually type this into their browser.
		/// </summary>
		public string VerificationURI { get; set; }

		/// <summary>
		/// Time the user has, in seconds, to complete the process or else timeout
		/// </summary>
		public int ExpiresIn { get; set; }

		/// <summary>
		/// A verification URI that includes the user code. Useful for non-textual transmission.
		/// </summary>
		public string VerificationURIComplete { get; set; }

		internal void Set(PinGrantInfoInternal? other)
		{
			if (other != null)
			{
				UserCode = other.Value.UserCode;
				VerificationURI = other.Value.VerificationURI;
				ExpiresIn = other.Value.ExpiresIn;
				VerificationURIComplete = other.Value.VerificationURIComplete;
			}
		}

		public void Set(object other)
		{
			Set(other as PinGrantInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PinGrantInfoInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_UserCode;
		private System.IntPtr m_VerificationURI;
		private int m_ExpiresIn;
		private System.IntPtr m_VerificationURIComplete;

		public string UserCode
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_UserCode, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_UserCode, value);
			}
		}

		public string VerificationURI
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_VerificationURI, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_VerificationURI, value);
			}
		}

		public int ExpiresIn
		{
			get
			{
				return m_ExpiresIn;
			}

			set
			{
				m_ExpiresIn = value;
			}
		}

		public string VerificationURIComplete
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_VerificationURIComplete, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_VerificationURIComplete, value);
			}
		}

		public void Set(PinGrantInfo other)
		{
			if (other != null)
			{
				m_ApiVersion = AuthInterface.PingrantinfoApiLatest;
				UserCode = other.UserCode;
				VerificationURI = other.VerificationURI;
				ExpiresIn = other.ExpiresIn;
				VerificationURIComplete = other.VerificationURIComplete;
			}
		}

		public void Set(object other)
		{
			Set(other as PinGrantInfo);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_UserCode);
			Helper.TryMarshalDispose(ref m_VerificationURI);
			Helper.TryMarshalDispose(ref m_VerificationURIComplete);
		}
	}
}