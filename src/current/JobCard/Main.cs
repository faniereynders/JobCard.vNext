using JobCard.Core;
using JobCard.Security;
using Microsoft.Graph;
using Reytec.Data.Engine;
using Reytec.JobCard.Core;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using AutoMapper;
using System.Collections.Generic;

namespace JobCard.Application.UI
{
    public partial class Main
    {
        private readonly IMapper mapper;
        private readonly frmConnection frmConnection;

        
        public Main(IMapper mapper, frmConnection frmConnection, GraphServiceClient graphServiceClient, IAuthenticationFlow authenticationFlow)
        {
            this.InitializeComponent();
            this.mapper = mapper;
            // this.
            this.frmConnection = frmConnection;
            this.graphServiceClient = graphServiceClient;
            this.authenticationFlow = authenticationFlow;
        }
        public async Task OpenOrganization(string filename)
        {
            this.ReadFromFile(filename);
            ConnectionInfo.ConnectionFile = filename;
            ConnectionInfo.RefreshConnection();
            this.sql = new DataAccess(ConnectionInfo.GlobalConnection);

            try
            {
                await SignIn();
            }
            catch (Exception ex)
            {

                throw;
            }

           // SignInSuccess();

        }
        public void doBackup()
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        public async Task SignIn()
        {
            try
            {
                await authenticationFlow.SignInAsync();

                var userProfileTask = graphServiceClient.Me.Request().GetAsync();
                var userGroupsTask = graphServiceClient.Me.MemberOf.Request().GetAsync();
                var organizationTask = graphServiceClient.Organization.Request().GetAsync();

                await Task.WhenAll(userProfileTask, userGroupsTask, organizationTask);

                var firstOrganizationResult = organizationTask.Result.First();

                var organization = mapper.Map<OrganizationEntity>(firstOrganizationResult);

                var userResult = userProfileTask.Result;
                var userGroupsResult = userGroupsTask.Result.OfType<Microsoft.Graph.Group>();
                var userWithGroups = new Tuple<Microsoft.Graph.User, IEnumerable<Microsoft.Graph.Group>>(userResult, userGroupsResult);

                var applicationUser = mapper.Map<ApplicationUser>(userWithGroups);

                ApplicationState.User = applicationUser;
                ApplicationState.Organization = organization;
                SignInSuccess();
            }
            catch (Microsoft.Identity.Client.MsalException ex)
            {

                //SignIn();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //var token = await validateJwtTokenAsync(result.IdToken);
            //if (token.)
            //{

            //}
        }

        public void SignOut()
        {
            this.SignedIn = false;
            this.ChangeState();
            //var frmConnection = serviceProvider.GetService<frmConnection>();
            // frmConnection.CompanyNameChanged += new frmConnection.CompanyNameChangedEventHandler(this.CompanyNameChanged);
            JobFunctions.ShowBodyForm(this.pnlBody, (Form)frmConnection, this.lblTitle);
            //JobFunctions.ShowBodyForm(this.pnlBody, serviceProvider.GetService<AzureLoginForm>(), this.lblTitle);
        }
        public void ChangeState()
        {
            if (this.SignedIn)
            {
                this.lblCompanyName.Text = ApplicationState.Organization.DisplayName;
                this.stlblCompanyName.Image = this.ImageList1.Images[0];
                this.stlblCompanyName.Text = "Connected to " + this.lblCompanyName.Text;
                this.pnlMenu.Enabled = true;
                this.lblUser.Text = ApplicationState.User.DisplayName;
            }
            else
            {
                this.lblCompanyName.Text = "";
                this.stlblCompanyName.Text = "Not connected";
                this.stlblCompanyName.Image = this.ImageList1.Images[1];
                this.pnlMenu.Enabled = false;
                this.lblUser.Text = "";
            }
        }

        public void SignInSuccess()
        {
            this.pnlBody.Controls.Clear();
            this.SignedIn = true;
            this.ChangeState();
        }
        public void ReadFromFile(string filename)
        {
            var strArray1 = new string[1];
            var strArray2 = Strings.Split(System.IO.File.ReadAllText(filename), "\r\n");
            this.CompanyFileName = strArray2[0];
            this.ServerName = strArray2[1];
            this.DatabaseName = strArray2[2];

        }
    }
}
