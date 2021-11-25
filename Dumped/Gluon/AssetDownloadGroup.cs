using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum AssetDownloadGroup
	{
		None = 0,
		Prologue = 1,
		AfterProloguePrein = 2,
		StoryVoice = 3,
		AfterPrologueNotPrein = 4,
		UnlockedFort = 5,
		EncounterEpisode = 6,
		NewQuestAndStory = 7,
		MyPage3dAfterPrologue = 8,
		MyPage3dUnlockedFort = 9,
		LocalizedPrologueJP = 100,
		LocalizedPrologueEN = 101,
		LocalizedAfterPrologueJP = 200,
		LocalizedAfterPrologueEN = 201,
		LocalizedMyPage3dJP = 210,
		LocalizedMyPage3dEN = 211,
		MemoryEvent = 100000000
	}
}