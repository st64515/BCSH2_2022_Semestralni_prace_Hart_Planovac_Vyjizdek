using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.ViewModels
{

    public record class StatusTextChanged(string StatusText);
    public record class ViewChanged(string ViewName);
    public record class SaveRequest();
}
