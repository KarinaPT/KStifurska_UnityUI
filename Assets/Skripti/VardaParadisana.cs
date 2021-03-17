using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
    void Update()
    {
        
    }
    public string teksts;

    public GameObject ievadesLauks;

    public GameObject tekstaAttelosana;

    public void uzglabaTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
   
        tekstaAttelosana.GetComponent<Text>().text = "Supervaronis " + teksts.ToUpper();
    }
}
