using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public void PurchaseTower()
    {
        Debug.Log("Archer Tower Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseAnotherTower()
    {
        Debug.Log("Another Tower Selected");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
