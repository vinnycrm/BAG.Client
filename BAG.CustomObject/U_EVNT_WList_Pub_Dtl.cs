using System;

namespace BAG.CustomObject
{
public class U_EVNT_WList_Pub_Dtl
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_EVNT_WList_Pub_Dtl()
	{}


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

	public System.DateTime Pub_Date
	{ 
		get { return _Pub_Date; }
		set { _Pub_Date = value; }
	}
	private System.DateTime _Pub_Date;

	public string Pub_MediaType
	{ 
		get { return _Pub_MediaType; }
		set { _Pub_MediaType = value; }
	}
	private string _Pub_MediaType;

	public string Pub_Status
	{ 
		get { return _Pub_Status; }
		set { _Pub_Status = value; }
	}
	private string _Pub_Status;

	public int Contact_Id
	{ 
		get { return _Contact_Id; }
		set { _Contact_Id = value; }
	}
	private int _Contact_Id;

	public string IsContact_Existing_Usr
	{ 
		get { return _IsContact_Existing_Usr; }
		set { _IsContact_Existing_Usr = value; }
	}
	private string _IsContact_Existing_Usr;

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

	public U_EVNT_WList_Pub_Dtl(

        int Event_Id,
        int WList_Id, 
		System.DateTime Pub_Date, 
		string Pub_MediaType, 
		string Pub_Status,
        int Contact_Id, 
		string IsContact_Existing_Usr, 
		string WList_CodeForPub, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Event_Id = Event_Id; 
		this._WList_Id = WList_Id; 
		this._Pub_Date = Pub_Date; 
		this._Pub_MediaType = Pub_MediaType; 
		this._Pub_Status = Pub_Status; 
		this._Contact_Id = Contact_Id; 
		this._IsContact_Existing_Usr = IsContact_Existing_Usr; 
		this._WList_CodeForPub = WList_CodeForPub; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}