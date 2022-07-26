using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VertexMesh : BaseMeshEffect
{
	[SerializeField]
	public List<Vector3> offsets;

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public void ModifyVertices(List<UIVertex> vertexList)
	{
	}
}
