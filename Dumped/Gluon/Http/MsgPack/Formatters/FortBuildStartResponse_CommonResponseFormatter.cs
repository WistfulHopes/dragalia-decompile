using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FortBuildStartResponse_CommonResponseFormatter : IMessagePackFormatter<FortBuildStartResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FortBuildStartResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FortBuildStartResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
