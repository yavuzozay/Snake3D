using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField] private GameObject SnakeHead, SnakeBody;
    [SerializeField]List<GameObject> Parts = new List<GameObject>();
    [SerializeField][Range(1f,20f)]private float speed;

    //
    [SerializeField]private Vector3 direction;
    private Quaternion rotation;

    //Input
    private float hInp, vInp;


    private void Awake()
    {
        direction = new Vector3(0, 0, 1);
        GameObject head = Instantiate(SnakeHead);
        Parts.Add(head);
    }
    private void Start()
    {
        StartCoroutine(ApplyMovement());
    }
    private void Update()
    {
        CheckInputs();
    }
    

    private void CheckInputs()
    {
        hInp = Input.GetAxis("Horizontal");
        vInp = Input.GetAxis("Vertical");

        if (hInp < -.1f)
        {
            direction = new Vector3(-1, 0, 0);
            rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (hInp > .1f)
        {
            direction = new Vector3(1, 0, 0);
            rotation = Quaternion.Euler(0, -90, 0);


        }
        else if (vInp < -.1f)
        {
            direction = new Vector3(0, 0, -1);
            rotation = Quaternion.Euler(0, 0, 0);


        }
        else if (vInp>.1f)
        {
            direction = new Vector3(0, 0, 1);
            rotation = Quaternion.Euler(0, 180, 0);



        }

    }
    private void Follow()
    {
        for (int i = Parts.Count-1; i > 0; i--)
        {
            Parts[i].transform.position = Parts[i - 1].transform.position;
            Parts[i].transform.rotation = Parts[i - 1].transform.rotation;
        }
    }
     IEnumerator ApplyMovement()
    {
        while (true)
        {
            Follow();
           
            Parts[0].transform.position+=(direction);
            Parts[0].transform.rotation = rotation;
            yield return new WaitForSeconds(1.5f/speed);

        }
    }

    public void AddPart()
    {
        GameObject clone = Instantiate(SnakeBody);
        clone.transform.position = Parts[Parts.Count - 1].transform.position - direction;

        Parts.Add(clone);
    }
}
