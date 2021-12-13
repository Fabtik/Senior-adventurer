using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guide : MonoBehaviour
{
    public GameObject GuideElement;
    public GameObject GuideTrigger;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GuideElement.SetActive(true);
            
            StartCoroutine(RT());
        }

    }

   /* void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GuideElement.SetActive(false);

            StartCoroutine(RT());
        }

    }
   */

    IEnumerator RT()
    {
        //Time.timeScale = 0f;
        yield return new WaitForSeconds(1f);
        //Time.timeScale = 1f;
        GuideElement.SetActive(false);
        GuideTrigger.SetActive(false);
    }
}
