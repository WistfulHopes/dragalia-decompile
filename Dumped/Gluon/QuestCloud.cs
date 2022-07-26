using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class QuestCloud : MonoBehaviour
{
	public enum enumCloudDirection
	{
		left,
		right
	}

	[SerializeField]
	private RectTransform trans;

	[SerializeField]
	private float speed;

	[SerializeField]
	private enumCloudDirection direction;

	[SerializeField]
	private float maxWidth;

	[SerializeField]
	private float _maxHeight;

	[SerializeField]
	private Image cloudImage;

	[SerializeField]
	private Image shadowImage;

	private bool _isFade;

	private Vector3 rightOutPosition;

	private Vector3 leftOutPosition;

	private bool isPlayFlag;

	private const float radius = 0.5f;

	public RectTransform Trans
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public enumCloudDirection Direction
	{
		get
		{
			return default(enumCloudDirection);
		}
		set
		{
		}
	}

	public float MaxWidth
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float maxHeight
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Image CloudImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Image ShadowImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isFade
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void PlayCloud(Vector2 mapSize)
	{
	}

	public void StopCloud()
	{
	}

	private void Update()
	{
	}

	public void FadeOut()
	{
	}

	public void Fadein()
	{
	}
}
