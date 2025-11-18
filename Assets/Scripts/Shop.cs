using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint AnotherTurret;
    public TurretBlueprint WizardTower;

    BuildManager buildManager;
    public void SelectTower()
    {
        Debug.Log("Archer Tower Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectAnotherTower()
    {
        Debug.Log("Another Tower Selected");
        buildManager.SelectTurretToBuild(AnotherTurret);
    }

    public void SelectWizardTower()
    {
        Debug.Log("Wizard Tower Selected");
        buildManager.SelectTurretToBuild(WizardTower);
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
