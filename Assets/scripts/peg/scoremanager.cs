using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public static scoremanager Instance;
    
    public int score = 0;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        Debug.Log("Intstance" + Instance );
    }

    public void Addscore(int amount)
    {
       score = score + amount;

       Debug.Log("score" + score);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
