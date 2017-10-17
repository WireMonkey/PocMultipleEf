using System.Collections.Generic;
using System.Linq;
using PocMultipleEntities.Data;
using PocMultipleEntities.Poco;

namespace PocMultipleEntities.Business
{

    public class StandardInventoryDetailsOperations : InventoryDetailsOperations
    {
        public StandardInventoryDetailsOperations(IEntities entities)
        {
            _entities = entities;
            database = Databases.Standard;
        }
        
        public dynamic GetDetailsViewModels()
        {
            using (var context = _entities.GetDbContext(database))
            {
                return ((IEnumerable<dynamic>)context.InventoryDetails).Select(x =>
                {
                    dynamic newItem = new InventoryDetailsViewModel();
                    newItem.LongDescription = x.LongDescription;
                    newItem.Alias = x.Alias;
                    newItem.Version = x.Version;
                    newItem.RevisionDate = x.RevisionDate;
                    newItem.RevisionReason = x.RevisionReason;
                    newItem.Predecessor = x.Predecessor;
                    newItem.InventoryTypeID = x.InventoryTypeID;
                    newItem.DocumentType = x.DocumentType;
                    newItem.FormOwner = x.FormOwner;
                    newItem.FormCostCenter = x.FormCostCenter;
                    newItem.ProductCategory = x.ProductCategory;
                    newItem.ProductNumber = x.ProductNumber;
                    newItem.Channel = x.Channel;
                    newItem.Viewability = x.Viewability;
                    newItem.CanBackorder = x.CanBackorder;
                    newItem.IsFulfillment = x.IsFulfillment;
                    newItem.IsMarketing = x.IsMarketing;
                    newItem.IsUserKitContainer = x.IsUserKitContainer;
                    newItem.IsBulkOrder = x.IsBulkOrder;
                    newItem.SpecialMessage = x.SpecialMessage;
                    newItem.SpecialMessageActivationDate = x.SpecialMessageActivationDate;
                    newItem.SpecialMessageDeactivationDate = x.SpecialMessageDeactivationDate;
                    newItem.InventoryPricingTypeID = x.InventoryPricingTypeID;
                    newItem.IsPrintCostApproved = x.IsPrintCostApproved;
                    newItem.NoCostItem = x.NoCostItem;
                    newItem.PricingType = x.PricingType;
                    newItem.PrintCost = x.PrintCost;
                    newItem.FulfillmentCost = x.FulfillmentCost;
                    newItem.ChargebackCost = x.ChargebackCost;
                    newItem.OrderQtyMin = x.OrderQtyMin;
                    newItem.OrderQtyMax = x.OrderQtyMax;
                    newItem.OrderQtyMax = x.OrderQtyMax;
                    newItem.ReplaceDate = x.ReplaceDate;
                    newItem.ReplacePart = x.ReplacePart;
                    newItem.ReplaceReason = x.ReplaceReason;
                    newItem.EffectiveDate = x.EffectiveDate;
                    newItem.ObsoleteDate = x.ObsoleteDate;
                    newItem.IsObsoleted = x.IsObsoleted;
                    newItem.IsReplaced = x.IsReplaced;
                    newItem.IncludeState = x.IncludeState;
                    newItem.ExcludeState = x.ExcludeState;
                    newItem.Popularity = x.Popularity;
                    newItem.PageflexJobName = x.PageflexJobName;
                    newItem.CalculatedMaxOrderQty = x.CalculatedMaxOrderQty;
                    newItem.BusinessOwnerRoleID = x.BusinessOwnerRoleID;
                    newItem.OrderQtyMaxFrequency = x.OrderQtyMaxFrequency;
                    newItem.CreateDate = x.CreateDate;
                    newItem.CreateUser = x.CreateUser;
                    newItem.ModDate = x.ModDate;
                    newItem.ModUser = x.ModUser;
                    newItem.IsAppBuilder = x.IsAppBuilder;
                    newItem.AppBuilderSort = x.AppBuilderSort;
                    newItem.CanRemoveDuplicates = x.CanRemoveDuplicates;
                    newItem.PersonalizeFillableFields = x.PersonalizeFillableFields;
                    newItem.ServiceProductIds = x.ServiceProductIds;
                    return newItem;
                }).ToList();
            }
        }
    }
}
