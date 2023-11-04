using PLApp.Constants;
using PLApp.Controller;
using PLApp.Forms.BankAccountManagement;
using PLApp.Forms.ImportBankStatement;

namespace PLApp
{
    public partial class PLApp : Form
    {
        FormController formController;
        public PLApp()
        {
            InitializeComponent();
            formController = new FormController(tbcMain, tbpDashboard, tbpContent,pnlContent);
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

        private void btnUpdateTaskList_Click(object sender, EventArgs e)
        {
            lblContentTitle.Text = "Import Bank Statement";
            formController.mainTabControll(TAB_ACTION.ADD);
            ImportBankStatementFormStep1 tempForm = new ImportBankStatementFormStep1(formController);
            formController.AddFormToPanel(pnlContent, tempForm);
        }
    }
}