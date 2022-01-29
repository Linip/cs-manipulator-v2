using Manipulator.View;

namespace Manipulator.Presenter
{
    public class MainPresenter
    {
        
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            view.Presenter = this;
        }
    }
}