using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class RaidEventReceiveRaidPointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<RaidEventReceiveRaidPointRewardResponse> onSuccess;

		private Action<ErrorType, int, RaidEventReceiveRaidPointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public RaidEventReceiveRaidPointRewardTask(RaidEventReceiveRaidPointRewardRequest request, Action<RaidEventReceiveRaidPointRewardResponse> onSuccess, Action<ErrorType, int, RaidEventReceiveRaidPointRewardResponse> onError)
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
