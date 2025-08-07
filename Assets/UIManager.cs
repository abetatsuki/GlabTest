using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject menuPamel;
    [SerializeField]GameObject xrHubPaanel;
    [SerializeField] GameObject unitypanel;

    private void Start()
    {
        BackToMenu();
    }
    public void SelectXrHubDescription()
    {
        menuPamel.SetActive(false);
        xrHubPaanel.SetActive(true);
    }
   public void SelectUnityDescription()
    {
        menuPamel.SetActive(false);
        unitypanel.SetActive(true);
    }
    public void BackToMenu()
    {
        menuPamel.SetActive(true) ;
        xrHubPaanel.SetActive(false) ;
        unitypanel .SetActive(false) ;
    }

}
