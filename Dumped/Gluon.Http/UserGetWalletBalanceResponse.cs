namespace Gluon.Http;

public class UserGetWalletBalanceResponse : ResponseCommon
{
	public class CommonResponse
	{
		public WalletBalance wallet_balance;
	}

	public CommonResponse data;
}
