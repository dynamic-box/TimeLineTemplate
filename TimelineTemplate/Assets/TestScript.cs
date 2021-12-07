using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private Text infoText;

    public void ChangeText(string text)
    {
        infoText.text = text;
    }
}
