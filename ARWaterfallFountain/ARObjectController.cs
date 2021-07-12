using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObjectController : MonoBehaviour
{

    public ARTexturePicker pId_obj;


    public void ScaleUp()
    {

        if (pId_obj.productId == "1")
        {
            pId_obj.productPrefab_1.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (pId_obj.productId == "2")
        {
            pId_obj.productPrefab_2.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }

    public void ScaleDown()
    {
        if (pId_obj.productId == "1")
        {
            pId_obj.productPrefab_1.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (pId_obj.productId == "2")
        {
            pId_obj.productPrefab_2.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
