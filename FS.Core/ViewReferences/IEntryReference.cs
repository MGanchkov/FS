using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ViewReferences;

public interface IEntryReference <TValue> where TValue : ViewModels.IEntry
{
    
    public long ID { get; set; }

    public TValue Loading();

}
