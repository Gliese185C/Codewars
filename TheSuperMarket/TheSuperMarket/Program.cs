using System.Linq;
public class Kata
{
    public static long QueueTime(int[] m, int n)
    {
        
            if (m.Length == 0){
                return 0;
            }
            else
            {
                if (n >= m.Length)
                {
                    return m.Max();
                }
                else
                {
                    int[] c = new int[n];
                    int answer = 0;
                    for (int i = 0; i < n; i++)
                    {
                        c[i] = m[i];
                    }

                    bool state = false;
                    for (int i = n; i < m.Length; i++)
                    {
                        state = false;
                        answer += c.Min();
                        int tmp = c.Min();
                        for (int j = 0; j < n; j++)
                        {
                            c[j] = c[j] - tmp;
                            if (c[j] == 0)
                            {
                                if (state)
                                    {
                                        i++;
                                    }
                                    
                                    c[j] = m[i];
                                    state = true;
                                    if (i + 1 == m.Length)
                                    {
                                        state = false;
                                    }
                            }
                        }
                    }

                    return answer + c.Max();
                }
            }
        }
}