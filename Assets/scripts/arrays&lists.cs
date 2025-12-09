
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class arraysandlists : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<string> items = new List<string>();
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.UpArrow))PrintAllItems(); 
    }
    private void PrintRandomItem()
    {
       Debug.Log(items[Random.Range(0,9)]);
    }
    private void PrintAllItems()
    {
        for (int i = 0; i < items.Count; i++) 
    {
    Debug.Log(items[i]);
    }
        
    
    }

    
    
}
