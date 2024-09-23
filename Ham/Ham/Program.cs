public int Partion(int l, int r)
{
    int pivot = a[r];
    int i = l;
    for (int j = l; j < r; j++)
        if (a[j] < pivot)
        {
            HoanVi(ref a[i], ref a[j]);
            i++;
        }
    HoanVi(ref a[i], ref a[r]);
    return i;
}
public void Sort(int l, int r)
{
    if (l < r)
    {
        int pi = Partion(l, r);
        Sort(l, pi - 1);
        Sort(pi + 1, r);
    }
}
