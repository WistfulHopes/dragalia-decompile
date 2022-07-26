using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon;

public class CharacterBuffAutoLevelInfo
{
	public class LevelData
	{
		public int id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int prevId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int nextId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int level
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int maxLevel
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private LevelData()
		{
		}

		public LevelData(int id, int prevId, int nextId)
		{
		}

		public void Set(int id, int prevId, int nextId, int level, int maxLevel)
		{
		}

		public void SetLevel(int level, int maxLevel)
		{
		}
	}

	public List<LevelData> levelDataList
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

	public bool Add(int conditionId)
	{
		return default(bool);
	}

	public bool IsRegist(int conditionId)
	{
		return default(bool);
	}
}
