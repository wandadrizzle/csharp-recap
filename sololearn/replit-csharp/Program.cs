// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");

#region Arrays and Strings | Module 2 of C# Intermediate
//1. collections
  int[ ] myArray = new int[5];
  myArray[0] = 12;
  string[ ] names = new string[5] {"Nick", "Winston", "Cecelia 'Cece'", "Winston Saint-Marie", "Jessica"}; //You can also choose to omit the value inside the square brackets
  string[] surnames = new string[] {"Miller", "Bishop", "Parikh", "Schmdit", "Day"};
  string[ ] otherNames = {"John", "Mary", "Jessica"};

//used to loop through all ements in an array
foreach(string name in otherNames){
  Console.WriteLine(name);
}
Console.WriteLine("\nThese are the characters of New Girl");
for(int i = 0; i < names.Length; i++){
  Console.WriteLine(names[i] + " " + surnames[i]);
}
//multidimensional arrays RC
Console.WriteLine();
int[ , ] x = new int[3,4];
int[,] someNums = { {2, 3}, {5, 6}, {4, 6} };
for (int k = 0; k < 3; k++) {
  for (int j = 0; j < 2; j++) {
    Console.Write(someNums[k, j]+" ");
  }
  Console.WriteLine();
}

#endregion