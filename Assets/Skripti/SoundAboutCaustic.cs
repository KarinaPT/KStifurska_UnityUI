using System.Collections;
using UnityEngine;

public class SoundAboutCaustic : MonoBehaviour
    //Voice Caustic
{
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;

    public void uzbiditsUzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNoietNoAttela()
    {
        skanasAvots.Stop();
    }
  

}
