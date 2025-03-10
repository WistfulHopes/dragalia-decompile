using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class MissionReceiveMemoryEventRewardTask : IHttpTask
{
	private byte[] postData;

	private Action<MissionReceiveMemoryEventRewardResponse> onSuccess;

	private Action<ErrorType, int, MissionReceiveMemoryEventRewardResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public MissionReceiveMemoryEventRewardTask(MissionReceiveMemoryEventRewardRequest request, Action<MissionReceiveMemoryEventRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveMemoryEventRewardResponse> onError)
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
