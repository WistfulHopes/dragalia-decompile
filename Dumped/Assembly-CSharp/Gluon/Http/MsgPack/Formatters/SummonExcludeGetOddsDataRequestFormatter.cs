﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SummonExcludeGetOddsDataRequestFormatter : IMessagePackFormatter<SummonExcludeGetOddsDataRequest>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public SummonExcludeGetOddsDataRequestFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, SummonExcludeGetOddsDataRequest value, IFormatterResolver formatterResolver);
		public SummonExcludeGetOddsDataRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}