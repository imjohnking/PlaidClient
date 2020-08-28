using System.Net.Http;
using System.Threading.Tasks;
using static Take5ive.Plaid.Core;

namespace Take5ive.Plaid.AssetReport
{
    /// <summary>
    /// Handles all of the Asset Report related requests to the Plaid API.
    /// </summary>
    public class AssetReportClient : IAssetReportClient
    {
        private readonly HttpClient _httpClient;
        private readonly PlaidConfig _plaidConfig;

        public AssetReportClient(HttpClient httpClient, PlaidConfig plaidConfig)
        {
            _httpClient = httpClient;
            _plaidConfig = plaidConfig;
        }

        /// <summary>
        /// Create a token to provide an Audit Copy of any Asset Report directly to a participating third party on your behalf.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Audit copy token</returns>
        /// <remarks>https://plaid.com/docs/#4-share-an-audit-copy</remarks>
        public async Task<CreateAuditCopyResponse> CreateAuditCopy(CreateAuditCopyRequest request)
        {
            request.DestinationUri = "asset_report/audit_copy/create";
            return await SendRequest<CreateAuditCopyResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Retrieve point-in-time snapshots of an Item or set of Items, including account balances,
        /// historical transactions, and account holder identity information.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Asset report tokens.</returns>
        /// <remarks>https://plaid.com/docs/#2-create-an-asset-report</remarks>
        public async Task<CreateReportResponse> CreateReport(CreateReportRequest request)
        {
            request.DestinationUri = "asset_report/create";
            return await SendRequest<CreateReportResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Narrow an Asset Report to only a subset of Accounts.
        /// </summary>
        /// <param name="request">Request object identifying report and accounts to filter.</param>
        /// <returns>Asset report tokens.</returns>
        /// <remarks>https://plaid.com/docs/#specifying-which-accounts-appear-in-the-asset-report</remarks>
        public async Task<CreateReportResponse> FilterReport(FilterReportRequest request)
        {
            request.DestinationUri = "asset_report/filter";
            return await SendRequest<CreateReportResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Retrieve Asset Report
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Asset report</returns>
        /// <remarks>https://plaid.com/docs/#3-retrieve-an-asset-report</remarks>
        public async Task<GetReportResponse> GetReport(GetReportRequest request)
        {
            request.DestinationUri = "asset_report/get";
            return await SendRequest<GetReportResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Refresh snapshots of an Item or set of Items, including account balances,
        /// historical transactions, and account holder identity information.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Asset report tokens.</returns>
        /// <remarks>https://plaid.com/docs/#refreshing-an-asset-report</remarks>
        public async Task<RefreshReportResponse> RefreshReport(RefreshReportRequest request)
        {
            request.DestinationUri = "asset_report/refresh";
            return await SendRequest<RefreshReportResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Remove an Audit Copy of an Asset Report
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Boolean value indicating successful removal.</returns>
        /// <remarks>https://plaid.com/docs/#remove-asset-reports-and-audit-copies</remarks>
        public async Task<RemoveAuditCopyResponse> RemoveAuditCopy(RemoveAuditCopyRequest request)
        {
            request.DestinationUri = "asset_report/audit_copy/remove";
            return await SendRequest<RemoveAuditCopyResponse>(request, _httpClient, _plaidConfig);
        }

        /// <summary>
        /// Remove an Asset Report.
        /// </summary>
        /// <param name="request">Request object containing desired Plaid parameters.</param>
        /// <returns>Boolean value indicating successful removal.</returns>
        /// <remarks>https://plaid.com/docs/#remove-asset-reports-and-audit-copies</remarks>
        public async Task<RemoveReportResponse> RemoveReport(RemoveReportRequest request)
        {
            request.DestinationUri = "asset_report/remove";
            return await SendRequest<RemoveReportResponse>(request, _httpClient, _plaidConfig);
        }
    }
}
