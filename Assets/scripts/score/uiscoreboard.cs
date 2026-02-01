using TMPro;
using UnityEngine;

public class uiscoreboard : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text scoreField;
    public TMP_Text multiplierField;
    void Start()
    {
       combosystem.OnScoreChange += UpdateUI; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnDisable()
    {
        combosystem.OnScoreChange -= UpdateUI;
    }
    private void UpdateUI(int score, int multiplier)
    {
        scoreField.text = "Score: "+score; 
        multiplierField.text = "Multiplier: "+multiplier+"X"; 
    }


}
