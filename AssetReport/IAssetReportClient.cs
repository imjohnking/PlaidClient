using System.Threading.Tasks;

namespace Take5ive.Plaid.AssetReport
{
    public interface IAssetReportClient
    {
        public Task<CreateReportResponse> CreateReport(CreateReportRequest request);

        public Task<RefreshReportResponse> RefreshReport(RefreshReportRequest request);

        public Task<CreateReportResponse> FilterReport(FilterReportRequest request);

        public Task<RemoveReportResponse> RemoveReport(RemoveReportRequest request);

        public Task<GetReportResponse> GetReport(GetReportRequest request);

        public Task<CreateAuditCopyResponse> CreateAuditCopy(CreateAuditCopyRequest request);

        public Task<RemoveAuditCopyResponse> RemoveAuditCopy(RemoveAuditCopyRequest request);
    }
}
