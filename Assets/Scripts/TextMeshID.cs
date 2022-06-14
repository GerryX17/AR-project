using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//TFG BY Gerard Opazo
public class TextMeshID : MonoBehaviour
{
    public string id;
    public TMP_InputField inputField;
    //public RequestExample request;
    public NewRequest newRequest;
    public void ReadInputText()
    {
        id = inputField.text;
        newRequest.Start_RestfulCall(inputField.text);
    }


}
