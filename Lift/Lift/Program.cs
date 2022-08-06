using System.Collections.Generic;

int[][] queues =
{
    new int[0], // G
    new int[]{3,3,3,0,0,0,0,0,3}, // 1
    new int[0], // 2
    new int[]{1,1,1}, // 3
    new int[0], // 4
    new int[0], // 5
    new int[0], // 6
};

int capacity = 2;
int etaj = 0;
List<int> oprire = new List<int>() { 0 };
List<int> lift = new List<int>();
int total = 0;
for (int i = 0; i < queues.Length; i++)
{
    total += queues[i].Length;
}
string direction = "up";
bool l16 = true;
while (l16)
{
    if (direction == "up")
    {
        bool? ostanovka = false;
        // aici din lift ies acei care au vrut sa vina la acest etaj
        int count = lift.Count();
        int count2 = 0;
        for (int i = 0; i < count-count2; i++)
        {
            if (lift[i] == etaj)
            {
                lift.RemoveAt(i);
                total -= 1;
                count2++;
                i--;
                ostanovka = true;
            }
        }
        // aici lift alege pe cei care vreau sa coboara la etaj mai sus si daca mai este locul in lift
        for (int i = 0; i < queues[etaj].Length; i++)
        {
            if (queues[etaj][i] > etaj && lift.Count() < capacity)
            {
                lift.Add(queues[etaj][i]);
                queues[etaj][i] = -1;
                ostanovka = true;
            }
            if (queues[etaj][i] > etaj && queues[etaj][i] != -1)
            {
                ostanovka = true;
            }
        }
        if (ostanovka == true)
        {
            if (oprire.ElementAt(oprire.Count - 1) != etaj)
            {
                oprire.Add(etaj);
            }
        }
        // aici verificam ca lift este la etaj max, daca true atunci schimbam directia la jos
        if (etaj == queues.Length - 1)
        {
            direction = "down";
        }
        else
        {
            etaj += 1;
        }
        
        if (total == 0)
        {
            l16 = false;
        }
    }
    else
    {
        bool? ostanovka = false;
        // aici din lift ies acei care au vrut sa vina la acest etaj
        int count = lift.Count();
        int count2 = 0;
        for (int i = 0; i < count-count2; i++)
        {
            if (lift[i] == etaj)
            {
                lift.RemoveAt(i);
                total -= 1;
                count2++;
                i--;
                ostanovka = true;
            }
        }
        // aici lift alege pe cei care vreau sa coboara la etaj mai jos si daca mai este locul in lift
        for (int i = 0; i < queues[etaj].Length; i++)
        {
            if ((queues[etaj][i] < etaj && queues[etaj][i] != -1) && lift.Count() < capacity)
            {
                lift.Add(queues[etaj][i]);
                queues[etaj][i] = -1;
                ostanovka = true;
            }

            if (queues[etaj][i] < etaj && queues[etaj][i] != -1)
            {
                ostanovka = true;
            }
    }
        if (ostanovka == true)
        {
            if (oprire.ElementAt(oprire.Count - 1) != etaj)
            {
                oprire.Add(etaj);
            }
        }
        if (etaj == 0)
        {
            direction = "up";
        }
        else
        {
            etaj -= 1;
        }
    }
    if (total == 0)
    {
        l16 = false;
    }
}
if (oprire.ElementAt(oprire.Count() - 1) != 0)
{
    oprire.Add(0);
}
return oprire.ToArray();


/*foreach (int item in oprire)
{
    Console.Write($"{item} ");
}*/
