class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(string cname, string street, string city, string state, string country){
        _customer = new Customer(cname, street, city, state, country);
    }

    private double ShippingCost(){
        if (_customer.IsNational() == true){
            return 5.0;
        }
        else {
            return 35.0;
        }
    }

    public void AddProduct(string name, string id, double price, double quantity){
        Product newProd = new Product(name, id, price, quantity);
        _products.Add(newProd);
    }

    public double TotalCost(){
        
        double totalCost = 0.0;
        foreach (Product product in _products){
            totalCost += product.TotalPrice();
        }
        totalCost += ShippingCost();
        return Math.Round(totalCost, 2);
    }

    public string PackingLabel(){
        int productNum = 1;
        string orderProducts = "";
        foreach (Product product in _products){
            orderProducts += $"{productNum}. Product: {product.GetName()}\n   ID: {product.GetId()}\n";
            productNum += 1;
        }
        return orderProducts;
    }

    public string ShippingLabel(){
        return _customer.GetCustomerInfo();
    }

}