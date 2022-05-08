///////////////////////////////////////////////////////////////////
/// Created by Chris Johnson - 15/04/2022
///////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// button functions & menu visibility control
/// </summary>
public class MenuManager : MonoBehaviour
{

    //object references 
    [Header("Menus")]
    [SerializeField]
    private GameObject MenuStartObject = null;
    [SerializeField]
    private GameObject MenuHomeObject = null;
    [SerializeField]
    private GameObject MenuGameTechObject = null;
    [SerializeField]
    private GameObject MenuArtObject = null;
    [SerializeField]
    private GameObject MenuProgrammingObject = null;
    [SerializeField]
    private GameObject MenuDesignObject = null;
    [SerializeField]
    private GameObject MenuMastersObject = null;
    [SerializeField]
    private GameObject MenuLecturersObject = null;
    [SerializeField]
    private GameObject MenuOverlayObject = null;
    [SerializeField]
    private GameObject MenuSideBar = null;
    [SerializeField]
    private GameObject BannerBackgroundObject = null;


    [Header("Sub Menus")]
    
    [SerializeField]
    private GameObject MenuProgrammingOverview = null;
    [SerializeField]       
    private GameObject MenuProgrammingEntryRequire = null;
    [SerializeField]       
    private GameObject MenuProgrammingModules = null;
    [SerializeField]       
    private GameObject MenuProgrammingFees = null;
    [SerializeField]       
    private GameObject MenuProgrammingCareers = null;
    [Space]
    [SerializeField]
    private GameObject MenuDesignOverview = null;
    [SerializeField]       
    private GameObject MenuDesignEntryRequire = null;
    [SerializeField]       
    private GameObject MenuDesignModules = null;
    [SerializeField]       
    private GameObject MenuDesignFees = null;
    [SerializeField]       
    private GameObject MenuDesignCareers = null;
    [Space]
    [SerializeField]
    private GameObject MenuArtOverview = null;
    [SerializeField]       
    private GameObject MenuArtEntryRequire = null;
    [SerializeField]       
    private GameObject MenuArtModules = null;
    [SerializeField]       
    private GameObject MenuArtFees = null;
    [SerializeField]       
    private GameObject MenuArtCareers = null;
    [Space]
    [SerializeField]
    private GameObject MenuMastersOverview = null;
    [SerializeField]       
    private GameObject MenuMastersEntryRequire = null;
    [SerializeField]       
    private GameObject MenuMastersModules = null;
    [SerializeField]       
    private GameObject MenuMastersFees = null;
    [SerializeField]       
    private GameObject MenuMastersCareers = null;

    [Header("Buttons")]
    [SerializeField]
    private GameObject LecturersSideBarButton = null;

    //empty list for menus
    private List<GameObject> Menus = new List<GameObject>();

    private List<GameObject> SubMenus = new List<GameObject>();

    private void Awake()
    {
        MenuSideBar.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Menus.Add(MenuStartObject);
        Menus.Add(MenuHomeObject);
        Menus.Add(MenuGameTechObject);
        Menus.Add(MenuArtObject);
        Menus.Add(MenuProgrammingObject);
        Menus.Add(MenuDesignObject);
        Menus.Add(MenuMastersObject);
        Menus.Add(MenuLecturersObject);
        Menus.Add(MenuOverlayObject);
        Menus.Add(MenuSideBar);    
        Menus.Add(BannerBackgroundObject);    

        UpdateMenu(MenuHomeObject, true);

        SubMenus.Add(MenuProgrammingOverview);
        SubMenus.Add(MenuProgrammingEntryRequire);
        SubMenus.Add(MenuProgrammingModules);
        SubMenus.Add(MenuProgrammingFees);
        SubMenus.Add(MenuProgrammingCareers);
        
        SubMenus.Add(MenuDesignOverview);
        SubMenus.Add(MenuDesignEntryRequire);
        SubMenus.Add(MenuDesignModules);
        SubMenus.Add(MenuDesignFees);
        SubMenus.Add(MenuDesignCareers);
        
        SubMenus.Add(MenuArtOverview);
        SubMenus.Add(MenuArtEntryRequire);
        SubMenus.Add(MenuArtModules);
        SubMenus.Add(MenuArtFees);
        SubMenus.Add(MenuArtCareers);
        
        SubMenus.Add(MenuMastersOverview);
        SubMenus.Add(MenuMastersEntryRequire);
        SubMenus.Add(MenuMastersModules);
        SubMenus.Add(MenuMastersFees);
        SubMenus.Add(MenuMastersCareers);






    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateMenu(GameObject a_currentMenu, bool a_isMainMenu)
    {
        if (a_isMainMenu) {
            //hide all of the attached menus
            HideAllMenus();
        }
        else
        {
            HideAllSubMenus();
        }

        a_currentMenu.SetActive(true);

        MenuOverlayObject.SetActive(true);
        MenuSideBar.SetActive(true);
        BannerBackgroundObject.SetActive(true);


        if (a_currentMenu == MenuHomeObject)
        {
            MenuOverlayObject.SetActive(false);
            MenuSideBar.SetActive(false);
        }

        if (a_currentMenu == MenuLecturersObject)
        {
            LecturersSideBarButton.SetActive(false);
        }
        else
        {
            LecturersSideBarButton.SetActive(true);
        }
    }


    void HideAllMenus()
    {
        foreach (GameObject Menu in Menus)
        {
            Menu.SetActive(false);
        }
    }

    void HideAllSubMenus()
    {
        foreach (GameObject SubMenu in SubMenus)
        {
            SubMenu.SetActive(false);
        }
    }

    /// <summary>
    /// update the menu to the start menu
    /// </summary>
    public void MenuStartButton()
    {
        UpdateMenu(MenuStartObject, true);
    }

    /// <summary>
    /// update the menu to the home menu
    /// </summary>
    public void MenuHomeButton()
    {
        UpdateMenu(MenuHomeObject, true);
    }

    /// <summary>
    /// update the menu to the game tech menu
    /// </summary>
    public void MenuGameTechButton()
    {
        UpdateMenu(MenuGameTechObject, true);
    }

    /// <summary>
    /// update the menu to the art menu
    /// </summary>
    public void MenuArtButton()
    {
        UpdateMenu(MenuArtObject, true);
        SubMenuArtOverview();
    }

    /// <summary>
    /// update the menu to the programming menu
    /// </summary>
    public void MenuProgrammingButton()
    {
        UpdateMenu(MenuProgrammingObject, true);
        SubMenuProgrammingOverview();
    }
    /// <summary>
    /// update the menu to the design menu
    /// </summary>
    public void MenuDesignButton()
    {
        UpdateMenu(MenuDesignObject, true);
        SubMenuDesignOverview();
    }
    /// <summary>
    /// update the menu to the masters menu
    /// </summary>
    public void MenuMastersButton()
    {
        UpdateMenu(MenuMastersObject, true);
        SubMenuMastersOverview();
    }
    /// <summary>
    /// update the menu to the lecturers menu
    /// </summary>
    public void MenuLecturersButton()
    {
        UpdateMenu(MenuLecturersObject, true);
    }





    /// <summary>
    /// update sub menu of programming to overview
    /// </summary>
    public void SubMenuProgrammingOverview()
    {
        UpdateMenu(MenuProgrammingOverview, false);
    }
    /// <summary>
    /// update sub menu of programming to EntryRequire
    /// </summary>
    public void SubMenuProgrammingEntryRequire()
    {
        UpdateMenu(MenuProgrammingEntryRequire, false);
    }

    /// <summary>
    /// update sub menu of programming to Moduels
    /// </summary>
    public void SubMenuProgrammingModules()
    {
        UpdateMenu(MenuProgrammingModules, false);
    }

    /// <summary>
    /// update sub menu of programming to Fees
    /// </summary>
    public void SubMenuProgrammingFees()
    {
        UpdateMenu(MenuProgrammingFees, false);
    }

    /// <summary>
    /// update sub menu of programming to Careers
    /// </summary>
    public void SubMenuProgrammingCareers()
    {
        UpdateMenu(MenuProgrammingCareers, false);
    }


    /// <summary>
    /// update sub menu of design to overview
    /// </summary>
    public void SubMenuDesignOverview()
    {
        UpdateMenu(MenuDesignOverview, false);
    }
    /// <summary>
    /// update sub menu of design to EntryRequire
    /// </summary>
    public void SubMenuDesignEntryRequire()
    {
        UpdateMenu(MenuDesignEntryRequire, false);
    }

    /// <summary>
    /// update sub menu of design to Moduels
    /// </summary>
    public void SubMenuDesignModules()
    {
        UpdateMenu(MenuDesignModules, false);
    }

    /// <summary>
    /// update sub menu of design to Fees
    /// </summary>
    public void SubMenuDesignFees()
    {
        UpdateMenu(MenuDesignFees, false);
    }

    /// <summary>
    /// update sub menu of design to Careers
    /// </summary>
    public void SubMenuDesignCareers()
    {
        UpdateMenu(MenuDesignCareers, false);
    }



    /// <summary>
    /// update sub menu of art to overview
    /// </summary>
    public void SubMenuArtOverview()
    {
        UpdateMenu(MenuArtOverview, false);
    }
    /// <summary>
    /// update sub menu of art to EntryRequire
    /// </summary>
    public void SubMenuArtEntryRequire()
    {
        UpdateMenu(MenuArtEntryRequire, false);
    }

    /// <summary>
    /// update sub menu of art to Moduels
    /// </summary>
    public void SubMenuArtModules()
    {
        UpdateMenu(MenuArtModules, false);
    }

    /// <summary>
    /// update sub menu of art to Fees
    /// </summary>
    public void SubMenuArtFees()
    {
        UpdateMenu(MenuArtFees, false);
    }

    /// <summary>
    /// update sub menu of art to Careers
    /// </summary>
    public void SubMenuArtCareers()
    {
        UpdateMenu(MenuArtCareers, false);
    }



    /// <summary>
    /// update sub menu of Masters to overview
    /// </summary>
    public void SubMenuMastersOverview()
    {
        UpdateMenu(MenuMastersOverview, false);
    }
    /// <summary>
    /// update sub menu of art to EntryRequire
    /// </summary>
    public void SubMenuMastersEntryRequire()
    {
        UpdateMenu(MenuMastersEntryRequire, false);
    }

    /// <summary>
    /// update sub menu of Masters to Moduels
    /// </summary>
    public void SubMenuMastersModules()
    {
        UpdateMenu(MenuMastersModules, false);
    }

    /// <summary>
    /// update sub menu of Masters to Fees
    /// </summary>
    public void SubMenuMastersFees()
    {
        UpdateMenu(MenuMastersFees, false);
    }

    /// <summary>
    /// update sub menu of art to Careers
    /// </summary>
    public void SubMenuMastersCareers()
    {
        UpdateMenu(MenuMastersCareers, false);
    }



}
