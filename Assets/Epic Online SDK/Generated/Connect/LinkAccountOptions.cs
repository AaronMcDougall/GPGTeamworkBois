// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Input parameters for the <see cref="ConnectInterface.LinkAccount" /> function.
	/// </summary>
	public class LinkAccountOptions
	{
		/// <summary>
		/// The existing logged in product user for which to link the external account described by the continuance token.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Continuance token from previous call to <see cref="ConnectInterface.Login" />.
		/// </summary>
		public ContinuanceToken ContinuanceToken { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LinkAccountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_ContinuanceToken;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ContinuanceToken ContinuanceToken
		{
			set
			{
				Helper.TryMarshalSet(ref m_ContinuanceToken, value);
			}
		}

		public void Set(LinkAccountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ConnectInterface.LinkaccountApiLatest;
				LocalUserId = other.LocalUserId;
				ContinuanceToken = other.ContinuanceToken;
			}
		}

		public void Set(object other)
		{
			Set(other as LinkAccountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_ContinuanceToken);
		}
	}
}