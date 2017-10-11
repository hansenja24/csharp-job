using System.Collections.Generic;

namespace NewJobs.Models
{
  public class Jobs
  {
    private string _employer;
    private string _position;
    private string _address;
    private string _minExp;
    private string _wage;

    private int _id;
    private static List<Jobs> _instances = new List<Jobs> {};


    public Jobs (string employer, string position, string address, string minExp, string wage)
    {
      _employer = employer;
      _position = position;
      _address = address;
      _minExp = minExp;
      _wage = wage;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetEmployer()
    {
      return _employer;
    }
    public void SetEmployer(string newEmployer)
    {
      _employer = newEmployer;
    }

    public string GetPosition()
    {
      return _position;
    }
    public void SetPosition(string newPosition)
    {
      _position = newPosition;
    }

    public string GetAddress()
    {
      return _minExp;
    }
    public void SetAddress(string newAddress)
    {
      _minExp = newAddress;
    }

    public string GetMinExp()
    {
      return _minExp;
    }
    public void GetMinExp(string newMinExp)
    {
      _minExp = newMinExp;
    }

    public string GetWage()
    {
      return _wage;
    }
    public void SetWage(string newWage)
    {
      _wage = newWage;
    }


    public int GetId()
    {
      return _id;
    }

    public static List<Jobs> GetAll()
    {
      return _instances;
    }

    public static Jobs Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
