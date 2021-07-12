using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTexturePicker : MonoBehaviour
{
    public string productId;
    public GameObject productPrefab_1;
    public GameObject productPrefab_2;
    public GameObject productPrefab_3;
    public GameObject productPrefab_4;

    [Header("Texture Picker")]
    public Material plastic;
    public Material sandy, white_granite, black_granite, grey;

    public void ChangeProductMaterialToPlastic()
    {
        if (productId == "1")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original1");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = plastic;
            }
        }

        if (productId == "2")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original2");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = plastic;
            }
        }

        if (productId == "3")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original3");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = plastic;
            }
        }

        if (productId == "4")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original4");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = plastic;
            }
        }
    }


    public void ChangeProductMaterialToSandGranite()
    {
        if (productId == "1")
        {

            GameObject []go = GameObject.FindGameObjectsWithTag("original1");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = sandy;
            }

        }

        if (productId == "2")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original2");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = sandy;
            }
        }

        if (productId == "3")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original3");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = sandy;
            }
        }

        if (productId == "4")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original4");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = sandy;
            }
        }
    }

    public void ChangeProductMaterialToWhiteGranite()
    {
        if (productId == "1")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original1");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = white_granite;
            }
        }

        if (productId == "2")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original2");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = white_granite;
            }
        }

        if (productId == "3")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original3");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = white_granite;
            }
        }

        if (productId == "4")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original4");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = white_granite;
            }
        }
    }

    public void ChangeProductMaterialToBlackGranite()
    {
        if (productId == "1")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original1");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = black_granite;
            }
        }

        if (productId == "2")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original2");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = black_granite;
            }
        }

        if (productId == "3")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original3");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = black_granite;
            }
        }

        if (productId == "4")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original4");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = black_granite;
            }
        }
    }

    public void ChangeProductMaterialToGreyGranite()
    {
        if (productId == "1")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original1");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = grey;
            }
        }

        if (productId == "2")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original2");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = grey;
            }
        }

        if (productId == "3")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original3");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = grey;
            }
        }

        if (productId == "4")
        {

            GameObject[] go = GameObject.FindGameObjectsWithTag("original4");

            foreach (GameObject g in go)
            {
                g.GetComponent<Renderer>().material = grey;
            }
        }
    }


    #region ProductSelectionMethods

    public void SelectProduct1()
    {
        productId = "1";
    }

    public void SelectProduct2()
    {
        productId = "2";
    }

    public void SelectProduct3()
    {
        productId = "3";
    }

    public void SelectProduct4()
    {
        productId = "4";
    }

    public void DestroyAllProducts()
    {
        Destroy(GameObject.FindGameObjectWithTag("1"));

    }

    #endregion
}
