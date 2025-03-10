using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class CombatEventReceiveEventLocationRewardTask : IHttpTask
{
	private byte[] postData;

	private Action<CombatEventReceiveEventLocationRewardResponse> onSuccess;

	private Action<ErrorType, int, CombatEventReceiveEventLocationRewardResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public CombatEventReceiveEventLocationRewardTask(CombatEventReceiveEventLocationRewardRequest request, Action<CombatEventReceiveEventLocationRewardResponse> onSuccess, Action<ErrorType, int, CombatEventReceiveEventLocationRewardResponse> onError)
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
