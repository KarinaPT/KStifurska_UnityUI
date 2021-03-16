using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject biksesC;
    public GameObject jakaC;
    public GameObject maskaC;
    public GameObject zabakiC;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    void Update()
    {
        
    }
    public void biksesCAttelosana(bool vertiba)
    {
        biksesC.SetActive(vertiba);    
    }
    public void jakaCAttelosana(bool vertiba)
    {
        jakaC.SetActive(vertiba);
    }
    public void maskaCAttelosana(bool vertiba)
    {
        maskaC.SetActive(vertiba);
    }
    public void zabakiCAttelosana(bool vertiba)
    {
        zabakiC.SetActive(vertiba);
    }
    public void izkritosais(int skaitlis)
    {
        if(skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }
}
