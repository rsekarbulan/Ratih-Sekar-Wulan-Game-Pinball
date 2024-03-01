using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsUIController : MonoBehaviour
{
    public Button menuButton;

    private void Start()
    {
        menuButton.onClick.AddListener(Menu);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}