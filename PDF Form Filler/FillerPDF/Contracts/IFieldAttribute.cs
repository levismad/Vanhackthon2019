using System.Collections.Generic;

namespace FillerPDF.Contracts
{
    public interface IFieldAttribute
    {
        Dictionary<string, string> GetValues(object propValue);
    }
}
