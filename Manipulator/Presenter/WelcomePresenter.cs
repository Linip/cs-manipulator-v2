using System.Windows.Forms;
using Manipulator.Presenter.Exceptions;
using Manipulator.View;

namespace Manipulator.Presenter
{
    public class WelcomePresenter
    {
        public static string DemandControlObjectName(Form owner)
        {
            var form = new WelcomeSimulationForm();
            var dialogResult = form.ShowDialog(owner);
            var name = form.getControlObjectName();

            if (dialogResult != DialogResult.OK || name.Length == 0)
            {
                throw new WelcomeNotEnterObjectNameException();
            }

            return name;
        }
    }
}