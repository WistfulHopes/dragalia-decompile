using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class QuestSetQuestClearPartyTask : IHttpTask
	{
		private byte[] postData;

		private Action<QuestSetQuestClearPartyResponse> onSuccess;

		private Action<ErrorType, int, QuestSetQuestClearPartyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public QuestSetQuestClearPartyTask(QuestSetQuestClearPartyRequest request, Action<QuestSetQuestClearPartyResponse> onSuccess, Action<ErrorType, int, QuestSetQuestClearPartyResponse> onError)
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
}