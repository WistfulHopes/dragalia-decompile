using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class DebugDmodeUpdateDmodeFloorSkipCountTask : IHttpTask
{
	private byte[] postData;

	private Action<DebugDmodeUpdateDmodeFloorSkipCountResponse> onSuccess;

	private Action<ErrorType, int, DebugDmodeUpdateDmodeFloorSkipCountResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public DebugDmodeUpdateDmodeFloorSkipCountTask(DebugDmodeUpdateDmodeFloorSkipCountRequest request, Action<DebugDmodeUpdateDmodeFloorSkipCountResponse> onSuccess, Action<ErrorType, int, DebugDmodeUpdateDmodeFloorSkipCountResponse> onError)
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
