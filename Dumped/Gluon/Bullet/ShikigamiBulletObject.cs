using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ShikigamiBulletObject : StockBulletObject
	{
		protected class ShikigamiBulletDataCopy : StockBulletDataCopy
		{
			public int cpCostOnAttack;

			public int cpCostOnAttackLv2;

			public int hitCountForLevelUp;

			public int effectTriggerLv2;

			public int autoFireEffectTriggerLv2;

			public int[] autoFireActionIdList;

			public int actionConditionId;

			public int fireTrigger;

			public string headTextSummon;

			public int headIconSummon;

			public string headTextLvUp;

			public int headIconLvUp;
		}

		private int hitCount;

		private const int usingCpIndex = 0;

		private bool isFireTriggerKicked;

		private static readonly float _shikigamiDurationEventSendIntervalTime;

		private float _shikigamiDurationEventSendDelayTimer;

		private ShikigamiBulletDataCopy copyData;

		public ShikigamiData.LevelIndex level
		{
			[CompilerGenerated]
			get
			{
				return default(ShikigamiData.LevelIndex);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBuff.Parameter associatedBuff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CpCostOnAttack => default(int);

		public void SetShikigamiBulletData(ShikigamiData data)
		{
		}

		protected override void Clear()
		{
		}

		protected void GetQuantityAndPositionIndex(out ShikigamiData.QuantityIndex q, out ShikigamiData.PositionIndex p)
		{
		}

		public void OnRemoved()
		{
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		public override void PlayEffect()
		{
		}

		public override void StopEffect(bool immediately = false)
		{
		}

		protected override void ProcessAutoFire()
		{
		}

		public void OnHitCountAdded(int count)
		{
		}

		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation)
		{
			return default(bool);
		}

		private void ApplyShikigamiBuff(bool applyActionId = true)
		{
		}

		private void SendShikigamiLevelUpEvent()
		{
		}

		private void SendShikigamiRemoveEvent()
		{
		}

		private void SendShikigamiDurationEvent()
		{
		}

		public override void OnReceiveBulletEvent(BulletEvent recvEvent)
		{
		}

		public override void Restart(bool refreshBulletState)
		{
		}
	}
}
