using M1Sanity.WPF.Infrastructure;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M1Sanity.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour M1SanityView.xaml
    /// </summary>
    public partial class M1SanityView : ReactiveUserControl<IM1SanityViewModel>
    {
        public M1SanityView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext));
                // d(this.BindCommand(ViewModel, vm => vm.HelloWorld, view => view.helloWorldButton));
            });
        }
    }
}
