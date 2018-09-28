/***********************************************************************************************************************************
*                                                 GOD First                                                                        *
* Author: Dustin Ledbetter                                                                                                         *
* Release Date: 9-23-2018                                                                                                          *
* Version: 1.0                                                                                                                     *
* Purpose: To create a second extension for the storefront to test how they work                                                   *
************************************************************************************************************************************/

using Pageflex.Interfaces.Storefront;


namespace MySecondExtension
{

    public class ExtensionTwo : StorefrontExtension
    {

        #region Extension Name Overides
        // At a minimum your extension must override the DisplayName and UniqueName properties.


        // The UniqueName is used to associate a module with any data that it provides to Storefront.
        public override string UniqueName
        {
            get
            {
                return "ExtensionTwo.ShippingCharge.website.com";
            }
        }

        // The DisplayName will be shown on the Extensions and Site Options pages of the Administrator site as the name of your module.
        public override string DisplayName
        {
            get
            {
                return "Extension Two";
            }
        }
        #endregion


        #region This section is used to determine if we are in the "shipping" module on the storefront or not

        public override bool IsModuleType(string x)
        {

            // If we are in the shipping module return true to begin processes for this module
            if (x == "Shipping")
                return true;
            else
                return false;
        }

        #endregion


        #region these are to be implemented in the next extension

        // EnumeratePickLists


        // MakeItem


        // GetPickListData


        // GetConfigurationHtml

        #endregion


        #region This section shows two methods to change data in the shipping section

        // This method changes the handling fee on the shipping page as long as a preset handling fee is not applied to the item
        public override int CalculateHandlingCharge(string orderId, out double handlingCharge, out string isoCurrencyCode)
        {
            handlingCharge = 8.00;
            isoCurrencyCode = "USD";

            return eSuccess;
        }


        // Currently unused as the fedex extension overrides it (left to keep in mind how some extesnion can ovveride each other or take precedence)
        public override int CalculateShippingCharge2(string orderID, string shipmentID, out double shippingCharge, out string isoCurrencyCode)
        {
            shippingCharge = 25.00;
            isoCurrencyCode = "USD";

            return eSuccess;
        }

        #endregion


        //end of the class: ExtensionTwo
    }
    //end of the file
}
