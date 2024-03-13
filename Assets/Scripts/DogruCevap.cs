using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogruCevap : MonoBehaviour
{
    public GameObject DogruuCevap;
    public GameObject YanlisCevap;
    public GameObject correctAnswerPanel;


    public void OnCorrectAnswerClicked()
    {
        DogruuCevap.SetActive(false);
        correctAnswerPanel.SetActive(false);

    }

    
    public void OnWrongAnswerClicked()
    {
        YanlisCevap.SetActive(true);
    }
}