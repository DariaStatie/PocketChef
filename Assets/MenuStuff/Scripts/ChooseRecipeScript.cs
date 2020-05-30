using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseRecipeScript : MonoBehaviour
{
    public string[] recipesNames = new string[]{"Suc de mere", "Placinta", "Friptura de miel", "Paella", "Stiuca la gratar", "Somon prajit", "Papanasi", "Friptura de porc", "Supa crema"};
    public string[] recipes = new string[]{"Stoarce niste mere", "Placinta aia de ...", "Pune mielul pe gratar", "Asta e complicat", "Pune stiuca pe gratar",
                                "Unge somonul cu unt si arunca-l in tigaie", "Si asta e greu de facut", "Pune porcul pe gratar sa sfaraie", "Fa supa si apoi piseaza tot la gramada"};

    // public GameObject prefabButton;
    // public RectTransform ParentPanel;
    // public GameObject textAreaForRecipe;
    // public GameObject tempObject;
    // public Text recipeText;

    // void Start () {
    //     for (int i = 0; i <= recipesNames.Length; i++) {
    //         GameObject goButton = (GameObject)Instantiate(prefabButton);
    //         goButton.transform.SetParent(ParentPanel, false);
    //         goButton.transform.localScale = new Vector3(1, 1, 1);

    //         Button tempButton = goButton.GetComponent<Button>();
    //         int tempInt = i;

    //         tempButton.onClick.AddListener(() => writeRecipe(tempInt));
    //     }
    //     tempObject = GameObject.Find("AreaForRecipe");
    //     tempObject = tempObject.transform.GetChild(0).gameObject;
    //     textAreaForRecipe = tempObject.transform.GetChild(0).gameObject;
    //     recipeText = textAreaForRecipe.GetComponent<Text>();
    // }

    // private void writeRecipe(int number) {
    //     recipeText.text = getRecipe(number);
    // }

    // public string getRecipe(int position) {
    //     if (0 <= position && position <= recipes.Length)
    //         return recipes[position];
    //     else
    //         return "Nu s-a gasit";
    // }

    public string getRecipe(string recipeName) {
        for (int i = 0; i <= recipesNames.Length; i++) {
            if (recipeName.CompareTo(recipesNames[i]) == 0) {
                return recipes[i];
            }
        }

        return "Nu s-a gasit";
    }

    public void goBack() {
        SceneManager.LoadScene("MainMenu");
    }
}
