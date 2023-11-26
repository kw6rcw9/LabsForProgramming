namespace LSP;

public class Triangle: IFigure
{
    private float _aSide;
    private float _bSide;
    private float _cSide;
    public Triangle(float aSide, float bSide, float cSide)
    {
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }
    public double GetArea()
    {
        double p = (_aSide + _bSide + _cSide) / 2;
        return Math.Round(Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide)), 2);
    }
}