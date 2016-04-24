using WalkingTec.Mvvm.Core;
using TENXB.Model;

namespace TENXB.ViewModel.Framework.FrameworkCompanyVMs
{
    public class FrameworkCompanyBatchVM : BaseBatchVM<FrameworkCompany, BaseVM>
    {
        public FrameworkCompanyBatchVM()
        {
            ListVM = new FrameworkCompanyListVM();
        }
    }

}
