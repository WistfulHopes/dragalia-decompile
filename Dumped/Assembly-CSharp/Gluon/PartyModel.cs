﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyModel : SingletonInBaseMonoBehaviour<Gluon.PartyModel>
	{
		// Fields
		public const int numOfCharactersInParty = 4;
		public const int maxPartyCountInGroup = 6;
		public const int maxPartyGroupCount = 9;
		public const string prefsKeyWeaponIconOrList = "Party/WeaponListViewIconOrList";
		public const string prefsKeyCrestIconOrList = "Party/CrestListViewIconOrList";
		public static PartySceneState nowSceneState;
		public static PartySceneState prevSceneState;
		public PartySceneUnitStatusMode unitStatusMode;
		public PartySceneUnitStatusMode endStatusMode;
		private static PartyList _clearPartyData;
		private static PartyList _clearPartyData2;
		public static EmptyQuestClearUnitData[] clearPartyLostUnitData;
		[CompilerGenerated]
		private static bool _isCurrentClearParty_k__BackingField;
		[CompilerGenerated]
		private static bool _isCurrentClearParty2_k__BackingField;
		[CompilerGenerated]
		private static QuestPrepareData[] _orderPartyData_k__BackingField;
		[CompilerGenerated]
		private static bool _isCurrentOrderParty_k__BackingField;
		private static PartyList fromMatchingPartyData;
		private List<PartyList> partyData;
		public EquipMode equipMode;
		private int _currentPartyGroupIndex;
		public int _currentPartyIndexInGroup;
		public int currentPartySwitchIndex;
		public int currentCharacterIndexInParty;
		public int currentCharacterId;
		private PartyList _oldPartyData;
		public int oldCurrentPartyIndex;
		public int questId;
		[CompilerGenerated]
		private bool _isShowReloadPopup_k__BackingField;
		private Action onMainPartyNoSuccessCallBack;
		private StringBuilder partyErrorBuilder;
		private bool isEntrust;
		private ElementalType entrustElementalType;
		private ElementalType[,] elementPriorityMatrix;
		public const float autoPartyAtkWeight = 1f;
		public const float autoPartyDefWeight = 1f;
		public const float autoPartyHpWeight = 1f;
		private const int topPriority = 1;
		private const int normalPriority = 2;
		private const int bottomPriority = 3;
		public const int otherAbilityPriority = 99999;
		private const string prefsKeyPartySwitchIndex = "Party/PartySwitchIndex_{0}_{1}";
	
		// Properties
		public PartySceneUnitStatusMode nextUnitStatusMode { get; }
		public static PartyList clearPartyData { get; }
		public static PartyList clearPartyData2 { get; }
		public static bool isCurrentClearParty { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool isCurrentClearParty2 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static QuestPrepareData[] orderPartyData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool isCurrentOrderParty { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int partyCount { get; }
		public int currentPartyGroupIndex { get; set; }
		public int currentPartyIndexInGroup { get; set; }
		public int currentPartyIndex { get; set; }
		public int startPartyIndex { get; }
		public PartyList oldPartyData { get; }
		public bool isShowReloadPopup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int activeCharaId { get; set; }
		public int activeWeaponId { get; set; }
		public ulong activeDragonId { get; set; }
		public int activeType1Crest1Id { get; set; }
		public int activeType1Crest2Id { get; set; }
		public int activeType1Crest3Id { get; set; }
		public int activeType2Crest1Id { get; set; }
		public int activeType2Crest2Id { get; set; }
		public int activeType3Crest1Id { get; set; }
		public int activeType3Crest2Id { get; set; }
		public int activeWeaponSkinId { get; set; }
		public int activeSkill3CharaId { get; set; }
		public int activeSkill4CharaId { get; set; }
		public PartyList activePartyData { get; }
		public PartySettingList activeCharaData { get; }
	
		// Nested types
		public enum PartySceneUnitStatusMode
		{
			Basic = 0,
			Crest1 = 1,
			Crest2 = 2
		}
	
		public enum EquipMode
		{
			Dragon = 0,
			Weapon = 1,
			Amulet = 2,
			Skill3 = 3,
			Skill4 = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass131_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass131_0();
	
			// Methods
			internal void _ShowReloadPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass142_0
		{
			// Fields
			public EmptyQuestClearUnitPopup popup;
	
			// Constructors
			public __c__DisplayClass142_0();
	
			// Methods
			internal void _ShowEmptyQuestClearUnitPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass143_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass143_0();
	
			// Methods
			internal void _RequestSaveClearPartyMulti_b__0(QuestSetQuestClearPartyMultiResponse res);
		}
	
		[CompilerGenerated]
		private struct _RequestSaveClearPartyMulti_d__144 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<QuestGetQuestClearPartyMultiResponse> __t__builder;
			public int questId;
			private TaskAwaiter<QuestGetQuestClearPartyMultiResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass149_0
		{
			// Fields
			public List<AutoPartySortData> sortList;
	
			// Constructors
			public __c__DisplayClass149_0();
	
			// Methods
			internal void _AutoPartyCharaSelect_b__12();
			internal void _AutoPartyCharaSelect_b__13();
			internal void _AutoPartyCharaSelect_b__14();
			internal void _AutoPartyCharaSelect_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass149_1
		{
			// Fields
			public AutoPartySortData selected;
	
			// Constructors
			public __c__DisplayClass149_1();
	
			// Methods
			internal bool _AutoPartyCharaSelect_b__40(AutoPartySortData data);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<AutoPartySortData, int> __9__149_0;
			public static Func<AutoPartySortData, int> __9__149_1;
			public static Func<AutoPartySortData, ElementalType> __9__149_2;
			public static Func<AutoPartySortData, WeaponType> __9__149_3;
			public static Func<AutoPartySortData, int> __9__149_4;
			public static Func<AutoPartySortData, ulong> __9__149_5;
			public static Func<AutoPartySortData, int> __9__149_6;
			public static Func<AutoPartySortData, int> __9__149_7;
			public static Func<AutoPartySortData, ElementalType> __9__149_8;
			public static Func<AutoPartySortData, WeaponType> __9__149_9;
			public static Func<AutoPartySortData, int> __9__149_10;
			public static Func<AutoPartySortData, ulong> __9__149_11;
			public static Func<AutoPartySortData, int> __9__149_16;
			public static Func<AutoPartySortData, int> __9__149_17;
			public static Func<AutoPartySortData, ElementalType> __9__149_18;
			public static Func<AutoPartySortData, WeaponType> __9__149_19;
			public static Func<AutoPartySortData, int> __9__149_20;
			public static Func<AutoPartySortData, ulong> __9__149_21;
			public static Func<AutoPartySortData, int> __9__149_22;
			public static Func<AutoPartySortData, int> __9__149_23;
			public static Func<AutoPartySortData, ElementalType> __9__149_24;
			public static Func<AutoPartySortData, WeaponType> __9__149_25;
			public static Func<AutoPartySortData, int> __9__149_26;
			public static Func<AutoPartySortData, ulong> __9__149_27;
			public static Func<AutoPartySortData, int> __9__149_28;
			public static Func<AutoPartySortData, int> __9__149_29;
			public static Func<AutoPartySortData, ElementalType> __9__149_30;
			public static Func<AutoPartySortData, WeaponType> __9__149_31;
			public static Func<AutoPartySortData, int> __9__149_32;
			public static Func<AutoPartySortData, ulong> __9__149_33;
			public static Func<AutoPartySortData, int> __9__149_34;
			public static Func<AutoPartySortData, int> __9__149_35;
			public static Func<AutoPartySortData, ElementalType> __9__149_36;
			public static Func<AutoPartySortData, WeaponType> __9__149_37;
			public static Func<AutoPartySortData, int> __9__149_38;
			public static Func<AutoPartySortData, ulong> __9__149_39;
			public static Func<AutoPartySortData, int> __9__149_41;
			public static Func<AutoPartySortData, int> __9__149_42;
			public static Func<AutoPartySortData, ElementalType> __9__149_43;
			public static Func<AutoPartySortData, WeaponType> __9__149_44;
			public static Func<AutoPartySortData, int> __9__149_45;
			public static Func<AutoPartySortData, ulong> __9__149_46;
			public static Func<AutoPartySortData, int> __9__149_47;
			public static Func<AutoPartySortData, int> __9__149_48;
			public static Func<AutoPartySortData, int> __9__149_49;
			public static Func<AutoPartySortData, ElementalType> __9__149_50;
			public static Func<AutoPartySortData, WeaponType> __9__149_51;
			public static Func<AutoPartySortData, int> __9__149_52;
			public static Func<AutoPartySortData, ulong> __9__149_53;
			public static Func<AutoPartySortData, int> __9__149_54;
			public static Func<AutoPartySortData, int> __9__149_55;
			public static Func<AutoPartySortData, int> __9__149_56;
			public static Func<AutoPartySortData, ElementalType> __9__149_57;
			public static Func<AutoPartySortData, WeaponType> __9__149_58;
			public static Func<AutoPartySortData, int> __9__149_59;
			public static Func<AutoPartySortData, ulong> __9__149_60;
			public static Comparison<AutoPartySortData> __9__149_61;
			public static Comparison<AutoPartySortData> __9__149_62;
			public static Func<AutoPartySortData, int> __9__152_0;
			public static Func<AutoPartySortData, int> __9__152_1;
			public static Func<AutoPartySortData, int> __9__152_2;
			public static Func<AutoPartySortData, int> __9__152_3;
			public static Func<AutoPartySortData, int> __9__152_4;
			public static Func<AutoPartySortData, int> __9__152_5;
			public static Func<AutoPartySortData, int> __9__152_6;
			public static Func<AutoPartySortData, int> __9__152_7;
			public static Func<AutoPartySortData, int> __9__152_8;
			public static Func<AutoPartySortData, int> __9__173_0;
			public static Func<AutoPartySortData, int> __9__173_1;
			public static Func<AutoPartySortData, int> __9__173_2;
			public static Func<AutoPartySortData, ElementalType> __9__173_3;
			public static Func<AutoPartySortData, int> __9__173_4;
			public static Func<AutoPartySortData, int> __9__173_5;
			public static Func<AutoPartySortData, ulong> __9__173_6;
			public static Func<AutoPartySortData, int> __9__173_7;
			public static Func<AutoPartySortData, int> __9__173_8;
			public static Func<AutoPartySortData, int> __9__173_9;
			public static Func<AutoPartySortData, ElementalType> __9__173_10;
			public static Func<AutoPartySortData, int> __9__173_11;
			public static Func<AutoPartySortData, int> __9__173_12;
			public static Func<AutoPartySortData, ulong> __9__173_13;
			public static Func<AutoPartySortData, int> __9__173_14;
			public static Func<AutoPartySortData, int> __9__173_15;
			public static Func<AutoPartySortData, int> __9__173_16;
			public static Func<AutoPartySortData, ElementalType> __9__173_17;
			public static Func<AutoPartySortData, int> __9__173_18;
			public static Func<AutoPartySortData, int> __9__173_19;
			public static Func<AutoPartySortData, ulong> __9__173_20;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _AutoPartyCharaSelect_b__149_0(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_1(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_2(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_3(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_4(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_5(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_6(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_7(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_8(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_9(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_10(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_11(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_16(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_17(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_18(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_19(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_20(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_21(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_22(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_23(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_24(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_25(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_26(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_27(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_28(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_29(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_30(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_31(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_32(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_33(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_34(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_35(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_36(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_37(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_38(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_39(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_41(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_42(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_43(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_44(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_45(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_46(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_47(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_48(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_49(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_50(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_51(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_52(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_53(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_54(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_55(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_56(AutoPartySortData p);
			internal ElementalType _AutoPartyCharaSelect_b__149_57(AutoPartySortData p);
			internal WeaponType _AutoPartyCharaSelect_b__149_58(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_59(AutoPartySortData p);
			internal ulong _AutoPartyCharaSelect_b__149_60(AutoPartySortData p);
			internal int _AutoPartyCharaSelect_b__149_61(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyCharaSelect_b__149_62(AutoPartySortData currData, AutoPartySortData nextData);
			internal int _AutoPartyAbilityCrestSelect_b__152_0(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_1(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_2(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_3(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_4(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_5(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_6(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_7(AutoPartySortData p);
			internal int _AutoPartyAbilityCrestSelect_b__152_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_0(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_1(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_2(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__173_3(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_4(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_5(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__173_6(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_7(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_8(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_9(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__173_10(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_11(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_12(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__173_13(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_14(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_15(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_16(AutoPartySortData p);
			internal ElementalType _SortDragonWeaponList_b__173_17(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_18(AutoPartySortData p);
			internal int _SortDragonWeaponList_b__173_19(AutoPartySortData p);
			internal ulong _SortDragonWeaponList_b__173_20(AutoPartySortData p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass150_0
		{
			// Fields
			public int i;
			public PartyModel __4__this;
	
			// Constructors
			public __c__DisplayClass150_0();
	
			// Methods
			internal bool _AutoPartyDragonSelect_b__0(AutoPartySortData item);
		}
	
		[CompilerGenerated]
		private struct _SendPartySettingRequest_d__168 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyModel __4__this;
			public Action onSuccessCallback;
			public Action<ErrorType, int> onErrorCallback;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SendPartyDataForNeedEditSkillSetting_d__169 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyModel __4__this;
			public Action onCompleteCallback;
			private int _i_5__2;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass174_0
		{
			// Fields
			public PartyNameEditPopup popup;
			public int editPartyIndex;
			public int partyIndex;
			public PartyList info;
			public PartyModel __4__this;
			public Action<string> editCompleteCallBack;
	
			// Constructors
			public __c__DisplayClass174_0();
	
			// Methods
			internal void _ShowPartyNameEditPopup_b__0();
			internal void _ShowPartyNameEditPopup_b__1();
		}
	
		[CompilerGenerated]
		private struct _SendPartyName_d__175 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public string name;
			public int partyNo;
			public PartyModel __4__this;
			public Action<string> completeCallBack;
			private TaskAwaiter<PartyUpdatePartyNameResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _CopyPartyData_d__176 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyModel __4__this;
			public int srcPartyNo;
			public int dstPartyNo;
			public Action<ErrorType, int> onErrorCallback;
			public Action onSuccessCallback;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyModel();
		static PartyModel();
	
		// Methods
		public static bool IsSelectedCurrentClearParty();
		public int GetCrestBySlotIndex(PartySettingList chara, int slotIndex);
		public void SetCrestBySlotIndex(PartySettingList chara, int slotIndex, int crestId);
		public int[] GetActiveCrestIds();
		public void SetActiveCrestIdBySlotIndex(int slotIndex, int crestId);
		public PartyList GetPartyDataByIndex(int partyIndex);
		protected override void Awake();
		public void Reload();
		public void ReloadPartyName();
		public bool CompareAllPartyDataWithDataManager();
		public void ShowReloadPopup();
		public void SendPartyDataErrorToFirebase();
		public void SetOrderParty(int questOrderPartyGroupId);
		public static void CreateClearPartyData(PartySettingList[] questClearParty);
		public static void CreateClearPartyData(int[] charaIds, ulong[] dragonIds, int[] weaponBodyIds, int[] weaponSkinIds, int[] editSkill3CharaIds, int[] editSkill4CharaIds, int[] crest11Ids, int[] crest12Ids, int[] crest13Ids, int[] crest21Ids, int[] crest22Ids, int[] crest31Ids, int[] crest32Ids);
		public static ulong GetOwnId<T>(DataManager.GameData<T> data, ulong id)
			where T : class;
		public static int GetOwnId<T>(DataManager.GameData<T> data, int id)
			where T : class;
		public static void CreateClearPartyLostUnitData(AtgenLostUnitList[] lost_unit_list);
		public static void ResetClearParty();
		public static void ResetOrderParty();
		public static void ClearStaticData();
		public static void ShowEmptyQuestClearUnitPopup(EmptyQuestClearUnitData[] emptyUnitData);
		public static void RequestSaveClearPartyMulti(int questId, Action onSuccess);
		public static async Task<QuestGetQuestClearPartyMultiResponse> RequestSaveClearPartyMulti(int questId);
		private PartyList GetCurrentPartyCharactersInfo();
		private PartyList GetPartyCharactersInfo(int index);
		public void AutoPartyUnitSelect(AutoPartyConfigData configData);
		public void AutoPartyEquipUnitSelect(AutoPartyConfigData configData);
		private void AutoPartyCharaSelect(ElementalType element, UnitType charaType);
		private void AutoPartyDragonSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex = -1);
		private void AutoPartyWeaponSelect(ElementalType element, UnitType charaType, bool isChangeChara, int partyIndex);
		private void AutoPartyAbilityCrestSelect(UnitType charaType, int partyIndex = -1, int abilityIndex = 0);
		public int GetEquipCrestId(int partyIndex, int partySettingListIndex);
		public void SetEquipCrestId(int partyIndex, int partySettingListIndex, int setId);
		private int GetUniqeAbilityCrestId(int crestId, List<AutoPartySortData> tempSortDataList, CharaDataElement masterCharaData, UnitType charaType);
		private void SetEquipPriorityList(int index, int partyIndex, WeaponType charaWeaponType, ref List<int> equipPartyPriorityList);
		private int GetAutoSelectCharaElementSortPriority(ElementalType charaElement, ElementalType targetElement, bool isChangeChara, ElementalType selectElement);
		private int GetAutoSelectAbilitySortPriority(int partyPriority, WeaponType targetWeaponType);
		private int GetAutoSelectElementSortPriority(ElementalType selectElement, ElementalType targetElement);
		private int GetAutoSelectAbilityElementSortPriority(ElementalType selectElement, ElementalType targetElement);
		private int GetAutoSelectWeaponTypeSortPriority(WeaponType selectElement, WeaponType targetElement);
		private int GetAutoSelectTypeSortPriority(UnitType selectType, UnitType targetType);
		public void CreateOldPartyData();
		public void CreateOldPartyData(PartyList activeParty);
		public void ResetPartyData();
		public void CreateFromMatchingPartyData();
		public void ResetPartyDataByFromMatchingPartyData();
		public async void SendPartySettingRequest(Action onSuccessCallback, Action<ErrorType, int> onErrorCallback = null);
		public async void SendPartyDataForNeedEditSkillSetting(Action onCompleteCallback = null);
		public string GetDefaultPartyName(int index);
		public void SendMainPartyNoRequest(Action onSuccessCallback, Action<ErrorType, int> onErrorCallback = null);
		private void OnMainPartyNoSuccessCallBack(PartySetMainPartyNoResponse res);
		private void SortDragonWeaponList(UnitType charaType, ref List<AutoPartySortData> sortList);
		public void ShowPartyNameEditPopup(int editPartyIndex = -1, Action<string> editCompleteCallBack = null);
		public async void SendPartyName(string name, int partyNo, Action<string> completeCallBack);
		public async void CopyPartyData(int srcPartyNo, int dstPartyNo, Action onSuccessCallback, Action<ErrorType, int> onErrorCallback = null);
		public void CopyPartyDataToLocal(int srcPartyNo, int dstPartyNo);
		public string GetPartyName(int partyIndex = -1);
		public string GetCrestSetName(int index);
		public static void ExcludeClearPartyDragonByElementalType(ElementalType limitedElementalType);
		public static AtgenCharaUnitSetDetailList GetEquipSetData(int charaId, int setIndex);
		public string GetEquipSetSetName(int charaId, int index);
		public static PartyList GetActivePartyCopyData();
		public static int GetPartySwitchIndex(int questId, int index);
		public static void SetPartySwitchIndex(int questId, int partyIndex, int cellIndex);
		public static PartySettingList[] GetPartySwtichClearParty(int questId);
		public static void FixDuplicateCrest(PartySettingList partyData);
		public static bool HasUnitData(GiftType type, int unitId, int count);
	}
}
