public class Fraction 
{
    //Originally I thought we needed to use the Get and Set functions so after using my functions to hard set the _top and _bottom
    //values, I incorporated the Get and Set functions. I think not using those functions is a lot easier though.
    private int _top;
    private int _bottom;

    public Fraction() {
        SetTop(1);
        SetBottom(1);
    }
    public Fraction(int WholeNumber) {
        SetTop(WholeNumber);
        SetBottom(1);
    }

    public Fraction(int top, int bottom) {
        // _top = top;
        // _bottom = bottom;
        SetTop(top);
        SetBottom(bottom);
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int top) {
        _top = top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

    public string GetFractionString() {
        int top = GetTop();
        int bottom = GetBottom();
        string frac = $"{top}/{bottom}";
        return frac;
    }

    public double GetDecimalValue() {
        double top = GetTop();
        double bottom = GetBottom();
        double decValue = top / bottom;
        return decValue;
    }

}