using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const int CandyFrequency = 3;
    int samplecandycount=0;
    public GameObject[] candy;
    public GameObject[] candySqure;
    public GameObject candyHolder;
    public float baseWidth;
    public float speed;
    public float torque;


    GameObject SelectCandy()
    {
        GameObject pr = null;

        if (samplecandycount % CandyFrequency == 0)
        {
            int index = Random.Range(0, candy.Length);
            pr = candy[index];


        }
        else
        {
            int index = Random.Range(0, candySqure.Length);
            pr = candySqure[index];
        } samplecandycount += 1;
        return pr;
       

    }

    Vector3 GetPosition()
    {
        //Input.mousePosition은 게임장면에서 결정됨. 스크린 위드 또한 게임장면(스크린)의 크기를 나타냄.
        float x = baseWidth * (Input.mousePosition.x / Screen.width) - (baseWidth / 2);
        Debug.Log(Input.mousePosition);
        Debug.Log(" ");
        Debug.Log(Screen.width);

        return transform.position + new Vector3(x, 0, 0);
    }

	public void shot()
    {
        GameObject c = Instantiate(SelectCandy(), GetPosition(), Quaternion.identity);
        c.transform.parent = candyHolder.transform;
        //캔디 오브젝트의 리짓바디를 얻어오고 힘과 회전을 더함
        Rigidbody rb = c.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        rb.AddTorque(new Vector3(torque, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
            shot();

	}
}
