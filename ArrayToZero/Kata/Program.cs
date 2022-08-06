

//my solution
int[] zero = {1,0,2,0,3,0,4,0};
int[] new_zer = new int[zero.Length];
int count = 0;
for (int i = 0; i < zero.Length; i++)
{
    if (zero[i] != 0)
    {
        new_zer[count] = zero[i];
        count++;
    }
}
//expert solution
zero.OrderBy(x => x==0).ToArray();