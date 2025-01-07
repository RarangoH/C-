



public class PairOfArrays<TLeft, TRight>
{
    private readonly TLeft[] _left;
    private readonly TRight[] _right;

    public PairOfArrays(
        TLeft[] left, TRight[] right)
    {
        _left = left;
        _right = right;
    }

    public (TLeft left,TRight right) this[int indexLeft, int indexRight]
    {
        get => (_left[indexLeft], _right[indexRight]);
        set {
            _left[indexLeft] = value.left;
            _right[indexRight] = value.right;
        }
    }
    
}