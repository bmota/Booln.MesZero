using System.Collections.Generic;
using Booln.MesZero.Editions.Dto;
using Booln.MesZero.MultiTenancy.Dto;

namespace Booln.MesZero.Web.Areas.AppAreaName.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}