using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject optionMenu;
    private bool menuON;

    private void Awake()
    {
        menuON = false;
    }

    public void OpenCloseMenu()
    {
            optionMenu.SetActive(!menuON);
            menuON = !menuON;
    }

    public void CloseMenu()
    {
        optionMenu.SetActive(false);
        menuON = false;
    }
}
