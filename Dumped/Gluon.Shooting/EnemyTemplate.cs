using System;
using UnityEngine;

namespace Gluon.Shooting;

public class EnemyTemplate : MonoBehaviour
{
	[Serializable]
	public class LevelData
	{
		public Texture mainTex;

		public float hp;

		public int score;

		public int minPlayerLevel;

		public int maxPlayerLevel;

		public int takeStartS;

		public int takeStartM;

		public float bodyScale;

		[SerializeField]
		public bool disableSmallBullet;

		public bool itemizeOnDeath;

		public bool fadeoutBulletInFadeOut;

		public bool spinSelf;

		public void ClearOtherData()
		{
		}
	}

	[SerializeField]
	public SpriteRenderer fadeOutImage;

	public Transform tf;

	public GameObject body;

	public Animator animator;

	public bool stableAngle;

	[SerializeField]
	public SPFXAttacher kiraEffect;

	public SPFXAttacher bossCrushEffect;

	public SPFXAttacher bossDamageEffect;

	[SerializeField]
	public Sprite[] fadeOutSpriteList;

	public EnemyManager.TemplateType type;

	[SerializeField]
	public float w;

	public float h;

	public LevelData[] levelData;

	[SerializeField]
	public Enemy enemy;

	public Transform eJaw;

	public Transform eWingCL;

	public Transform eWingCR;

	public Transform eTailF;

	public Transform eChest;

	[SerializeField]
	public Animator movingAnimator;

	[NonSerialized]
	public Renderer[] renderers;
}
