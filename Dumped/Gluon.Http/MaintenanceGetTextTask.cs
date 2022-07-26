using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class MaintenanceGetTextTask : IHttpTask
{
	private byte[] postData;

	private Action<MaintenanceGetTextResponse> onSuccess;

	private Action<ErrorType, int, MaintenanceGetTextResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public MaintenanceGetTextTask(MaintenanceGetTextRequest request, Action<MaintenanceGetTextResponse> onSuccess, Action<ErrorType, int, MaintenanceGetTextResponse> onError)
	{
	}

	public void SetHeader(string key, string value)
	{
	}

	public IWebRequest Send(string url)
	{
		return null;
	}

	public bool Deserialize(byte[] body)
	{
		return default(bool);
	}

	public void OnError(ErrorType errorType, int resultCode)
	{
	}
}
