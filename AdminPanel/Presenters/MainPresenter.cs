using System.Collections.Generic;
using System.Linq;
using Manipulator.Shared.Infrastructure;
using Manipulator.Shared.Models;

namespace AdminPanel.Presenters
{
    public class MainPresenter
    {
        public readonly List<DispatcherViewRecord> TableRecords;
        private MainForm _form;

        public MainPresenter(MainForm form)
        {
            _form = form;
            _form.Presenter = this;

            using (var db = new SqliteContext())
            {
                var recordsQuery =
                    from dispatcherViewRecord in db.DispatcherViewRecords
                    select dispatcherViewRecord;

                TableRecords = recordsQuery.ToList();
            }
        }
    }
}