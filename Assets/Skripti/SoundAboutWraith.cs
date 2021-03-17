using System.Collections;
using UnityEngine;

public class SoundAboutWraith : MonoBehaviour
//Voice Wraith
{
    public AudioSource skanasAvotsW;
    public AudioClip skanaKoAtskanotW;

    public void uzbiditsUzAttelaW()
    {
        skanasAvotsW.PlayOneShot(skanaKoAtskanotW);
    }
    public void kursorsNoietNoAttelaW()
    {
        skanasAvotsW.Stop();
    }


}