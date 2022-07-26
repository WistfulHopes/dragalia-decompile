using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetButtonPlate : MonoBehaviour
{
	public enum FaceType
	{
		OneFace,
		TwoFace,
		None
	}

	[SerializeField]
	public FaceType type;

	public string[] buttonTexts;

	public Color[] buttonTextColors;

	public bool[] buttonTextIsOutlined;

	public Color[] buttonTextOutlineColors;

	[SerializeField]
	public GameObject[] objFaces;

	public Button[] oneFaceButtons;

	public Button[] twoFaceButtons;

	public Text[] oneFaceTexts;

	public Text[] twoFaceTexts;

	private void SetFaceText(Text[] face_texts, string[] texts)
	{
	}

	public void SetText(FaceType type, string[] texts)
	{
	}

	public void Start()
	{
	}
}
