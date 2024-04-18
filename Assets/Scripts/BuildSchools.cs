using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSchools : MonoBehaviour
{
    [SerializeField] private Transform parentT;
    [SerializeField] private List<GameObject> schoolGOs;

    Color[] schoolColors = new Color[]
        {
            new Color(0.4f, 0.76078431f, 0.64705882f),
            new Color(0.4f, 0.65098039f, 0.11764706f),
            new Color(0.45882353f, 0.43921569f, 0.70196078f),
            new Color(0.98823529f, 0.55294118f, 0.38431373f),
            new Color(0.10588235f, 0.61960784f, 0.46666667f),
            new Color(0.55294118f, 0.62745098f, 0.79607843f),
            new Color(0.85098039f, 0.37254902f, 0.00784314f),
            new Color(0.4f, 0.4f, 0.4f),
            new Color(0.90196078f, 0.67058824f, 0.00784314f),
            new Color(0.65098039f, 0.4627451f, 0.11372549f),
            new Color(0.90588235f, 0.16078431f, 0.54117647f)
        };

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < schoolGOs.Count; i++)
        {
            schoolGOs[i].GetComponentInChildren<Renderer>().material.color = schoolColors[i];
        }
    }

    private void Update()
    {
        float t = Time.realtimeSinceStartup - 5f;

        int activeSchool = Mathf.FloorToInt(t / 3f);

        for (int i = 0; i < schoolGOs.Count; i++)
                schoolGOs[i].SetActive(i == activeSchool);
    }
}
