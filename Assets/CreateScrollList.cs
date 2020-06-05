using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[System.Serializable]
public class retete
{
    public string pasi;
    public Sprite wow;
    public Button.ButtonClickedEvent spreBucatar;
}


public class CreateScrollList : MonoBehaviour
{
    public GameObject sampleButton;
    public Transform contentPanel;
    public List<retete> listaRetete;

    void Start()
    {
        PopulateList ();
    }

    void PopulateList()
    {
        foreach (var item in listaRetete)
            {
            GameObject newButton = Instantiate(sampleButton) as GameObject;
            SampleButtonScript buttonScript = newButton.GetComponent<SampleButtonScript > ();
            buttonScript.description.text = item.pasi;
            buttonScript.wow.sprite = item.wow;
            buttonScript.button.onClick = item.spreBucatar;

            newButton.transform.SetParent(contentPanel);
            }
    }

    public void MergiLaBucatar()
    {
        SceneManager.LoadScene("mainn");
        Debug.Log("Esti pe drumul cel bun!");
    }
}
