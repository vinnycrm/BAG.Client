using System;

namespace BAG.CustomObject
{
public class U_USR_Address
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Address()
	{}


	public int Address_Id
	{ 
		get { return _Address_Id; }
		set { _Address_Id = value; }
	}
	private int _Address_Id;

	public string Address_Type
	{ 
		get { return _Address_Type; }
		set { _Address_Type = value; }
	}
	private string _Address_Type;

	public string Address_Line1
	{ 
		get { return _Address_Line1; }
		set { _Address_Line1 = value; }
	}
	private string _Address_Line1;

	public string Address_Line2
	{ 
		get { return _Address_Line2; }
		set { _Address_Line2 = value; }
	}
	private string _Address_Line2;

	public string Address_Line3
	{ 
		get { return _Address_Line3; }
		set { _Address_Line3 = value; }
	}
	private string _Address_Line3;

	public string City
	{ 
		get { return _City; }
		set { _City = value; }
	}
	private string _City;

	public string StateName
	{ 
		get { return _StateName; }
		set { _StateName = value; }
	}
	private string _StateName;

	public string Country
	{ 
		get { return _Country; }
		set { _Country = value; }
	}
	private string _Country;

	public string ZipCode
	{ 
		get { return _ZipCode; }
		set { _ZipCode = value; }
	}
	private string _ZipCode;

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

	public U_USR_Address(

        int Address_Id, 
		string Address_Type, 
		string Address_Line1, 
		string Address_Line2, 
		string Address_Line3, 
		string City, 
		string StateName, 
		string Country, 
		string ZipCode, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Address_Id = Address_Id; 
		this._Address_Type = Address_Type; 
		this._Address_Line1 = Address_Line1; 
		this._Address_Line2 = Address_Line2; 
		this._Address_Line3 = Address_Line3; 
		this._City = City; 
		this._StateName = StateName; 
		this._Country = Country; 
		this._ZipCode = ZipCode; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}