using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

[CreateAssetMenu]
public class ShaderLodDataObject : ScriptableObject
{
	[Serializable]
	public class SwitchShaderData
	{
		public string name;

		public Shader defaultShader;

		public Shader silhouetteShader;

		public Shader richShader;

		public Shader silhouetteRichShader;
	}

	[SerializeField]
	private ShaderLevelData[] _shaderLevelDataList;

	[SerializeField]
	private Shader[] _shaderIgnoreList;

	[SerializeField]
	private SwitchShaderData[] switchShaderDataArray;

	public Shader GetSilhouetteSwitchShader(Shader shader, bool isDefault)
	{
		return null;
	}

	public SwitchShaderData GetSwitchShaderData(Shader shader)
	{
		return null;
	}

	public ShaderLevelLodData GetLodShader(Shader originalShader, LodLevel level)
	{
		return default(ShaderLevelLodData);
	}
}
