using System;

namespace BAG.CustomObject
{
public class U_EVNT_MASTER
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_EVNT_MASTER()
	{}


	public string Event_Id
	{ 
		get { return _Event_Id; }
		set { _Event_Id = value; }
	}
	private string _Event_Id;

	public string Event_Creator_Id
	{ 
		get { return _Event_Creator_Id; }
		set { _Event_Creator_Id = value; }
	}
	private string _Event_Creator_Id;

	public string Event_Type_Id
	{ 
		get { return _Event_Type_Id; }
		set { _Event_Type_Id = value; }
	}
	private string _Event_Type_Id;

	public string Event_Name
	{ 
		get { return _Event_Name; }
		set { _Event_Name = value; }
	}
	private string _Event_Name;

	public string Event_Desc
	{ 
		get { return _Event_Desc; }
		set { _Event_Desc = value; }
	}
	private string _Event_Desc;

	public System.DateTime Event_StartDate
	{ 
		get { return _Event_StartDate; }
		set { _Event_StartDate = value; }
	}
	private System.DateTime _Event_StartDate;

	public System.DateTime Event_EndDate
	{ 
		get { return _Event_EndDate; }
		set { _Event_EndDate = value; }
	}
	private System.DateTime _Event_EndDate;

	public string Even_Location
	{ 
		get { return _Even_Location; }
		set { _Even_Location = value; }
	}
	private string _Even_Location;

	public string Event_Status
	{ 
		get { return _Event_Status; }
		set { _Event_Status = value; }
	}
	private string _Event_Status;

	public string Media_Id_Img
	{ 
		get { return _Media_Id_Img; }
		set { _Media_Id_Img = value; }
	}
	private string _Media_Id_Img;

	public string COMMENTS
	{ 
		get { return _COMMENTS; }
		set { _COMMENTS = value; }
	}
	private string _COMMENTS;

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

	public U_EVNT_MASTER(

		string Event_Id, 
		string Event_Creator_Id, 
		string Event_Type_Id, 
		string Event_Name, 
		string Event_Desc, 
		System.DateTime Event_StartDate, 
		System.DateTime Event_EndDate, 
		string Even_Location, 
		string Event_Status, 
		string Media_Id_Img, 
		string COMMENTS, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Event_Id = Event_Id; 
		this._Event_Creator_Id = Event_Creator_Id; 
		this._Event_Type_Id = Event_Type_Id; 
		this._Event_Name = Event_Name; 
		this._Event_Desc = Event_Desc; 
		this._Event_StartDate = Event_StartDate; 
		this._Event_EndDate = Event_EndDate; 
		this._Even_Location = Even_Location; 
		this._Event_Status = Event_Status; 
		this._Media_Id_Img = Media_Id_Img; 
		this._COMMENTS = COMMENTS; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}