using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class DebugUserRecoverStaminaSingleTask : IHttpTask
{
	private byte[] postData;

	private Action<DebugUserRecoverStaminaSingleResponse> onSuccess;

	private Action<ErrorType, int, DebugUserRecoverStaminaSingleResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public DebugUserRecoverStaminaSingleTask(DebugUserRecoverStaminaSingleRequest request, Action<DebugUserRecoverStaminaSingleResponse> onSuccess, Action<ErrorType, int, DebugUserRecoverStaminaSingleResponse> onError)
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
