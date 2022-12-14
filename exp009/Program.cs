int count = 0;
int firstFrSp = 1;
int secFrSp = 2;
int dogSp = 5;
int dist = 10000;
int fr = 2;
int time = 0;

while(dist>10)
{
    if (fr == 1)
    {
        time = dist/(firstFrSp + dogSp);
        fr = 2;
    }
    else
    {
        time = dist/(secFrSp + dogSp);
        fr = 1;
    }
    dist = dist - (firstFrSp + secFrSp) * time;
    count+=1;

}

Console.WriteLine(count);