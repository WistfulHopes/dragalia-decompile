using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class QuestSearchQuestClearPartyCharaTask : IHttpTask
{
	private byte[] postData;

	private Action<QuestSearchQuestClearPartyCharaResponse> onSuccess;

	private Action<ErrorType, int, QuestSearchQuestClearPartyCharaResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public QuestSearchQuestClearPartyCharaTask(QuestSearchQuestClearPartyCharaRequest request, Action<QuestSearchQuestClearPartyCharaResponse> onSuccess, Action<ErrorType, int, QuestSearchQuestClearPartyCharaResponse> onError)
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
