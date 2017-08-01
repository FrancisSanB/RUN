using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour {
    public float textSpeed = 5;
    Vector2 startingPosition;
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        TextAsset creditsTextFile = Resources.Load("credits") as TextAsset;
        GetComponent<Text>().text = creditsTextFile.text;
        startingPosition = rt.anchoredPosition;
    }
	// Update is called once per frame
	void Update () {
        rt.anchoredPosition += Vector2.up * textSpeed * Time.deltaTime;
	}

    public void ResetPosition()
    {
        rt.anchoredPosition = startingPosition;
    }
}
