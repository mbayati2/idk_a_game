using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriteEffects : MonoBehaviour
{

    public string textEffectString;

    [SerializeField] private TMP_Text textMesh;

    Mesh Mesh;

    Vector3[] vertices;

    List<int> wordIndexes;

    List<int> wordLengths;

    #region Effects

    private void Start()
    {
        wordIndexes = new List<int> { 0 };
        wordLengths = new List<int>();

        string s = textMesh.text;
        for (int index = s.IndexOf("<Shake>"); index > -1; index = s.IndexOf("<Shake/>", index + 1))
        {
            wordLengths.Add(index - wordIndexes[wordIndexes.Count - 1]);
            wordIndexes.Add(index + 1);
        }
        wordLengths.Add(s.Length - wordIndexes[wordIndexes.Count - 1]);
    }

    private void Update()
    {
        Mesh = textMesh.mesh;
        vertices = Mesh.vertices;
        textMesh.ForceMeshUpdate();

        Color[] colors = Mesh.colors;

        for (int w = 0; w < wordIndexes.Count; w++)
        {
            int wordIndex = wordIndexes[w];
            Vector3 offset = Wobble(Time.time + w);
        }

        Vector2 Wobble(float time)
        {
            return new Vector2(Mathf.Sin(time * 1.1f), Mathf.Cos(time * 0.8f));
        }
        #endregion
    }

}
