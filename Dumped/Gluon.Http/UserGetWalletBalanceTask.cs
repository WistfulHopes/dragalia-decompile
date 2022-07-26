using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class UserGetWalletBalanceTask : IHttpTask
{
	private byte[] postData;

	private Action<UserGetWalletBalanceResponse> onSuccess;

	private Action<ErrorType, int, UserGetWalletBalanceResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public UserGetWalletBalanceTask(UserGetWalletBalanceRequest request, Action<UserGetWalletBalanceResponse> onSuccess, Action<ErrorType, int, UserGetWalletBalanceResponse> onError)
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
