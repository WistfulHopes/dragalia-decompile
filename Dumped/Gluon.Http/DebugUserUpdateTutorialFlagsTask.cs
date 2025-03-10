using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class DebugUserUpdateTutorialFlagsTask : IHttpTask
{
	private byte[] postData;

	private Action<DebugUserUpdateTutorialFlagsResponse> onSuccess;

	private Action<ErrorType, int, DebugUserUpdateTutorialFlagsResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public DebugUserUpdateTutorialFlagsTask(DebugUserUpdateTutorialFlagsRequest request, Action<DebugUserUpdateTutorialFlagsResponse> onSuccess, Action<ErrorType, int, DebugUserUpdateTutorialFlagsResponse> onError)
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
