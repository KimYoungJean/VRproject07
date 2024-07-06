using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanControll : MonoBehaviour
{

    public GameObject spwanObject;
    public GameObject player;

    public IEnumerator SpwanObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            Vector3 spwanPoint = new Vector3(Random.Range(-8, 2), 0, Random.Range(-11, 11));

            GameObject spwanedObject = Instantiate(spwanObject, spwanPoint, Quaternion.identity);

            // ������Ʈ�� �÷��̾ �ٶ�

            spwanedObject.transform.LookAt(player.transform);
        }


    }

    public void Start()
    {
        
    }


}
