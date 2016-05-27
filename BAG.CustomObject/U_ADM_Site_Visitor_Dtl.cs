using System;

namespace BAG.CustomObject
{
public class U_ADM_Site_Visitor_Dtl
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_ADM_Site_Visitor_Dtl()
	{}


	public int Visitor_Id
	{ 
		get { return _Visitor_Id; }
		set { _Visitor_Id = value; }
	}
	private int _Visitor_Id;

	public System.DateTime Visit_Date_Time
	{ 
		get { return _Visit_Date_Time; }
		set { _Visit_Date_Time = value; }
	}
	private System.DateTime _Visit_Date_Time;

	public string Ip_Address
	{ 
		get { return _Ip_Address; }
		set { _Ip_Address = value; }
	}
	private string _Ip_Address;

	public string Visit_Source
	{ 
		get { return _Visit_Source; }
		set { _Visit_Source = value; }
	}
	private string _Visit_Source;

	public string Visitor_Location
	{ 
		get { return _Visitor_Location; }
		set { _Visitor_Location = value; }
	}
	private string _Visitor_Location;

	public string Channel_Type
	{ 
		get { return _Channel_Type; }
		set { _Channel_Type = value; }
	}
	private string _Channel_Type;

	public string Key_Tags
	{ 
		get { return _Key_Tags; }
		set { _Key_Tags = value; }
	}
	private string _Key_Tags;

	public string Revisiting_User
	{ 
		get { return _Revisiting_User; }
		set { _Revisiting_User = value; }
	}
	private string _Revisiting_User;

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

	public U_ADM_Site_Visitor_Dtl(

		int Visitor_Id, 
		System.DateTime Visit_Date_Time, 
		string Ip_Address, 
		string Visit_Source, 
		string Visitor_Location, 
		string Channel_Type, 
		string Key_Tags, 
		string Revisiting_User, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Visitor_Id = Visitor_Id; 
		this._Visit_Date_Time = Visit_Date_Time; 
		this._Ip_Address = Ip_Address; 
		this._Visit_Source = Visit_Source; 
		this._Visitor_Location = Visitor_Location; 
		this._Channel_Type = Channel_Type; 
		this._Key_Tags = Key_Tags; 
		this._Revisiting_User = Revisiting_User; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}