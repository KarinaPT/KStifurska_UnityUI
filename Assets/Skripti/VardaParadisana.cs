﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
    void Update()
    {
        
    }
    public string teksts, vecums;
    public GameObject ievadesLauks;
    public GameObject ievadesLauks2;
    public GameObject tekstaAttelosana;

    public void uzglabaTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        vecums = ievadesLauks2.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = " Hero name: " + teksts.ToUpper() + " Age: "+vecums;
    }
}
