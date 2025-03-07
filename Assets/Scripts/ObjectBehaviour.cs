using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    bool _gameover=false;
    public void SpawnObject()
    {
       Instantiate(prefab,new Vector3(Random.Range(-8f,8f),6f,0f),Quaternion.identity); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.tag=="Player" && !_gameover)
    {
        SpawnObject();
        Destroy(gameObject);
    }
    else if(collision.gameObject.tag=="Ground")
    {
        _gameover=true;
        Debug.Log("Game Over! YOU LOSE");
    }

   } 
} 


