using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class BattleRoyalEventEntryTask : IHttpTask
{
	private byte[] postData;

	private Action<BattleRoyalEventEntryResponse> onSuccess;

	private Action<ErrorType, int, BattleRoyalEventEntryResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public BattleRoyalEventEntryTask(BattleRoyalEventEntryRequest request, Action<BattleRoyalEventEntryResponse> onSuccess, Action<ErrorType, int, BattleRoyalEventEntryResponse> onError)
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
