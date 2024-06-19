using UnityEngine;
using UnityEngine.SceneManagement; // Fixed typo in namespace
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject annieBtn;
    public GameObject frankBtn;

    void Start()
    {
        // Assigning click events to the buttons
        annieBtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(chooseAnnie);
        frankBtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(chooseFrank);
    }

    void chooseAnnie()
    {
        GameData.charSelected = "annie"; // Assuming GameData has a field named charSelected
        Debug.Log("The player chooses Annie");
        //SceneManager.LoadScene("GameScene"); // Load the game scene after choosing character
    }

    void chooseFrank()
    {
        GameData.charSelected = "frank"; // Assuming GameData has a field named charSelected
        Debug.Log("The player chooses Frank");
        //SceneManager.LoadScene("GameScene"); // Load the game scene after choosing character
    }
}
