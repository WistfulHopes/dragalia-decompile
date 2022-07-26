using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class ToolGetServiceStatusTask : IHttpTask
{
	private byte[] postData;

	private Action<ToolGetServiceStatusResponse> onSuccess;

	private Action<ErrorType, int, ToolGetServiceStatusResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public ToolGetServiceStatusTask(ToolGetServiceStatusRequest request, Action<ToolGetServiceStatusResponse> onSuccess, Action<ErrorType, int, ToolGetServiceStatusResponse> onError)
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
