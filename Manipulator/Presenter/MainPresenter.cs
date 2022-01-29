using Manipulator.View;

namespace Manipulator.Presenter
{
    public class MainPresenter
    {
        
        private readonly MainForm _view;

        public MainPresenter(MainForm view)
        {
            _view = view;
            view.Presenter = this;
        }

        public void RunSimulation()
        {
            throw new System.NotImplementedException();
        }
    }
}