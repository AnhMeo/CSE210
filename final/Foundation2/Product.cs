public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._pricePerUnit = pricePerUnit;
        this._quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}