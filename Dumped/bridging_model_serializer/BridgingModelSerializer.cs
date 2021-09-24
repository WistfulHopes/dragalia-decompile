﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using google.protobuf;
using NPF.ProtoBuf;
using ProtoBuf;
using ProtoBuf.Meta;

// Image 46: bridging_model_serializer.dll - Assembly: bridging_model_serializer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public sealed class BridgingModelSerializer : TypeModel
{
	// Fields
	private static readonly Type[] knownTypes;

	// Constructors
	public BridgingModelSerializer();
	static BridgingModelSerializer();

	// Methods
	private static void Write(NPFError param_00007744, ProtoWriter param_00007745);
	private static NPFError Read(NPFError param_00007746, ProtoReader param_00007747);
	private static void Write(NPFError.ErrorType param_00007748, ProtoWriter param_00007749);
	private static NPFError.ErrorType Read(NPFError.ErrorType param_0000774a, ProtoReader param_0000774b);
	private static void Write(ProfanityWord param_0000774c, ProtoWriter param_0000774d);
	private static ProfanityWord Read(ProfanityWord param_0000774e, ProtoReader param_0000774f);
	private static void Write(ProfanityWord.ProfanityCheckStatus param_00007750, ProtoWriter param_00007751);
	private static ProfanityWord.ProfanityCheckStatus Read(ProfanityWord.ProfanityCheckStatus param_00007752, ProtoReader param_00007753);
	private static void Write(ProfanityWord.ProfanityDictionaryType param_00007754, ProtoWriter param_00007755);
	private static ProfanityWord.ProfanityDictionaryType Read(ProfanityWord.ProfanityDictionaryType param_00007756, ProtoReader param_00007757);
	private static void Write(ProfanityWordList param_00007758, ProtoWriter param_00007759);
	private static ProfanityWordList Read(ProfanityWordList param_0000775a, ProtoReader param_0000775b);
	private static void Write(SubscriptionTransaction param_0000775c, ProtoWriter param_0000775d);
	private static SubscriptionTransaction Read(SubscriptionTransaction param_0000775e, ProtoReader param_0000775f);
	private static void Write(SubscriptionTransaction.SubscriptionTransactionState param_00007760, ProtoWriter param_00007761);
	private static SubscriptionTransaction.SubscriptionTransactionState Read(SubscriptionTransaction.SubscriptionTransactionState param_00007762, ProtoReader param_00007763);
	private static void Write(SubscriptionTransactionList param_00007764, ProtoWriter param_00007765);
	private static SubscriptionTransactionList Read(SubscriptionTransactionList param_00007766, ProtoReader param_00007767);
	protected new int GetKeyImpl(Type param_00007768);
	protected internal new bool SerializeDateTimeKind();
	protected internal new void Serialize(int param_00007769, object param_0000776a, ProtoWriter param_0000776b);
	protected internal new object Deserialize(int param_0000776c, object param_0000776d, ProtoReader param_0000776e);
	static object _2(object param_0000776f, ProtoReader param_00007770);
	static object _4(object param_00007771, ProtoReader param_00007772);
	static object _5(object param_00007773, ProtoReader param_00007774);
	static object _8(object param_00007775, ProtoReader param_00007776);

	// Extension methods
	private static void Write(this google.protobuf.Empty param_00007740, ProtoWriter param_00007741);
	private static google.protobuf.Empty Read(this google.protobuf.Empty param_00007742, ProtoReader param_00007743);
}

