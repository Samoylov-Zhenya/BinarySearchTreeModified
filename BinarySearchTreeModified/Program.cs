using BinarySearchTreeModified;

Console.WriteLine("XYPMA github.com/Samoylov-Zhenya");Console.WriteLine();

var str = "5,2,4,21,15,42,5,4,4,21,21,21,21";
var arr = str.Split(",").Select(x => int.Parse(x)).ToArray();

TreeModified<int> treeM = new TreeModified<int>();


foreach (var item in arr)
    treeM.Add(item);
int cm = 0;
Console.Write("#  " + "\t" + "Key" + "\t" + "Count\n");
foreach (var i in treeM.InorderNode())
{
    Console.Write("# " + cm + "\t" + i.Key + "\t" + i.Count);
    ++cm;
    Console.WriteLine();
}


foreach (var i in treeM.InorderTArray())
    Console.Write(i + ", ");

Console.WriteLine(); Console.WriteLine();

treeM.Del(2);

foreach (var i in treeM.InorderNode())
    Console.Write(i.ToString());

foreach (var i in treeM.InorderTArray())
    Console.Write(i + ", ");

Console.WriteLine(); Console.WriteLine();
