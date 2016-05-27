using System;

namespace BAG.CustomObject
{
public class U_USR_To_WList_Mapping
{

	public U_USR_To_WList_Mapping()
	{}


	public int UsrWlist_Map_Id
	{ 
		get { return _UsrWlist_Map_Id; }
		set { _UsrWlist_Map_Id = value; }
	}
	private int _UsrWlist_Map_Id;

	public int Event_Creator_Id
	{ 
		get { return _Event_Creator_Id; }
		set { _Event_Creator_Id = value; }
	}
	private int _Event_Creator_Id;

	public int Cntrb_Id
	{ 
		get { return _Cntrb_Id; }
		set { _Cntrb_Id = value; }
	}
	private int _Cntrb_Id;

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

	public int Contact_Id
	{ 
		get { return _Contact_Id; }
		set { _Contact_Id = value; }
	}
	private int _Contact_Id;

	public string WList_CodeForPub
	{ 
		get { return _WList_CodeForPub; }
		set { _WList_CodeForPub = value; }
	}
	private string _WList_CodeForPub;

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

	public U_USR_To_WList_Mapping(

		int UsrWlist_Map_Id, 
		int Event_Creator_Id, 
		int Cntrb_Id, 
		int Event_Id, 
		int WList_Id, 
		int Contact_Id, 
		string WList_CodeForPub, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._UsrWlist_Map_Id = UsrWlist_Map_Id; 
		this._Event_Creator_Id = Event_Creator_Id; 
		this._Cntrb_Id = Cntrb_Id; 
		this._Event_Id = Event_Id; 
		this._WList_Id = WList_Id; 
		this._Contact_Id = Contact_Id; 
		this._WList_CodeForPub = WList_CodeForPub; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}