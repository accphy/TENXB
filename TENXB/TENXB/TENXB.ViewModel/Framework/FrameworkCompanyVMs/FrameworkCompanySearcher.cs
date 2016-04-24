using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using TENXB.Resource;

namespace TENXB.ViewModel.Framework.FrameworkCompanyVMs
{
    public class FrameworkCompanySearcher : BaseSearcher
    {
        [Display(Name = "CompanyCode", ResourceType = typeof(Language))]
        public string CompanyCode { get; set; }
        [Display(Name = "CompanyName", ResourceType = typeof(Language))]
        public string CompanyName { get; set; }




        protected override void InitVM()
        { }
    }
}