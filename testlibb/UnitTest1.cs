using classlib;
namespace testlibb
{
    public class UnitTest1
    {
        [Fact]
        public void Cel_to_Far()
        {
            double a = 36.6;
            string b = "c";
            classochek con = new classochek();
            double result = con.Temp(a, b);
            Assert.Equal(97.88, result);
        }
        [Fact]
        public void Far_to_Cel()
        {
            double a = 97.88;
            string b = "F";
            classochek con = new classochek();
            double result = con.Temp(a, b);
            Assert.Equal(36.6, result);
        }
        [Fact]
        public void Metr_to_Sazhen()
        {
            double a = 2.1335;
            string b = "s";
            classochek con = new classochek();
            double result = con.Lenght(a, b);
            Assert.Equal(1, result);
        }
        [Fact]
        public void Sazhen_to_metr()
        {
            double a = 2.34;
            string b = "m";
            classochek con = new classochek();
            double result = con.Lenght(a, b);
            Assert.Equal(4.990, result);
        }
        [Fact]
        public void Kg_to_Funt()
        { 
            double a = 2;
            string b = "kg";
            classochek con = new classochek();
            double result = con.Weight(a, b);
            Assert.Equal(4.41, result);
        }
        [Fact]
        public void Funt_to_Kg()
        { 
            double a = 4.41;
            string b = "fn";
            classochek con = new classochek();
            double result = con.Weight(a, b);
            Assert.Equal(2, result);
        }
        [Fact]
        public void History_is_empty_by_default()
        { 
            classochek con1 = new classochek();
            Assert.Empty(con1.GetHistory());
        }
        public void History_is_correct()
        {
            classochek con2 = new classochek();
            double a = 4.41;
            string b = "fn";
            double result = con2.Weight(a, b);
            Assert.Contains($"Из фунтов в килограммы: {a} -> {result}", con2.GetHistory());
        }
        [Fact]
        public void History_is_clear()
        { 
            classochek con3 = new classochek();
            double a = 4.41;
            string b = "fn";
            double result = con3.Weight(a, b);
            con3.ClearHistory();
            Assert.Empty(con3.GetHistory());
        }
    }
}
