using System;

namespace BAG.CustomObject
{
public class U_ADM_USR_Role_Mapping
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_ADM_USR_Role_Mapping()
	{}


	public int Usr_Id
	{ 
		get { return _Usr_Id; }
		set { _Usr_Id = value; }
	}
	private int _Usr_Id;

	public int Usr_Role_Id
	{ 
		get { return _Usr_Role_Id; }
		set { _Usr_Role_Id = value; }
	}
	private int _Usr_Role_Id;

	public int Event_Id
	{ 
		get { return _Event_Id; }
		set { _Event_Id = value; }
	}
	private int _Event_Id;

	public int WList_Id
	{ 
		get { return _WList_Id; }
		set { _WList_Id = value; }
	}
	private int _WList_Id;

	public System.DateTime Created_Date
	{ 
		get { return _Created_Date; }
		set { _Created_Date = value; }
	}
	private System.DateTime _Created_Date;

	public System.DateTime Updated_Date
	{ 
		get { return _Updated_Date; }
		set { _Updated_Date = value; }
	}
	private System.DateTime _Updated_Date;

	public string Created_by
	{ 
		get { return _Created_by; }
		set { _Created_by = value; }
	}
	private string _Created_by;

	public string Updated_by
	{ 
		get { return _Updated_by; }
		set { _Updated_by = value; }
	}
	private string _Updated_by;

	public U_ADM_USR_Role_Mapping(

        int Usr_Id,
        int Usr_Role_Id,
        int Event_Id,
        int WList_Id, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Usr_Id = Usr_Id; 
		this._Usr_Role_Id = Usr_Role_Id; 
		this._Event_Id = Event_Id; 
		this._WList_Id = WList_Id; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}