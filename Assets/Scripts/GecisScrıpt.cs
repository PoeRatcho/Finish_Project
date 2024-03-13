using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GecisScrıpt : MonoBehaviour
{

    public GameObject MevcutUI;
    public GameObject SınavUI; 

    public void OnCorrectAnswerClicked()
    {
       
        SınavUI.SetActive(true);
        MevcutUI.SetActive(false);
    }
}

