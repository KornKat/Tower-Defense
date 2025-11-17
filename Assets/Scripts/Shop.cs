using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint AnotherTurret;
    public TurretBlueprint WizardTower;

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

    public void PurchaseWizardTower()
    {
        Debug.Log("Wizard Tower Selected");
        buildManager.SetTurretToBuild(buildManager.WizardTowerPrefab);
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
