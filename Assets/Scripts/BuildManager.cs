using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    public GameObject WizardTowerPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
}
