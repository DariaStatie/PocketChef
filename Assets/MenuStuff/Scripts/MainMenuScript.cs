using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void cookSomething() {
        // adu numele retetelor si retetele din baza de date
        SceneManager.LoadScene("chooseRecipe");
    }

    public void optionsMenu() {
        //SceneManager.LoadScene("optionsMenu");
        SceneManager.LoadScene("OptionsMenu");
    }

    public void exitApp() {
        Application.Quit();
    }
}
