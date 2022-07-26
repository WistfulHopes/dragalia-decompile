using System;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;

namespace Gluon;

public static class ServiceSunsetChecker
{
	public enum ServiceState
	{
		GameServiceAvailable = 1,
		DuringRefunding,
		RefundPeriodEnd
	}

	public static readonly DateTime serviceSunsetTime;

	public static bool IsRequestFinished
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool IsRequestSucceeded
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static ServiceState serviceState
	{
		[CompilerGenerated]
		get
		{
			return default(ServiceState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static void RequestCheckSilently()
	{
	}

	public static void RequestCheck()
	{
	}

	private static void OnSuccess(ToolGetServiceStatusResponse res)
	{
	}

	private static void OnError(ErrorType errorType, int errorCode)
	{
	}
}
