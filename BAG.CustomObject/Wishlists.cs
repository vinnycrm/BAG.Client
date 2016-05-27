using System;

namespace BAG.CustomObject
{
public class WishList
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public WishList()
	{}


	public string Id
	{ 
		get { return _Id; }
		set { _Id = value; }
	}
	private string _Id;

	public string WList_Name
	{ 
		get { return _WList_Name; }
		set { _WList_Name = value; }
	}
	private string _WList_Name;


    public WishList(

		string Id, 
		string WList_Name)
	{

	
		this._Id = Id; 
		this._WList_Name = WList_Name; 
	}
}
}