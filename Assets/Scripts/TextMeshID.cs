using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TextMeshID : MonoBehaviour
{
    public string id;
    public TMP_InputField inputField;
    public RequestExample request;
    public void ReadInputText()
    {
        id = inputField.text;
        Debug.Log(id);
        request.Start_RestfulCall(inputField.text);
    }
}
