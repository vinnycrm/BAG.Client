using System;

namespace BAG.CustomObject
{
public class U_USR_Groups
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Groups()
	{}


	public int Group_Id
	{ 
		get { return _Group_Id; }
		set { _Group_Id = value; }
	}
	private int _Group_Id;

	public int Usr_Id
	{ 
		get { return _Usr_Id; }
		set { _Usr_Id = value; }
	}
	private int _Usr_Id;

	public string Group_Name
	{ 
		get { return _Group_Name; }
		set { _Group_Name = value; }
	}
	private string _Group_Name;

	public string Group_Desc
	{ 
		get { return _Group_Desc; }
		set { _Group_Desc = value; }
	}
	private string _Group_Desc;

	public string Group_Source
	{ 
		get { return _Group_Source; }
		set { _Group_Source = value; }
	}
	private string _Group_Source;

	public string Group_Status
	{ 
		get { return _Group_Status; }
		set { _Group_Status = value; }
	}
	private string _Group_Status;

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

	public U_USR_Groups(

        int Group_Id,
        int Usr_Id, 
		string Group_Name, 
		string Group_Desc, 
		string Group_Source, 
		string Group_Status, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Group_Id = Group_Id; 
		this._Usr_Id = Usr_Id; 
		this._Group_Name = Group_Name; 
		this._Group_Desc = Group_Desc; 
		this._Group_Source = Group_Source; 
		this._Group_Status = Group_Status; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}