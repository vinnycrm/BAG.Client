using System;

namespace BAG.CustomObject
{
public class ItemsList
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public ItemsList()
	{}


	public string Item_Id
	{ 
		get { return _Item_Id; }
		set { _Item_Id = value; }
	}
	private string _Item_Id;

	public string Item_Name
	{ 
		get { return _Item_Name; }
		set { _Item_Name = value; }
	}
	private string _Item_Name;

    public bool Selected
    {
        get { return _Selected; }
        set { _Selected = value; }
    }
    private bool _Selected;

    public string Event_Id
    {
        get { return _Event_Id; }
        set { _Event_Id = value; }
    }
    private string _Event_Id;

    public string WList_Id
    {
        get { return _WList_Id; }
        set { _WList_Id = value; }
    }
    private string _WList_Id;


	public decimal Item_Tentative_Cost
	{ 
		get { return _Item_Tentative_Cost; }
		set { _Item_Tentative_Cost = value; }
	}
	private decimal _Item_Tentative_Cost;
        

	public string Media_Id_Img
	{ 
		get { return _Media_Id_Img; }
		set { _Media_Id_Img = value; }
	}
	private string _Media_Id_Img;
        

	public ItemsList(

		string Item_Id, 
		string Item_Name, 
		decimal Item_Tentative_Cost, 
		string Media_Id_Img)
	{

	
		this._Item_Id = Item_Id; 
		this._Item_Name = Item_Name; 
		this._Item_Tentative_Cost = Item_Tentative_Cost; 
		this._Media_Id_Img = Media_Id_Img; 
	}

    public ItemsList(

        string Item_Id,
        decimal Item_Tentative_Cost,
        bool Selected,
        string Event_Id,
        string WList_Id)
    {


        this._Item_Id = Item_Id;
        this._Item_Tentative_Cost = Item_Tentative_Cost;
        this._Selected = Selected;
        this._Event_Id = Event_Id;
        this._WList_Id = WList_Id;
    }
}
}