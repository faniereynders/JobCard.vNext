using JobCard.Core;
using JobCard.Security;
using Microsoft.Graph;
using Reytec.Data.Engine;
using Reytec.JobCard.Core;
using Reytec.JobCard.DAL;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace JobCard.Application.UI
{
    public partial class Main
    {
        private readonly frmConnection frmConnection;

        
        public Main(frmConnection frmConnection, GraphServiceClient graphServiceClient, IAuthenticationFlow authenticationFlow)
        {
            this.InitializeComponent();
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

                var userDto = graphServiceClient.Me.Request().GetAsync();
                var userGroupsDto = graphServiceClient.Me.MemberOf.Request().GetAsync();
                var organizationDto = graphServiceClient.Organization.Request().GetAsync();

                await Task.WhenAll(userDto, userGroupsDto, organizationDto);

                var firstOrganizationResult = organizationDto.Result.First();
                var organization = new OrganizationEntity
                {
                    DisplayName = firstOrganizationResult.DisplayName,
                    Id = firstOrganizationResult.Id
                };

                var userResult = userDto.Result;
                var userGroupsResult = userGroupsDto.Result.ToList();
                var applicationUser = new ApplicationUser
                {
                    DisplayName = userResult.DisplayName,
                    Id = userResult.Id,
                    Groups = userGroupsResult.Cast<Microsoft.Graph.Group>().Select(g =>
                        new UserGroup { Id = g.Id, DisplayName = g.DisplayName }).ToList()
                };

                ApplicationState.User = applicationUser;
                ApplicationState.Organization = organization;
                SignInSuccess();
            }
            catch (Microsoft.Identity.Client.MsalException ex)
            {

                SignIn();
            }
            
            //var token = await validateJwtTokenAsync(result.IdToken);
            //if (token.)
            //{

            //}
        }

        private static async Task<SecurityToken> validateJwtTokenAsync(string token)
        {
            const string TENANT = "1830360c-5d89-409b-8fa4-27204b64c85e";
            const string AUDIENCE = "00000003-0000-0000-c000-000000000000";
            const string CLIENT_ID = "8898135d-4300-4ef2-b007-c62d827a2743";
            // Build URL based on your AAD-TenantId
            string stsDiscoveryEndpoint = "https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration";
            var handler = new JwtSecurityTokenHandler();
            ConfigurationManager<OpenIdConnectConfiguration> configManager = new ConfigurationManager<OpenIdConnectConfiguration>(stsDiscoveryEndpoint, new OpenIdConnectConfigurationRetriever());
            OpenIdConnectConfiguration config = configManager.GetConfigurationAsync().Result;

            try
            {






                TokenValidationParameters validationParameters = new TokenValidationParameters
                {
                    ValidIssuers = new[] { $"https://login.microsoftonline.com/{TENANT}/v2.0" },
                    ValidAudiences = new[] { CLIENT_ID, "https://graph.windows.net" },
                    ValidateAudience = false,
                    ValidateIssuer = true,
                    IssuerSigningKeys = config.SigningKeys,
                    ValidateLifetime = true
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                SecurityToken validatedToken = null;






                tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
                return validatedToken;
            }
            catch (SecurityTokenInvalidSignatureException ex)
            {
                throw;
            }
            catch (SecurityTokenValidationException)
            {
                throw;
            }
            //return validatedToken;
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
