using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace M1Sanity.WPF.Infrastructure
{
    public interface IM1SanityViewModel : IRoutableViewModel
    {
        ReactiveCommand<Unit, Unit> HelloWorld { get; }
    }
}
