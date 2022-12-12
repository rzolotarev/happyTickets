
var length = 6;
var measure = 12;
var sums = new long[length + 1, length * measure + 1];
for (var i = 0; i <= measure; i++)
    sums[1, i] = 1;

for (var i = 2; i <= length; i++)
{
    for (var s = 0; s <= i * measure; s++)
    {
        for (var k = 0; k <= s && k <= measure; k++)
        {
            sums[i, s] += sums[i - 1, s - k];
        }
    }
}

var happyTickets = 0L;
for (var i = 0; i <= length * measure; i++)
{
    happyTickets += (sums[length, i] * sums[length, i]);
}

happyTickets *= measure + 1;
Console.WriteLine(happyTickets);

//9 203 637 295 151