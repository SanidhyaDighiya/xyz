using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCube : MonoBehaviour
{
    public GameObject CubeObj;
    Vector3 Pos;
    bool next;
    public float[] posX;
    public float[] posZ;
    int value = 1;
    public int lastpos = 1;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        StartCoroutine(WaitSys());
    }
    IEnumerator WaitSys()
    {
	yield return new WaitForSeconds(1f);
	next = true;
	Generate ();
    }
    void Generate()
    {
	if(!next)
	return;
	int i = Random.Range(0, 3);
	Pos.x = posX[i];
	Pos.z+= posZ[i];
	GameObject CubeClone = Instantiate (CubeObj, Pos, CubeObj.transform.rotation);
	CubeClone.GetComponent<CubeScript>().mynum = value;
	CubeClone.transform.SetParent(this.transform);
	value+=1;
	next = false;
    }
    public void message(int i)
    {
	if(lastpos == i)
	lastpos+=1;
    }
}
