class Person
{
  private string name; //field
  private string surname;

  public string Name //property
  {
	//Property accessors can be omitted, for instance if you remove set - the property you've created becomes readonly
    get { return name; }
    set { name = value; }
  }
  //when you don't need custom logic you can sommer - auto implemented properties
  public string Surname { get; set; }

}

/*
Need to revise constructors and modifiers again!
*/
