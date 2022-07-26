using UnityEngine;

namespace Gluon;

public class ImageEffectAttachment : ImageEffectBase
{
	[SerializeField]
	private int _attachmentID;

	private GameObject _attachImageEffectPrefab;

	public int attachmentID => default(int);

	public bool AttachImageEffect(string prefabPath)
	{
		return default(bool);
	}
}
