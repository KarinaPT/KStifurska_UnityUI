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

    public GameObject biksesW;
    public GameObject jakaW;
    public GameObject maskaW;
    public GameObject zabakiW;

    public GameObject biksesW2;
    public GameObject jakaW2;
    public GameObject maskaW2;
    public GameObject zabakiW2;

    public GameObject slaideris;

    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;

    public void mainitLielumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }



    //CAUSTIC SETUP1
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

    //WRAITH SETUP1
    public void biksesWAttelosana(bool vertiba)
    {
        biksesW.SetActive(vertiba);
    }
    public void jakaWAttelosana(bool vertiba)
    {
        jakaW.SetActive(vertiba);
    }
    public void maskaWAttelosana(bool vertiba)
    {
        maskaW.SetActive(vertiba);
    }
    public void zabakiWAttelosana(bool vertiba)
    {
        zabakiW.SetActive(vertiba);
    }

    //WRAITH SETUP2
    public void biksesW2Attelosana(bool vertiba)
    {
        biksesW2.SetActive(vertiba);
    }
    public void jakaW2Attelosana(bool vertiba)
    {
        jakaW2.SetActive(vertiba);
    }
    public void maskaW2Attelosana(bool vertiba)
    {
        maskaW2.SetActive(vertiba);
    }
    public void zabakiW2Attelosana(bool vertiba)
    {
        zabakiW2.SetActive(vertiba);
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
