using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;
using UnityEngine.EventSystems;

public class ARTapToPlaceObject : MonoBehaviour
{
    public Camera ARMainCamera;

    public string productId;
    public GameObject productPrefab_1;
    public GameObject productPrefab_2;
    public GameObject productPrefab_3;
    public GameObject productPrefab_4;

    public int PrefabCounter1 = 0;
    public int prefabCounter2 = 0;
    public int prefabCounter3 = 0;
    public int prefabCounter4 = 0;
    public GameObject placementIndicator;
    private ARSessionOrigin arOrigin;
    private Pose placementPose;
    private bool placementPoseIsValid = false;


    public ARTexturePicker product_Obj;


    void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();

        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(0))
        {

            if (product_Obj.productId == "1" && PrefabCounter1 < 1)
            {
                InstantiateProduct_1();
                PrefabCounter1++;
            }

            if (product_Obj.productId == "2" && prefabCounter2 < 1)
            {
                InstantiateProduct_2();
                prefabCounter2++;
            }

            if (product_Obj.productId == "3" && prefabCounter3 < 1)
            {
                InstantiateProduct_3();
                prefabCounter3++;
            }

            if (product_Obj.productId == "4" && prefabCounter4 < 1)
            {
                InstantiateProduct_4();
                prefabCounter4++;
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && product_Obj.productId == "1" && PrefabCounter1 < 1)
            {
                InstantiateProduct_1();
                PrefabCounter1++;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && product_Obj.productId == "2" && prefabCounter2 < 1)
            {
                InstantiateProduct_2();
                prefabCounter2++;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3) && product_Obj.productId == "3" && prefabCounter3 < 1)
            {
                InstantiateProduct_3();
                prefabCounter3++;
            }

            if (Input.GetKeyDown(KeyCode.Alpha4) && product_Obj.productId == "4" && prefabCounter2 < 1)
            {
                InstantiateProduct_4();
                prefabCounter4++;
            }
        }
    }

    private void UpdatePlacementIndicator()
    {
        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = ARMainCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arOrigin.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }


    #region ProductInstantiationMethods

    void InstantiateProduct_1()
    {
        Instantiate(productPrefab_1, placementPose.position, placementPose.rotation);
    }

    void InstantiateProduct_2()
    {
        Instantiate(productPrefab_2, placementPose.position, placementPose.rotation);
    }

    void InstantiateProduct_3()
    {
        Instantiate(productPrefab_3, placementPose.position, placementPose.rotation);
    }

    void InstantiateProduct_4()
    {
        Instantiate(productPrefab_4, placementPose.position, placementPose.rotation);
    }
    #endregion


    public void DeleteAllFountains()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag("fountain");

        foreach (var clone in clones)
        {
            Destroy(clone);
        }

        PrefabCounter1 = 0;
        prefabCounter2 = 0;
        prefabCounter3 = 0;
        prefabCounter4 = 0;


        Debug.Log(" Count of 1st model : " + PrefabCounter1 + "count of 2nd model : " + prefabCounter2);
    }
}
