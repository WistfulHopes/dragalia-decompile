using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaAwakeTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaAwakeResponse> onSuccess;

		private Action<ErrorType, int, CharaAwakeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaAwakeTask(CharaAwakeRequest request, Action<CharaAwakeResponse> onSuccess, Action<ErrorType, int, CharaAwakeResponse> onError)
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