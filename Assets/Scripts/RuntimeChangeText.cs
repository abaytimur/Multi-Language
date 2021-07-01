using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeChangeText : MonoBehaviour
{
    public List<string> texts = new List<string>();
    private Button btn;
    private int textCount = 1;

    void Start()
    {
        btn = GetComponentInParent<Button>();
        btn.onClick.AddListener(ChangeText);
    }

    private void ChangeText()
    {
        GetComponent<Translator>().TranslateText = texts[textCount];
        textCount++;
        if(textCount >= texts.Count)
        {
            textCount = 0;
        }
    }
}