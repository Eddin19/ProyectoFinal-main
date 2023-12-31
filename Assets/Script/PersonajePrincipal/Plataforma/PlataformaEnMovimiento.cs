using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaEnMovimiento : MonoBehaviour
{
    public GameObject objetoAmover;
    public Transform startPoint;
    public Transform endPoint;

    public float velocidad;
    private Vector3 moverHacia;
    // Start is called before the first frame update
    void Start()
    {
        moverHacia = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        objetoAmover.transform.position = Vector3.MoveTowards(objetoAmover.transform.position, moverHacia, velocidad * Time.deltaTime);

        if(objetoAmover.transform.position == endPoint.position)
        {
            moverHacia = startPoint.position;
        }
        if (objetoAmover.transform.position == startPoint.position)
        {
            moverHacia = endPoint.position;
        }
    }

}