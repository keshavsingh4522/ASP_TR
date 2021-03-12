# Collections
- Array
```C#
synatx:
 int[] arr = new int[10];

// these below 3 things are not possible with array
- increasing the size
- inserting values into the middle
- Deleting or removing value

// these above are poosible with ArrayList in Collection

````
- Non Generic Collections
```
Stack, Queue, LinkedList,SortedList,ArrayList,hashtable
```
- ArrayList
```C#
ArrayList al = new ArrayList();
al.add(100);
Console.WriteLine(al.Capacity) // 4
// after adding 5 item , the capacity will double  as become 8
// after adding 9th item the capacity will also double to 16 ...
```
```C#
// we can assign the size to ArrayList in start as
ArrayList al = new ArrayList(10);

// after adding 11th item its size will double as 20 and so on ...
```
```
al.insert(index,value);
al.Remove(value);
al.RemoveAt(index);
```