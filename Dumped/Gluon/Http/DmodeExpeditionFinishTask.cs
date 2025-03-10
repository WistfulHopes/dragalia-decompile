using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeExpeditionFinishTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeExpeditionFinishResponse> onSuccess;

		private Action<ErrorType, int, DmodeExpeditionFinishResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeExpeditionFinishTask(DmodeExpeditionFinishRequest request, Action<DmodeExpeditionFinishResponse> onSuccess, Action<ErrorType, int, DmodeExpeditionFinishResponse> onError)
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
