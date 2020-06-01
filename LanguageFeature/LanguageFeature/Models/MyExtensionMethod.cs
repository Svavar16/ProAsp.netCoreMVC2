namespace LanguageFeature.Models {
    public static class MyExtensionMethod {
        public static decimal TotalPrices(this ShoppingCart cartParams) {
            decimal total = 0;
            foreach (Product prod in cartParams.Products) {
                total = prod?.Price ?? 0;
            }

            return total;
        }
    }
}