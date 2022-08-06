using Microsoft.VisualBasic.CompilerServices;
int n = 5;
int[,] list = new int[n,n];
string direction = "up";
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0 || i == n - 1 || j == n - 1 || (j == 0 && i != 1))
        {
            list[i, j] = 1;
        }
        else
        {
            list[i, j] = 0;
        }
    }
}
int row = 2, column = 0;
bool zmei = true;
while (zmei)
{
    if (direction == "left")
    {
        if (list[row,column-2] == 1)
        {
            if (list[row-2,column] == 1)
            {
                list[row, column] = 1;
                break;
            }
            else
            {
                direction = "up";
                list[row, column] = 1;
            }
        }
        else
        {
            list[row, column] = 1;
            column -= 1;
        }
    }
    if (direction == "down")
    {
        if (list[row+2,column] == 1)
        {
            if (list[row,column-2] == 1 || list[row-1,column-1] == 1 )
            {
                list[row, column] = 1;
                break;
            }
            else
            {
                direction = "left";
                list[row, column] = 1;
            }
        }
        else
        {
            list[row, column] = 1;
            row += 1;
        }
    }
    if (direction == "right")
    {
        if (list[row,column + 2] == 1)
        {
            if (list[row + 2,column] == 1)
            {
                list[row, column] = 1;
                break;
            }
            else
            {
                direction = "down";
                list[row, column] = 1;
            }
        }
        else
        {
            list[row, column] = 1;
            column += 1;
        }
    }
    if (direction == "up")
    {
        if (list[row-2,column] == 1)
        {
            if (list[row,column + 2] == 1 || list[row+1,column+1] == 1)
            {
                list[row, column] = 1;
                break;
            }
            else
            {
                direction = "right";
                list[row, column] = 1;
            }
        }
        else
        {
            list[row, column] = 1;
            row -= 1;
        }
    }
}
