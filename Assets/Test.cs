using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void OnEnable() {
		var rend = GetComponent<MeshRenderer>();

		var mpb = new MaterialPropertyBlock();
		mpb.SetColor("_Color", new Color(Random.Range(0.8f, 1.0f), Random.Range(0.8f, 1.0f), Random.Range(0.8f, 1.0f), 1.0f));

		rend.SetPropertyBlock(mpb);
	}
}
