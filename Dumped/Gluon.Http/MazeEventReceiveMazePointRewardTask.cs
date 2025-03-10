using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class MazeEventReceiveMazePointRewardTask : IHttpTask
{
	private byte[] postData;

	private Action<MazeEventReceiveMazePointRewardResponse> onSuccess;

	private Action<ErrorType, int, MazeEventReceiveMazePointRewardResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public MazeEventReceiveMazePointRewardTask(MazeEventReceiveMazePointRewardRequest request, Action<MazeEventReceiveMazePointRewardResponse> onSuccess, Action<ErrorType, int, MazeEventReceiveMazePointRewardResponse> onError)
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
