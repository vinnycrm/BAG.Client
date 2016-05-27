using System;

namespace BAG.CustomObject
{
public class WishlistItem
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public WishlistItem()
	{}


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

    public string Item_Id
	{ 
		get { return _Item_Id; }
		set { _Item_Id = value; }
	}
    private string _Item_Id;

	public decimal Item_Cost_Entered_ByUser
	{ 
		get { return _Item_Cost_Entered_ByUser; }
		set { _Item_Cost_Entered_ByUser = value; }
	}
	private decimal _Item_Cost_Entered_ByUser;


    public WishlistItem(

        string Event_Id,
        string WList_Id,
        string Item_Id, 
		decimal Item_Cost_Entered_ByUser)
	{

	
		this._Event_Id = Event_Id; 
		this._WList_Id = WList_Id; 
		this._Item_Id = Item_Id; 
		this._Item_Cost_Entered_ByUser = Item_Cost_Entered_ByUser; 
	}
}
}