using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1Sanity.WPF.ModelViews;
using M1Sanity.WPF.Views;

namespace M1Sanity.WPF.ModelViews
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; private set; }

        public AppBootstrapper(IMutableDependencyResolver dependencyResolver = null, RoutingState testRouter = null)
        {
            Router = testRouter ?? new RoutingState();
            dependencyResolver = dependencyResolver ?? Locator.CurrentMutable;

            // Bind 
            RegisterParts(dependencyResolver);

            // TODO: This is a good place to set up any other app startup tasks

            // Navigate to the opening page of the application
            Router.Navigate.Execute(new M1SanityViewModel(this));
        }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.RegisterConstant(this, typeof(IScreen));

            dependencyResolver.Register(() => new M1SanityView(), typeof(IViewFor<M1SanityViewModel>));
            //dependencyResolver.Register(() => new SecondView(), typeof(IViewFor<SecondViewModel>));
        }
    }
}
