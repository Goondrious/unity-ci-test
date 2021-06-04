using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleText : MonoBehaviour
{
    public void ToggleCanvasText() {
		Text text = GameObject.Find("CanvasText").GetComponent<Text>();
		text.enabled = !text.enabled;
    }
}
