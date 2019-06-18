namespace List_Demo_2
{
    class Car
    {
        readonly string vin;
        readonly string model;
        readonly int cylinders;
        readonly string color;
        readonly string trim;
        readonly int milage;

        public Car(string _vin, string _model, int _cylinders, string _color, string _trim, int _milage = 0)
        {
            vin = _vin;
            model = _model;
            cylinders = _cylinders;
            color = _color;
            trim = _trim;
            milage = _milage;
        }

        public override string ToString()
        {
            return $"{vin} {model} {trim}\t {cylinders} cyl  {color} {milage}";
        }
    }
}
