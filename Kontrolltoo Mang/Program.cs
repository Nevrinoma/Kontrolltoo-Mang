using Kontrolltoo_Mang;
using Microsoft.VisualBasic;
using System;




var fromfile = File.ReadAllLines(@"..\..\..\esemed.txt");
StreamReader from_file = new StreamReader(@"..\..\..\esemed.txt");

List<Ese> eseList = new List<Ese>();
            

for (int i = 0; i < eseList.Count; i++)
{
    string[] row_count = fromfile[i].Split(';');

}
from_file.Close();

Tegelane one = new Tegelane("Naruto");
Tegelane two = new Tegelane("Saske");











