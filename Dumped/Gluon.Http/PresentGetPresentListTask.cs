using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class PresentGetPresentListTask : IHttpTask
{
	private byte[] postData;

	private Action<PresentGetPresentListResponse> onSuccess;

	private Action<ErrorType, int, PresentGetPresentListResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public PresentGetPresentListTask(PresentGetPresentListRequest request, Action<PresentGetPresentListResponse> onSuccess, Action<ErrorType, int, PresentGetPresentListResponse> onError)
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
