using Newtonsoft.Json.Linq;

namespace PocMultipleEntities.Poco
{
    public class InventoryDetailsViewModel : JObject
    {
        public string LongDescription { get; set; }
        public string Alias { get; set; }
        public string Version { get; set; }
        public string RevisionDate { get; set; }
        public string RevisionReason { get; set; }
        public string Predecessor { get; set; }
        public string InventoryTypeID { get; set; }
        public string DocumentType { get; set; }
        public string FormOwner { get; set; }
        public string FormCostCenter { get; set; }
        public string ProductCategory { get; set; }
        public string ProductNumber { get; set; }
        public string Viewability { get; set; }
        public string CanBackorder { get; set; }
        public string IsFulfillment { get; set; }
        public string IsMarketing { get; set; }
        public string IsUserKitContainer { get; set; }
        public string IsBulkOrder { get; set; }
        public string SpecialMessage { get; set; }
        public string SpecialMessageActivationDate { get; set; }
        public string SpecialMessageDeactivationDate { get; set; }
        public string InventoryPricingTypeID { get; set; }
        public string IsPrintCostApproved { get; set; }
        public string NoCostItem { get; set; }
        public string PricingType { get; set; }
        public string PrintCost { get; set; }
        public string FulfillmentCost { get; set; }
        public string ChargebackCost { get; set; }
        public string OrderQtyMin { get; set; }
        public string OrderQtyMax { get; set; }
        public string ReplaceType { get; set; }
        public string ReplaceDate { get; set; }
        public string ReplacePart { get; set; }
        public string ReplaceReason { get; set; }
        public string EffectiveDate { get; set; }
        public string ObsoleteDate { get; set; }
        public string IsObsoleted { get; set; }
        public string IsReplaced { get; set; }
        public string IncludeState { get; set; }
        public string ExcludeState { get; set; }
        public string Popularity { get; set; }
        public string PageflexJobName { get; set; }
        public string CalculatedMaxOrderQty { get; set; }
        public string BusinessOwnerRoleID { get; set; }
        public string OrderQtyMaxFrequency { get; set; }
        public string CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string ModDate { get; set; }
        public string ModUser { get; set; }
        public string IsAppBuilder { get; set; }
        public string AppBuilderSort { get; set; }
        public string CanRemoveDuplicates { get; set; }

    }
}
