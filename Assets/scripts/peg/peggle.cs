using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class peggle : MonoBehaviour
{
    public int HitsToDestroy = 3;
    public int PointsPerHit = 50;

    private void OnCollisionEnter2D()
    {
        scoremanager.Instance.Addscore(PointsPerHit);
        HitsToDestroy--;

         if (HitsToDestroy <= 0)
        {
            Destroy(gameObject, 0.25f);
        } 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
