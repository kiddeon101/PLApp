using PLApp.Constants;
using PLApp.Controller;
using PLApp.Forms.BankAccountManagement;

namespace PLApp
{
    public partial class PLApp : Form
    {
        FormController formController;
        public PLApp()
        {
            InitializeComponent();
            formController = new FormController(tbcMain, tbpDashboard, tbpContent);
        }

        private void PLApp_Load(object sender, EventArgs e)
        {
            formController.mainTabControll(TAB_ACTION.REMOVE);
        }

        private void btnUpdateCompanyInformation_Click(object sender, EventArgs e)
        {
            lblContentTitle.Text = "Bank Management";
            formController.mainTabControll(TAB_ACTION.ADD);
            BankAccManagementForm tempForm = new BankAccManagementForm(formController);
            formController.AddFormToPanel(pnlContent, tempForm);
        }
    }
}