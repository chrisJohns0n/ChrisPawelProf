using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    //object references 
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

    //empty list for menus
    private List<GameObject> Menus = new List<GameObject>();



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

        UpdateMenu(MenuStartObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateMenu(GameObject a_currentMenu)
    {
        //hide all of the attached menus
        HideAllMenus();

        a_currentMenu.SetActive(true);

        if (a_currentMenu != MenuStartObject)
        {
            MenuOverlayObject.SetActive(true);
        }
    }

    void HideAllMenus()
    {
        foreach (GameObject Menu in Menus)
        {
            Menu.SetActive(false);
        }
    }

    /// <summary>
    /// update the menu to the start menu
    /// </summary>
    public void MenuStartButton()
    {
        UpdateMenu(MenuStartObject);
    }

    /// <summary>
    /// update the menu to the home menu
    /// </summary>
    public void MenuHomeButton()
    {
        UpdateMenu(MenuHomeObject);
    }

    /// <summary>
    /// update the menu to the game tech menu
    /// </summary>
    public void MenuGameTechButton()
    {
        UpdateMenu(MenuGameTechObject);
    }

    /// <summary>
    /// update the menu to the art menu
    /// </summary>
    public void MenuArtButton()
    {
        UpdateMenu(MenuArtObject);
    }

    /// <summary>
    /// update the menu to the programming menu
    /// </summary>
    public void MenuProgrammingButton()
    {
        UpdateMenu(MenuProgrammingObject);
    }
    /// <summary>
    /// update the menu to the design menu
    /// </summary>
    public void MenuDesignButton()
    {
        UpdateMenu(MenuDesignObject);
    }
    /// <summary>
    /// update the menu to the masters menu
    /// </summary>
    public void MenuMastersButton()
    {
        UpdateMenu(MenuMastersObject);
    }
    /// <summary>
    /// update the menu to the lecturers menu
    /// </summary>
    public void MenuLecturersButton()
    {
        UpdateMenu(MenuLecturersObject);
    }


}
