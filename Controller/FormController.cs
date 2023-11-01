using PLApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Controller
{
    internal class FormController
    {
        private TabControl tbcMain;
        private TabPage tbpDashboard;
        private TabPage tbpContent;

        public FormController(TabControl tbcMain, TabPage tbpDashboard, TabPage tbpContent) {
            this.tbcMain = tbcMain;
            this.tbpDashboard = tbpDashboard;
            this.tbpContent = tbpContent;

        }

        public void mainTabControll(TAB_ACTION action)
        {

            if (action == TAB_ACTION.ADD)
            {
                tbcMain.TabPages.Add(tbpContent);
                tbcMain.SelectedTab = tbpContent;
            }
            else if (action == TAB_ACTION.REMOVE)
            {
                tbcMain.TabPages.Remove(tbpContent);
                tbcMain.SelectedTab = tbpDashboard;
            }
        }

        public void AddFormToPanel(Panel tp, Form f)
        {

            TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Factory.StartNew(() =>
            {

                if (!tp.Controls.Contains(f))
                {
                    tp.Controls.Clear();
                    f.TopLevel = false;
                    //tp.Controls.Add(f);
                    f.Parent = tp;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    //tp.Refresh();
                }
                tp.Refresh();

            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }


    }
}
