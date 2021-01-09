using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public int mynum;
    private GenerateCube generate;
    void Start()
    {
	generate = GetComponent<GenerateCube>();
    }
    
}
