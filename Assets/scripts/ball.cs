using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject prefab;
    [SerializeField] private float forceBuild = 20f;

    [SerializeField] private float MaxHoldTime = 5f;

    [SerializeField] private float LineSpeed = 10f;

    private LineRenderer _line;

    private bool _lineActive = false;
    
    private float _pressTimer=0f;
    private float _launchForce=0f;
    void Start()
    {
        _line = GetComponent<LineRenderer>();
        _line.SetPosition(1,Vector3.zero);
    }

    // Update is called once per frame
    private void Update()
    {
     Handleshot();
    }

    private void Handleshot()
    {
       

        if (Input.GetMouseButtonUp(0))
        {
            _launchForce = _pressTimer*forceBuild;
            _line.SetPosition(1, Vector3.zero);
            _lineActive = false;
        

            GameObject Ball = Instantiate(prefab, transform.parent);
            
            Ball.transform.rotation = transform.rotation;

            Ball.GetComponent<Rigidbody2D>().AddForce(Ball.transform.right*_launchForce, ForceMode2D.Impulse);

            Ball.transform.position = transform.position;
          

            

        }
          if(_lineActive)
            {
                _line.SetPosition(1,Vector3.right*_pressTimer*LineSpeed);
            }
        if (Input.GetMouseButtonDown(0))
        {
            _pressTimer =0;
            _lineActive = true;
        }
        if (_pressTimer < MaxHoldTime)
        {
            _pressTimer += Time.deltaTime;
        }
    }
    
}
