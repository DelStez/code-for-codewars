using System.Drawing;
// The rgb function is incomplete.
// Complete it so that passing in RGB decimal values
// will result in a hexadecimal representation being returned.
// Valid decimal values for RGB are 0 - 255.
// Any values that fall out of that range must be rounded
// to the closest valid value.
public class Kata
{
    public static string Rgb(int r, int g, int b) 
    {
        return $"{Normalize(r):X2}{Normalize(g):X2}{Normalize(b):X2}";
    }
    private static byte Normalize(int a)
    {
        return (byte)(a < 0 ?  0 : a > 255 ? 255 : a);
    }
}