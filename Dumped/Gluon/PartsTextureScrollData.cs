using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

[Serializable]
internal class PartsTextureScrollData : TextureScrollData
{
	[SerializeField]
	public string partsName;

	[HideInInspector]
	public MaterialPropertyData materialPropertyData;
}
