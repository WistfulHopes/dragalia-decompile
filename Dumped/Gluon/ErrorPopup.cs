using System;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Http;

namespace Gluon;

public class ErrorPopup : CommonPopup
{
	public static bool isPopupOpened;

	private static string GetTitle(int resultCode)
	{
		return null;
	}

	private static string GetMessage(int resultCode)
	{
		return null;
	}

	public static ErrorPopup CreateNetworkError(ErrorType errorType, int resultCode, [Optional] Action onClosedCallback)
	{
		return null;
	}

	public static void CreateTitleMaintenancePopup()
	{
	}

	private static void OnMaintenanceGetTextSuccess(MaintenanceGetTextResponse res)
	{
	}

	private static void OnOnMaintenanceGetTextError(ErrorType errorType, int resultCode)
	{
	}

	private static void ShowCommonMaintenancePopup()
	{
	}

	private void OnClose(ErrorType errorType, int resultCode, Action onClosedCallback)
	{
	}

	protected override void OnDestroy()
	{
	}
}
