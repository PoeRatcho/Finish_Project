using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etkilesim : MonoBehaviour
{
    
    public GameObject infoPanel;

    private void OnMouseDown()
    {
        
        ShowInfoPanel();
    }

    private void ShowInfoPanel()
    {
        Debug.Log("Tablo hakk�nda bilgi topland�.");

        infoPanel.SetActive(true);
    }
}