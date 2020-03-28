using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    
    public void Start()
    {
        int liczba1 = 10;
        float liczba2 = 20.0f;

        bool isCodingHard = true;
        bool isCodingLame = false;

        string napis1 = "Programuję w C#";
        string napis2 = "EPG";

        Debug.Log(liczba1 + ", " + liczba2 + ", " + isCodingHard + ", " + isCodingLame + ", " + napis1 + ", " + napis2);

        PorownanieLiczb(liczba1, liczba2);
        PorownanieStringow(napis1, napis2);
        Koniunkcja(isCodingLame, isCodingHard);
        Alternatywa(isCodingLame, isCodingHard);


    }

    public void PorownanieLiczb(int liczba1, float liczba2)
    {
        if (liczba1 == liczba2)
        {
            Debug.Log("Tak");
        }
        else if ((liczba1 != liczba2) || (liczba1 > liczba2) || (liczba1 < liczba2) || (liczba1 >= liczba2) || (liczba1 <= liczba2))
        {
            Debug.Log("Nie");
        }
    }

    public void PorownanieStringow(string napis1, string napis2)
    {
          if (!napis1.Equals(napis2))
        {
            Debug.Log("różne");
        }
    }

    public void Koniunkcja(bool isCodingLame, bool isCodingHard)
    {
        if ((isCodingLame == true) && (isCodingHard == true))
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
    }

    public void Alternatywa(bool isCodingLame, bool isCodingHard)
    {
        if ((isCodingLame == false) || (isCodingHard == false))
        {
            if ((isCodingHard == true) || (isCodingLame == true))
            {
                Debug.Log("true");
            }
            else
            {
                Debug.Log("false");
            }
        }
    }

    
}
