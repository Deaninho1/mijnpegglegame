using System;
using System.Collections.Generic;
using UnityEngine;
public class combosystem : MonoBehaviour
{
    public static event Action<int,int> OnScoreChange;
    private List<string> bumperTags = new List<string>();   
    private int scoreMultiplier = 1;
    private void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;             
    }
    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;             
    }
    private void CheckForCombo(string tag, int bumperValue)
    {
        bumperTags.Add(tag);                                
        if (bumperTags.Count > 1)                           
        {                                                   
            if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1])
            {
                scoreMultiplier++;                          
            }
            else                                            //als ze niet gelijk zijn
            {
                scoreMultiplier = 1;                        //reset multiplier
                bumperTags.Clear();                         //leeg de lijst met tags
            }
        }                                                   //voeg score toe aan de ScoreManager
        scoremanager.Instance.Addscore(bumperValue * scoreMultiplier);

                                                            //print score en multiplier in de console
        OnScoreChange?.Invoke(scoremanager.Instance.score, scoreMultiplier);
    }
}

