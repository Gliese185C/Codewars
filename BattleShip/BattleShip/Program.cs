int[,] field = new int[10,10]
   {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
    {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
    {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
byte all = 0;
byte length_vertical= 0;
byte lenght_horizontal = 0;
byte esminet = 0, trio = 0, duo = 0;
bool check(int[,] field, byte row, byte column, int row2, int column2)
{
    try
    {
        if (field[row, column] == field[row2, column2])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    catch
    {
        return false;
    };
}

void new_ship(byte length)
{
    switch (length)
    {
        case 2:
            duo += 1;
            break;
        case 3:
            trio += 1;
            break;
        case 4:
            esminet += 1;
            break;
        default:
            break;
    }
}
bool if_single(int[,] field, int row, int column)
{
    try
    {
        if (field[row, column] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    catch
    {
        return true;
    };
}


for (byte i = 0; i < 10; i++)
{
    for (byte j = 0; j < 10; j++)
    {
        
        if (field[i, j] == 1)
        {
            all += 1;
            if (check(field,i,j,i+1,j+1) || 
                check(field,i,j,i-1,j+1) || 
                check(field,i,j,i-1,j-1) || 
                check(field,i,j,i+1,j-1) )
            {
                Console.WriteLine("Something wrong");
            }

            lenght_horizontal += 1;
        }
        else
        {
            new_ship(lenght_horizontal);
            lenght_horizontal = 0;
        }

        if (field[j, i] == 1)
        {
            length_vertical += 1;
        }
        else
        {
            new_ship(length_vertical);
            length_vertical = 0;
        }
    }
    
}
Console.WriteLine(all);
Console.WriteLine($"esminet {esminet}, trio {trio}, duo {duo}");
Console.WriteLine("All is good");

/*if (if_single(field, i + 1, j) &&
                if_single(field, i - 1, j) &&
                if_single(field, i, j + 1) &&
                if_single(field, i, j - 1))
            {
                uno += 1;
            }
            else
            {
                if (field[i, j + 1] == 1)
                {
                    
                }   
            }*/





    /*byte esminet = 0,trio = 0, duo = 0, uno = 0;
    List<List<List<byte>>> vertical = new List<List<List<byte>>>();
    List<List<byte[]>> horizontal = new List<List<byte[]>>();
byte count = 0;
bool find = false;
for (byte i = 0; i < field.Length; i++)
{
    for (byte j = 0; j < field.Length; j++)
    {
        if (field[i, j] == 1)
        {
            if (i == 0 &&)
            
            
            if (find == false)
            {
                byte[] ship = new byte[2];
                ship[0] = i;
                ship[1] = j;
            }
        }
    }
    
}

/*bool check(int[,] field, byte row, byte column)
{
    bool all_is_good = true;
    if (row == 0 && byte ) 
}*/