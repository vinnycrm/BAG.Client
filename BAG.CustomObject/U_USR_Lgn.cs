using System;

namespace BAG.CustomObject
{
public class U_USR_Lgn
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Lgn()
	{}


	public int LgnGen_Id
	{ 
		get { return _LgnGen_Id; }
		set { _LgnGen_Id = value; }
	}
	private int _LgnGen_Id;

	public string Login_Id
	{ 
		get { return _Login_Id; }
		set { _Login_Id = value; }
	}
	private string _Login_Id;

	public int Usr_Mst_Id
	{ 
		get { return _Usr_Mst_Id; }
		set { _Usr_Mst_Id = value; }
	}
	private int _Usr_Mst_Id;

	public string Email_ID
	{ 
		get { return _Email_ID; }
		set { _Email_ID = value; }
	}
	private string _Email_ID;

	public string Mobile_Number
	{ 
		get { return _Mobile_Number; }
		set { _Mobile_Number = value; }
	}
	private string _Mobile_Number;

	public string Pwd
	{ 
		get { return _Pwd; }
		set { _Pwd = value; }
	}
	private string _Pwd;

	public System.DateTime Last_Login_Date
	{ 
		get { return _Last_Login_Date; }
		set { _Last_Login_Date = value; }
	}
	private System.DateTime _Last_Login_Date;

	public string Ip_Address
	{ 
		get { return _Ip_Address; }
		set { _Ip_Address = value; }
	}
	private string _Ip_Address;

	public int Login_status
	{ 
		get { return _Login_status; }
		set { _Login_status = value; }
	}
	private int _Login_status;

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

	public U_USR_Lgn(

        int LgnGen_Id, 
		string Login_Id,
        int Usr_Mst_Id, 
		string Email_ID, 
		string Mobile_Number, 
		string Pwd, 
		System.DateTime Last_Login_Date, 
		string Ip_Address, 
		int Login_status, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._LgnGen_Id = LgnGen_Id; 
		this._Login_Id = Login_Id; 
		this._Usr_Mst_Id = Usr_Mst_Id; 
		this._Email_ID = Email_ID; 
		this._Mobile_Number = Mobile_Number; 
		this._Pwd = Pwd; 
		this._Last_Login_Date = Last_Login_Date; 
		this._Ip_Address = Ip_Address; 
		this._Login_status = Login_status; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}