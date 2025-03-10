using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http;

public class ShopGetDreamSelectUnitListTask : IHttpTask
{
	private byte[] postData;

	private Action<ShopGetDreamSelectUnitListResponse> onSuccess;

	private Action<ErrorType, int, ShopGetDreamSelectUnitListResponse> onError;

	private Dictionary<string, string> headers;

	private IWebRequest request;

	public int CacheTime => default(int);

	public bool IsEncrypt => default(bool);

	public ShopGetDreamSelectUnitListTask(ShopGetDreamSelectUnitListRequest request, Action<ShopGetDreamSelectUnitListResponse> onSuccess, Action<ErrorType, int, ShopGetDreamSelectUnitListResponse> onError)
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
