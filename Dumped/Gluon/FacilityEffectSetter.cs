using UnityEngine;

namespace Gluon;

public class FacilityEffectSetter : MonoBehaviour
{
	[SerializeField]
	private string effName;

	[SerializeField]
	private Color color;

	[SerializeField]
	private bool needApplyColor;

	[SerializeField]
	private int triggerId;

	private GameObject effectObj;

	private void Start()
	{
	}

	private string GetEffectPath(string fileName)
	{
		return null;
	}

	private void DummyForAvoidingWarning(string name, int triggerId, GameObject obj)
	{
	}
}
