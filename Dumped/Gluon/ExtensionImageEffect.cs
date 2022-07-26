using UnityEngine;

namespace Gluon;

public class ExtensionImageEffect : ImageEffectBase
{
	[SerializeField]
	private int _imageEffectSubID;

	[SerializeField]
	private int _attachmentID;

	[SerializeField]
	[ReadOnly]
	protected Camera _attachCamera;

	public int imageEffectSubID => default(int);

	public int attachmentID => default(int);

	public virtual void OnAttachCamera(Camera camera)
	{
	}
}
