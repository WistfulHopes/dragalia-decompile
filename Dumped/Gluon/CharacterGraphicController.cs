using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class CharacterGraphicController : MonoBehaviour
{
	[SerializeField]
	private List<Renderer> _ignoreMainRenderers;

	public bool IsIgnoreMainRenderer(Renderer renderer)
	{
		return default(bool);
	}
}
