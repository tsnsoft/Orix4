using kz.tsnproff.Orix4.model;
 
namespace kz.tsnproff.Orix4.utils
{
    public interface IOutput
    {
        void println(string text);
        void println(string text, Const.EElementType elementType);
    }
}
