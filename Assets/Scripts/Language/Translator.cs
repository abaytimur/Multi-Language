using UnityEngine;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
	[Tooltip ("enter one of the keys that you specify in your (txt) file for all languages.\n\n# for example: [HOME=home]\n# the key here is [HOME]")]
	public string key;

	//You can use for non-static texts.For example RuntimeChangeText.cs Line:20.
	public string Translate
	{
		get { return key; }
		set
		{
			key = value;
			GetComponent<Text>().text = Language.GetTraduction(key);
		}
	}

	public void Start()
	{
		Language.Instance.textsToTranslate.Add(this);
		Translate = key;
	}
}