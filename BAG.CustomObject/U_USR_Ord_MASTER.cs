using System;

namespace BAG.CustomObject
{
public class U_USR_Ord_MASTER
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Ord_MASTER()
	{}


	public int Ord_Id
	{ 
		get { return _Ord_Id; }
		set { _Ord_Id = value; }
	}
	private int _Ord_Id;

	public int Event_Creator_Id
	{ 
		get { return _Event_Creator_Id; }
		set { _Event_Creator_Id = value; }
	}
	private int _Event_Creator_Id;

	public string Ord_Number
	{ 
		get { return _Ord_Number; }
		set { _Ord_Number = value; }
	}
	private string _Ord_Number;

	public System.DateTime Ord_Date
	{ 
		get { return _Ord_Date; }
		set { _Ord_Date = value; }
	}
	private System.DateTime _Ord_Date;

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

	public U_USR_Ord_MASTER(

		int Ord_Id, 
		int Event_Creator_Id, 
		string Ord_Number, 
		System.DateTime Ord_Date, 
		string COMMENTS, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Ord_Id = Ord_Id; 
		this._Event_Creator_Id = Event_Creator_Id; 
		this._Ord_Number = Ord_Number; 
		this._Ord_Date = Ord_Date; 
		this._COMMENTS = COMMENTS; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}