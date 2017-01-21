using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

	//private Material m_Material = null;
	private bool m_Fading = false;
	public float aFadeOutTime = 5.0f;
	public float aFadeInTime = 5.0f;
	public Color aColor = Color.white;

	void Start () {}

	void Update () {}

	private void DrawQuad (Color aColor, float aAlpha) {
		aColor.a = aAlpha;
		//m_Material.SetPass (0);
		GL.PushMatrix ();
		GL.LoadOrtho ();
		GL.Begin (GL.QUADS);
		GL.Color (aColor);   // moved here, needs to be inside begin/end
		GL.Vertex3 (0, 0, -1);
		GL.Vertex3 (0, 1, -1);
		GL.Vertex3 (1, 1, -1);
		GL.Vertex3 (1, 0, -1);
		GL.End ();
		GL.PopMatrix ();
	}

	public void StartFade () {
		m_Fading = true;
		StartCoroutine (DoFade (aFadeOutTime, aFadeInTime, aColor));
	}

	public bool IsFading() {
		return m_Fading;
	}

	private IEnumerator DoFade (float aFadeOutTime, float aFadeInTime, Color aColor) {
		float t = 0.0f;
		while (t < 1.0f) {
			yield return new WaitForEndOfFrame ();
			t = Mathf.Clamp01 (t + Time.deltaTime / aFadeOutTime);
			DrawQuad (aColor, t);
		}
		while (t > 0.0f) {
			yield return new WaitForEndOfFrame ();
			t = Mathf.Clamp01 (t - Time.deltaTime / aFadeInTime);
			DrawQuad (aColor, t);
		}
		m_Fading = false;
	}
}
