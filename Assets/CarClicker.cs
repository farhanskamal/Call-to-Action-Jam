using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarClicker : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wayPoints;
    public GameObject GMScript;
    public GameObject slef;
    public Vector3 target;
    private int location;
    private int cLocation;
    private int targets;
    private float speed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Hello John.");
            cLocation = location;
            location = UnityEngine.Random.Range(0, 3);
            target = wayPoints[location].transform.position;
            target.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            GMScript.GetComponent<GMScript>().dataC += 1;
        }
    }

    private void OnMouseDown()
    {
        GMScript.GetComponent<GMScript>().VirusHappens();
        Debug.Log("Hello John.");
        cLocation = location;
        location = UnityEngine.Random.Range(0, 3);
        target = wayPoints[location].transform.position;
        target.z = transform.position.z;
        // transform.position = wayPoints[location].transform.position;
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
        GMScript.GetComponent<GMScript>().dataC += 1;
    }
}
